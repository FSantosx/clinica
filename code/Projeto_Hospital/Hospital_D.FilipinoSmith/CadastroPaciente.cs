using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;//too
using System.IO;//''

namespace Hospital_D.FilipinoSmith
{
    public partial class CadastroPaciente : Form
    {
        int passo_passo = -1;
        bool okPaciente = false, okFichaPaciente = false, which = false, okbusca;
        AForge.Video.DirectShow.VideoCaptureDevice videoSource;
        string caminho_img = @"C:\Users\Guilherme Souza\Documents\Gsouza\Projeto H\Hospital_D.FilipinoSmith\Hospital_D.FilipinoSmith\bin\Debug\snapshot.png";

        public CadastroPaciente(bool which)
        {
            InitializeComponent();
            this.which = which;
        }

        public void Insere_Paciente()
        {
                Banco.Insert_Paciente(txt_nomePac.Text,
                                      NecessPac_Combo.SelectedItem.ToString(),
                                      ConvenioPac_Combo.SelectedItem.ToString(),
                                      SituPac_Combo.SelectedItem.ToString());
        }

        public void Insere_Ficha()
        {
                Banco.Insert_Ficha(Mtxt_telefonePac.Text,
                                   Mtxt_celularPac.Text,
                                   txt_emailPac.Text,
                                   SexoPac_Combo.SelectedItem.ToString(),
                                   Mtxt_rgPac.Text,
                                   Mtxt_cpfPac.Text.Replace("-", "").Replace(",", "").Replace(" ", ""),
                                   NatuPac_Combo.SelectedItem.ToString(),
                                   Mtxt_nascimentoPac.Text,
                                   txt_nomePaiPac.Text,
                                   txt_nomeMaePac.Text,
                                   EstaCivilPac_Combo.SelectedItem.ToString(),
                                   EstadoPac_Combo.SelectedItem.ToString(),
                                   txt_cidadePac.Text,
                                   txt_enderecoPac.Text,
                                   Mtxt_numeroPac.Text,
                                   txt_bairroPac.Text,
                                   txt_complementoPac.Text,
                                   txt_observacaoPac.Text,
                                   caminho_img
                                   );
        }

        public void Busca_Paciente()
        {
            okbusca = true;
            lbbuscaerro.Visible = false;
            LbNxt.Visible = false;
            Banco.Select_All_Dados_Paciente(Mtxtbusca.Text, txt_nomePac, NecessPac_Combo, ConvenioPac_Combo, SituPac_Combo, perfilPB,
                                            txt_emailPac, Mtxt_telefonePac, Mtxt_celularPac, SexoPac_Combo, NatuPac_Combo, EstaCivilPac_Combo,
                                            Mtxt_nascimentoPac, Mtxt_rgPac, Mtxt_cpfPac, txt_nomePaiPac, txt_nomeMaePac, EstadoPac_Combo,
                                            txt_cidadePac, txt_enderecoPac, Mtxt_numeroPac, txt_bairroPac, txt_complementoPac, txt_observacaoPac,
                                            ref okbusca);
            if (okbusca)
            {
                Gb_Paciente.Enabled = true;
                Gb_Contato.Enabled = true;
                Gb_Info.Enabled = true;
                Gb_Localizacao.Enabled = true;
                LbNxt.Visible = true;
            }
            else
            {
                Gb_Paciente.Enabled = false;
                Gb_Contato.Enabled = false;
                Gb_Info.Enabled = false;
                Gb_Localizacao.Enabled = false;
                lbbuscaerro.Visible = true;
            }
                
        }

        public void RestricoesPac(string nome)
        {
            okPaciente = true;
            //----------------------------- Vericar Nome ----------------------------//
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("ERRO - NOME\nCampo em Branco!");
                okPaciente = false;
            }
            nome = nome.Trim();
            // Trocando dois ou mais espaços em branco consecutivos por apenas um
            nome = Regex.Replace(nome, "[ ]{2,}", " ", RegexOptions.Compiled);
            // Verificando a ocorrência de caracteres inválidos no alfabeto português (do Brasil)
            if (Regex.IsMatch(nome, "[^a-zA-ZáéíóúàâêôãõüçÁÉÍÓÚÀÂÊÔÃÕÜÇ ]", RegexOptions.Compiled))
            {
                MessageBox.Show("Nome inválido: \"" + nome + "\".");
                okPaciente = false;
            }
            //----------------------------- Verica Combobox ----------------------------//
            if (NecessPac_Combo.SelectedItem == null || ConvenioPac_Combo.SelectedItem == null || SituPac_Combo.SelectedItem == null)
            {
                MessageBox.Show("ERRO - Verifique se todos os campos foram selecionados!");
                okPaciente = false;
            }
        }

        public void RestricoesFichaPac()
        {
            okFichaPaciente = true;
            //----------------------------- Validar E-Mail ----------------------------//
            Regex mail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (!mail.IsMatch(txt_emailPac.Text))
            {
                MessageBox.Show("ERRO - E-Mail Invalido!");
                okFichaPaciente = false;
            }
            //--------------------- Verica Campo Tell and Cell ------------------------//
            string tell = Mtxt_telefonePac.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            tell = tell.Trim();
            if (string.IsNullOrWhiteSpace(tell))
            {
                okFichaPaciente = false;
                MessageBox.Show("Telefone Invalido!");
            }
            tell = Mtxt_celularPac.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            tell.Trim();
            if(string.IsNullOrWhiteSpace(tell))
            {
                okFichaPaciente = false;
                MessageBox.Show("Celular Invalido!");
            }

            //----------------------------- Verica ComboBox ----------------------------//
            if (SexoPac_Combo.SelectedItem == null || NatuPac_Combo.SelectedItem == null ||
            EstaCivilPac_Combo.SelectedItem == null || EstadoPac_Combo.SelectedItem == null)
            {
                MessageBox.Show("ERRO - Verifique se todos os campos foram selecionados!");
                okFichaPaciente = false;
            }

            //----------------------------- Verifica Data ----------------------------//
            int dia, mes, ano;
            string nascimento = Mtxt_nascimentoPac.Text.Replace("-", "");
            nascimento = nascimento.Trim();
            if (nascimento == "")
                MessageBox.Show("ERRO - DATA DE NASCIMENTO\nCampo em Branco!");
            else
            {
                dia = int.Parse(Mtxt_nascimentoPac.Text.Substring(0, 2));
                mes = int.Parse(Mtxt_nascimentoPac.Text.Substring(3, 2));
                ano = int.Parse(Mtxt_nascimentoPac.Text.Substring(6, 4));
                if (dia > 31 || mes > 12 || ano < 1900 || ano > 2015)
                {
                    MessageBox.Show("ERRO - DATA DE NASCIMENTO\nInvalida, confira a data informada!");
                    okFichaPaciente = false;
                }
                if (dia > 29 && mes == 02)
                {
                    MessageBox.Show("ERRO - DATA DE NASCIMENTO\nInvalida, confira a data informada!");
                    okFichaPaciente = false;
                }
            }
            //------------------------------- RG -----------------------------------//
            
            int restrg;
            string cararg = Mtxt_rgPac.Text;
                
            if (cararg.Length != 12)
            {
                MessageBox.Show("Tente novamente - Não contém todos os digitos!");
                okFichaPaciente = false;
            }
            if (okFichaPaciente)
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
                if (vezesrg == trocarg.Length-1)
                {
                    MessageBox.Show("RG invalido, todos numeros iguais!");
                    okFichaPaciente = false;
                }
                if (okFichaPaciente && trocarg.Length > 7)
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
                        okFichaPaciente = false;
                    }
                }
            }

            //------------------------------- CPF -----------------------------------//

            int rest;
            string cara = Mtxt_cpfPac.Text;
            if (cara.Length != 14)
            {
                MessageBox.Show("Tente novamente - Não contém todos os digitos!");
                okFichaPaciente = false;
            }
            if (okFichaPaciente)
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

                if (vezes == troca.Length-1)
                {
                    MessageBox.Show("Cpf invalido, todos numeros iguais!");
                    okFichaPaciente = false;
                }

                if (okFichaPaciente && troca.Length > 8)
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
                        okFichaPaciente = false;
                    }
                    else
                    {
                        for (int cont = 0; cont < sure.Length-1; cont++)
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
                            okFichaPaciente = false;
                        }
                    }
                }
            }

            //-------------------------------  Verifica Nomes -----------------------------------//

            if (Restri_NomeFicha(txt_nomePaiPac.Text) == false)
                okFichaPaciente = false;
            if (Restri_NomeFicha(txt_nomeMaePac.Text) == false)
                okFichaPaciente = false;

            //-------------------------  Verifica Txts Localização ------------------------------//

            if (string.IsNullOrWhiteSpace(txt_cidadePac.Text))
            {
                MessageBox.Show("ERRO - Campo CIDADE em branco!");
                okFichaPaciente = false;
            }
            if (string.IsNullOrWhiteSpace(txt_enderecoPac.Text))
            {
                MessageBox.Show("ERRO - Campo ENDEREÇO em branco!");
                okFichaPaciente = false;
            }
            if (string.IsNullOrWhiteSpace(Mtxt_numeroPac.Text))
            {
                MessageBox.Show("ERRO - Campo NUMERO em branco!");
                okFichaPaciente = false;
            }
            if (string.IsNullOrWhiteSpace(txt_bairroPac.Text))
            {
                MessageBox.Show("ERRO - Campo BAIRRO em branco!");
                okFichaPaciente = false;
            }
        }

        private bool Restri_NomeFicha(string nome)
        {
            bool oknome = true;
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("ERRO - NOME\nCampo em Branco!");
                oknome = false;
            }
            nome = nome.Trim();
            // Trocando dois ou mais espaços em branco consecutivos por apenas um
            nome = Regex.Replace(nome, "[ ]{2,}", " ", RegexOptions.Compiled);
            // Verificando a ocorrência de caracteres inválidos no alfabeto português (do Brasil)
            if (Regex.IsMatch(nome, "[^a-zA-ZáéíóúàâêôãõüçÁÉÍÓÚÀÂÊÔÃÕÜÇ ]", RegexOptions.Compiled))
            {
                MessageBox.Show("Nome inválido: \"" + nome + "\".");
                return oknome = false;
            }
            return oknome;
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

        public void nomePacLeave(object sender, EventArgs e)
        {
            Restri_NomeFicha(txt_nomePac.Text);
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

        protected override void OnClosed(EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
            base.OnClosed(e);
        }

        private void CadastroPaciente_Load(object sender, EventArgs e)
        {
            if (which)
            {
                GB_busca.Visible = true;
                Gb_Paciente.Enabled = false;
                Gb_Contato.Enabled = false;
                Gb_Info.Enabled = false;
                Gb_Localizacao.Enabled = false;
                LbNxt.Visible = false;
                LbDescribAction.Text = "Editar cadastro de paciente";
                LbNxt.Text = "Concluir";
            }
        }

        private void Concluido (object sender, EventArgs e)
        {
            string tipo = "paciente";
            if (which == false)
            {
                passo_passo++;
                switch (passo_passo)
                {
                    case 0:
                        RestricoesPac(txt_nomePac.Text);
                        if (okPaciente)
                        {
                            Insere_Paciente();
                            Gb_Contato.Enabled = true;
                            Gb_Info.Enabled = true;
                            Gb_Localizacao.Enabled = true;
                            prox.Text = "Concluir";
                        }
                        else
                            passo_passo--;
                        break;

                    case 1:
                        RestricoesFichaPac();
                        if (okFichaPaciente)
                        {
                            Insere_Ficha();
                            this.Hide();
                            Sucess_Cad Sucess = new Sucess_Cad(tipo);
                            Sucess.ShowDialog();
                            this.Close();
                            File.Delete(caminho_img);
                        }
                        else
                            passo_passo--;
                        break;
                }
            }
            else
            {
                RestricoesPac(txt_nomePac.Text);
                RestricoesFichaPac();
                if (okPaciente && okFichaPaciente)
                {
                    Banco.Update_DadosPaciente(Mtxtbusca.Text, txt_nomePac.Text, NecessPac_Combo.SelectedItem.ToString(),
                                               ConvenioPac_Combo.SelectedItem.ToString(), SituPac_Combo.SelectedItem.ToString(),
                                               Mtxt_telefonePac.Text, Mtxt_celularPac.Text, txt_emailPac.Text, SexoPac_Combo.SelectedItem.ToString(),
                                               Mtxt_rgPac.Text, Mtxt_cpfPac.Text, NatuPac_Combo.Text, Mtxt_nascimentoPac.Text, txt_nomePaiPac.Text,
                                               txt_nomeMaePac.Text, EstaCivilPac_Combo.SelectedItem.ToString(), EstadoPac_Combo.SelectedItem.ToString(),
                                               txt_cidadePac.Text, txt_enderecoPac.Text, Mtxt_numeroPac.Text, txt_bairroPac.Text,txt_complementoPac.Text,
                                               txt_observacaoPac.Text, caminho_img, File.Exists(caminho_img));
                    this.Hide();
                    Att_Cad Sucess_att = new Att_Cad(txt_nomePac.Text);
                    Sucess_att.Show();
                    this.Close();
                   File.Delete(caminho_img);
                }
            }
        }

        private void buscar (object sender, EventArgs e)
        {
            Busca_Paciente();
        }

        private void Voltar (object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
            this.Close();
        }
    }
}
