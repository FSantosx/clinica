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
    public partial class Editar_Usuario : Form
    {
        bool okbusca, oksenha;

        public Editar_Usuario()
        {
            InitializeComponent();
        }

        private void BuscarUser (object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void check_pass1(object sender, EventArgs e)
        {
            oksenha = true;
            if(string.IsNullOrWhiteSpace(newpass1.Text))
            {
                pictureBox1.Visible = true;
                pbcheck.Visible = false;
                oksenha = false;
            }
            else
            {
                pbcheck.Visible = true;
                pictureBox1.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(newpass2.Text) || newpass2.Text != newpass1.Text)
            {
                pbwrong.Visible = true;
                pbcheck2.Visible = false;
                oksenha = false;
            }
            else
            {
                pbcheck2.Visible = true;
                pbwrong.Visible = false;
            }

        }

        private void confirmar(object sender, EventArgs e)
        {
            if (oksenha)
            {
                update_Password();
                this.Hide();
                Att_Cad sucess = new Att_Cad(lbuser.Text);
                sucess.Show();
                this.Close();
            }
            else
                MessageBox.Show("Confuira os campos de senha!");
        }

        private void update_Password()
        {
            Banco.Update_Password(Mtxtbusca.Text,newpass2.Text);
        }

        private void BuscarUsuario()
        {
            okbusca = true;
            Banco.Select_User(Mtxtbusca.Text, lbuser, ref okbusca);
            if(okbusca == false)
            {
                lbbuscaerro.Visible = true;
                Gb_usuario.Enabled = false;
            }
            else
            {
                lbbuscaerro.Visible = false;
                Gb_usuario.Enabled = true;
            }
        }
    }
}
