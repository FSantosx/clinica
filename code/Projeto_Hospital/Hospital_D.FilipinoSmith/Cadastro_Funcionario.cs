using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;//1

namespace Hospital_D.FilipinoSmith
{
    public partial class Cadastro_Funcionario : Form
    {
        bool okFuncionario = false, okbusca, which = false;
        AForge.Video.DirectShow.VideoCaptureDevice videoSource;
        string caminho_img = @"C:\Users\Guilherme Souza\Documents\Gsouza\Projeto H\Hospital_D.FilipinoSmith\Hospital_D.FilipinoSmith\bin\Debug";
        string funcao = "";

        public Cadastro_Funcionario(bool which)
        {
            InitializeComponent();
            this.which = which;
        }

        public void inserir_imagem(object sender, EventArgs e)
        {
            OpenFileDialog local_imagem = new OpenFileDialog();
            if (local_imagem.ShowDialog() != DialogResult.OK)
                return;
            perfilPB.ImageLocation = local_imagem.FileName;
            perfilPB.SizeMode = PictureBoxSizeMode.Zoom;
            caminho_img = local_imagem.FileName;
        }

        public void Insere_Funcionarios()
        {
            funcao = FuncaoFun_Combo.SelectedItem.ToString();
            Banco.Insert_Funcionarios(txt_nomeFun.Text, Mtxt_rgFun.Text, Mtxt_cpfFun.Text.Replace("-", "").Replace(",", "").Replace(" ", ""),                                                       txt_StatusFun.Text,FuncaoFun_Combo.SelectedItem.ToString(),
                                      caminho_img);
            if (funcao == "Médico")
                Banco.Insert_Medico(EspeciaMedico_Combo.SelectedItem.ToString(), Mtxt_HorarioMedico.Text);
            else if (funcao == "Enfermeiro")
                Banco.Insert_Enfermeiro(txt_StatusFun.Text);
        }
        
        public void Buscar_Funcionarios()
        {
            okbusca = true;
            lbbuscaerro.Visible = false;
            Banco.Select_All_Dados_Funcionario(Mtxtbusca.Text, txt_nomeFun, Mtxt_rgFun, Mtxt_cpfFun,
                                               txt_StatusFun, FuncaoFun_Combo, Mtxt_HorarioMedico,
                                               EspeciaMedico_Combo, perfilPB, ref okbusca);
            if (okbusca)
            {
                Gb_DadosFun.Enabled = true;
                Gb_Medico.Enabled = true;
                lbdone.Visible = true;
                lbbuscaerro.Visible = false;
            }
            else
            {
                Gb_DadosFun.Enabled = false;
                Gb_Medico.Enabled = false;
                lbdone.Visible = false;
                lbbuscaerro.Visible = true;
            }
        }

        public void choise()
        {
            if(FuncaoFun_Combo.SelectedItem.ToString() == "Médico")
            {
                Gb_Medico.Enabled = true;
            }
            else
            {
                Gb_Medico.Enabled = false;
            }
        }

        private void FuncaoFun_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FuncaoFun_Combo.SelectedIndex != -1)
            {
                choise();
                funcao = FuncaoFun_Combo.SelectedItem.ToString();
            }
        }

        private void sair(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
            this.Close();
        }

        private void Ini_tirar_foto()
        {
            AForge.Video.DirectShow.FilterInfoCollection videosources = new AForge.Video.DirectShow.FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice);
            if (videosources != null)
            {
                videoSource = new AForge.Video.DirectShow.VideoCaptureDevice(videosources[0].MonikerString);
                videoSource.NewFrame += (s, f) => perfilPB.Image = (Bitmap)f.Frame.Clone();
                videoSource.Start();
            }

        }

        public void tirar_foto(object sender, EventArgs e)
        {
            if (take.Text == "Save")
            {
                perfilPB.Image.Save("snapshot.png", System.Drawing.Imaging.ImageFormat.Png);
                videoSource.SignalToStop();
                videoSource = null;
                perfilPB.ImageLocation = @".\snapshot.png";
                perfilPB.SizeMode = PictureBoxSizeMode.Zoom;
                take.Text = "Tirar";
            }
            else
            {
                take.Text = "Save";
                Ini_tirar_foto();
            }
        }

        private void restricoesFuncionarios(string nome)
        {
            okFuncionario = true;
            //----------------------------- Vericar Nome ----------------------------//
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("ERRO - NOME\nCampo em Branco!");
                okFuncionario = false;
            }
            nome = nome.Trim();
            // Trocando dois ou mais espaços em branco consecutivos por apenas um
            nome = Regex.Replace(nome, "[ ]{2,}", " ", RegexOptions.Compiled);
            // Verificando a ocorrência de caracteres inválidos no alfabeto português (do Brasil)
            if (Regex.IsMatch(nome, "[^a-zA-ZáéíóúàâêôãõüçÁÉÍÓÚÀÂÊÔÃÕÜÇ ]", RegexOptions.Compiled))
            {
                MessageBox.Show("Nome inválido: \"" + nome + "\".");
                okFuncionario = false;
            }

            //------------------------------- RG -----------------------------------//
            int restrg;
            string cararg = Mtxt_rgFun.Text;

            if (cararg.Length != 12)
            {
                MessageBox.Show("Tente novamente - Não contém todos os digitos!");
                okFuncionario = false;
            }
            if (okFuncionario)
            {
                cararg = cararg.Trim();
                string trocarg = cararg.Replace("-", "").Replace(",", "").Replace(" ", "").Replace("X", "0").Replace("x", "0");
                int vezesrg = 0;
                trocarg = trocarg.Trim();
                for (int cont = 1; cont < trocarg.Length; cont++)
                {
                    if (trocarg[0] == trocarg[cont])
                        ++vezesrg;
                    else
                        break;
                }
                if (vezesrg == trocarg.Length - 1)
                {
                    MessageBox.Show("RG invalido, todos numeros iguais!");
                    okFuncionario = false;
                }
                if (okFuncionario && trocarg.Length > 7)
                {
                    string pstrg = trocarg.Substring(0, 8);
                    int somarg = 0;
                    int multirg = 9;

                    for (int cont = 0; cont < 8; cont++)
                    {
                        somarg += int.Parse(pstrg[cont].ToString()) * multirg;
                        multirg--;
                    }
                    restrg = (somarg % 11);
                    if (restrg == 10)
                        restrg = 0;

                    if (restrg.ToString() != trocarg[trocarg.Length - 1].ToString())
                    {
                        MessageBox.Show("RG - INVALIDO");
                        okFuncionario = false;
                    }
                }
            }

            //------------------------------- CPF -----------------------------------//

            int rest;
            string cara = Mtxt_cpfFun.Text;
            if (cara.Length != 14)
            {
                MessageBox.Show("Tente novamente - Não contém todos os digitos!");
                okFuncionario = false;
            }
            if (okFuncionario)
            {
                cara = cara.Trim();
                string troca = cara.Replace("-", "").Replace(",", "").Replace(" ", ""); // Removendo as virgulas da string
                troca = troca.Trim();
                int vezes = 0;
                for (int cont = 1; cont < troca.Length; cont++)
                {
                    if (troca[0] == troca[cont])
                    {
                        ++vezes;
                    }
                    else
                        break;
                }

                if (vezes == troca.Length - 1)
                {
                    MessageBox.Show("Cpf invalido, todos numeros iguais!");
                    okFuncionario = false;
                }

                if (okFuncionario && troca.Length > 8)
                {
                    string pst = troca.Substring(0, 9);
                    string pst2 = troca.Substring(0, 10);
                    int soma = 0;
                    int multi = 10;
                    for (int cont = 0; cont < 9; cont++)
                    {
                        soma += int.Parse(pst[cont].ToString()) * multi;
                        multi--;
                    }

                    rest = (soma % 11);
                    if (rest < 2)
                        rest = 0;
                    else
                        rest = 11 - rest;

                    char[] here = troca.ToCharArray();
                    int[] sure = Array.ConvertAll(here, c => (int)char.GetNumericValue(c));
                    soma = 0;
                    multi = 11;

                    if (rest != sure[sure.Length - 2])
                    {
                        MessageBox.Show("CPF - INVALIDO!");
                        okFuncionario = false;
                    }
                    else
                    {
                        for (int cont = 0; cont < sure.Length - 1; cont++)
                        {
                            soma += int.Parse(pst2[cont].ToString()) * multi;
                            multi--;
                        }

                        rest = (soma % 11);
                        if (rest < 2)
                            rest = 0;
                        else
                            rest = 11 - rest;

                        if (rest != sure[sure.Length - 1])
                        {
                            MessageBox.Show("CPF - INVÁLIDO!");
                            okFuncionario = false;
                        }
                    }
                }
            }

            //----------------------------- Verica Combobox ----------------------------//
            if (FuncaoFun_Combo.SelectedItem == null)
            {
                MessageBox.Show("ERRO - Verifique se todos os campos foram selecionados!");
                okFuncionario = false;
            }

            if (funcao == "Médico")
            {
                string horario = Mtxt_HorarioMedico.Text;
                horario = horario.Replace(":","").Trim();
                if (string.IsNullOrWhiteSpace(horario))
                {
                    MessageBox.Show("ERRO - Campo HORARIO em branco!");
                    okFuncionario = false;
                }
                if (EspeciaMedico_Combo.SelectedItem == null)
                {
                    MessageBox.Show("ERRO - Verifique se todos os campos foram selecionados!");
                    okFuncionario = false;
                }
            }

        }

        public static void EmptyTextBoxes(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)(c)).Text = string.Empty;
                }
                if(c.GetType() == typeof(MaskedTextBox))
                {
                    ((MaskedTextBox)(c)).Text = "";
                }
                    if (c.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)(c)).SelectedIndex = -1;
                }
            }
        }

        private void Cadastro_Funcionario_Load(object sender, EventArgs e)
        {
            if (which)
            {
                GB_busca.Visible = true;
                Gb_DadosFun.Enabled = false;
                Gb_Medico.Enabled = false;
                lbbuscaerro.Visible = false;
                lbdone.Visible = false;
                info1lb.Visible = false;
            }
        }

        private void Concluir(object sender, EventArgs e)
        {
            if (which == false)
            {
                restricoesFuncionarios(txt_nomeFun.Text);
                if (okFuncionario)
                {
                    string tipo = "funcionario";
                    Insere_Funcionarios();
                    this.Hide();
                    Sucess_Cad Sucess = new Sucess_Cad(tipo);
                    Sucess.ShowDialog();
                    this.Close();
                    File.Delete(caminho_img);
                }
            }
            else
            {
                restricoesFuncionarios(txt_nomeFun.Text);
                if (okFuncionario)
                {
                    Banco.Update_DadosFuncionario(Mtxtbusca.Text, txt_nomeFun.Text, Mtxt_rgFun.Text,
                                                  Mtxt_cpfFun.Text, txt_StatusFun.Text, FuncaoFun_Combo.SelectedItem.ToString(),
                                                  Mtxt_HorarioMedico.Text, EspeciaMedico_Combo.SelectedItem.ToString(), caminho_img, File.Exists(caminho_img));
                    Att_Cad Sucess_att = new Att_Cad(txt_nomeFun.Text);
                    this.Hide();
                    Sucess_att.Show();
                    this.Close();
                    File.Delete(caminho_img);
                }
            }
        }

        private void buscarFun(object sender, EventArgs e)
        {
            Buscar_Funcionarios();
        }

    }
}
