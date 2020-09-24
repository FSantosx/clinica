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
    public partial class Main : Form
    {
        System.Windows.Forms.Timer tempo = new System.Windows.Forms.Timer();

        public Main()
        {
            InitializeComponent();
            tempo.Interval = 1000;
            tempo.Tick += new EventHandler(this.Tempo_Tick);
            tempo.Start();
        }

        private void Login ()
        {
            bool verific = true;
            Banco.Verificar_Login_Senha(ref verific, txtUser.Text, txtPassword.Text); 
            if (verific)
            {
                this.Hide();
                Online On = new Online();
                On.bemvindouser(txtUser.Text);
                On.ShowDialog();
                this.Visible = true;
                txtUser.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Usuario ou Senha invalidos!");
            }
        }

        public void LoginClick(object sender, EventArgs e)
        {
            Login();
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            string hora = "";

            if (hh < 10)
                hora += "0" + hh;
            else
                hora += hh;
            hora += ":";
            if (mm < 10)
                hora += "0" + mm;
            else
                hora += mm;
            if (hh >= 12)
                clock.Text = hora + " PM";
            else
                clock.Text = hora + " AM";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
