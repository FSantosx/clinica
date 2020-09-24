using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_D.FilipinoSmith
{
    public partial class Cadastro_Usuario : Form
    {
        bool okuser;

        public Cadastro_Usuario()
        {
            InitializeComponent();
        }

        public void restriuser()
        {
            okuser = true;
            if (string.IsNullOrWhiteSpace(MtxtIdfun.Text))
            {
                MessageBox.Show("ERRO - ID\nCampo em Branco!");
                okuser = false;
            }
            else if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("ERRO - USUARIO\nCampo em Branco!");
                okuser = false;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("ERRO - SENHA\nCampo em Branco!");
                okuser = false;
            }
            else if (okuser)
            {
                Banco.Verifica_userId(ref okuser, MtxtIdfun.Text);
                if (okuser == false)
                    MessageBox.Show("Id Invalido");
                else
                {
                    Banco.Verifica_user(ref okuser, txtUser.Text);
                    if (okuser == false)
                        MessageBox.Show("Usuario Invalido");
                }
            }
        }

        public void salvar (object sender, EventArgs e)
        {
            restriuser();
            if (okuser)
            {
                Banco.Insert_Usuario(MtxtIdfun.Text, txtUser.Text, txtPassword.Text);
                Sucess_Cad sucess = new Sucess_Cad(txtUser.Text);
                this.Hide();
                sucess.Show();
                this.Close();
            }
        }

        public void voltar (object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
