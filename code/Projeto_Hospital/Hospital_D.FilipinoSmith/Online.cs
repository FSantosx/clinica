using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Hospital_D.FilipinoSmith
{
    public partial class Online : Form
    {
        // Para o relogio
        System.Windows.Forms.Timer tempo = new System.Windows.Forms.Timer();

        public Online()
        {
            InitializeComponent();
        }

        private void listar_All (object sender, EventArgs e)
        {
            //dataGridView1.DataSource = Banco.Select_AllPaciente();
        }

        private void Consulta_Estoque(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = Banco.Select_Estoque();
        }

        private void cadpac(object sender, EventArgs e)
        {
            bool which = false;
            CadastroPaciente cadpac = new CadastroPaciente(which);
            cadpac.Show();          
        }

        private void caduser(object sender, EventArgs e)
        {
            Cadastro_Usuario caduser = new Cadastro_Usuario();
            caduser.ShowDialog();
        }

        private void cadfun(object sender, EventArgs e)
        {
            bool which = false;
            Cadastro_Funcionario CadFun = new Cadastro_Funcionario(which);
            CadFun.Show();
        }

        private void buscarpac(object sender, EventArgs e)
        {
            BuscarPaciente buscar = new BuscarPaciente();
            buscar.ShowDialog();
        }

        private void editarpac(object sender, EventArgs e)
        {
            bool which = true;
            CadastroPaciente editpac = new CadastroPaciente(which);
            editpac.Show();
        }

        private void editarfun(object sender, EventArgs e)
        {
            bool which = true;
            Cadastro_Funcionario editfun = new Cadastro_Funcionario(which);
            editfun.Show();
        }

        private void editaruser(object sender, EventArgs e)
        {
            Editar_Usuario editaruser = new Editar_Usuario();
            editaruser.Show();            
        }

        private void tempo_Tick(object sender, EventArgs e)
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
                
        private void sair (object sender, EventArgs e)
        {
            this.Close();
        }

        private void Online_Load(object sender, EventArgs e)
        {
            tempo.Interval = 1000;
            tempo.Tick += new EventHandler(this.tempo_Tick);
            tempo.Start();
        }

        public void bemvindouser(string nomeuser)
        {
            lbBemvindo.Text = "Olá "+ UppercaseFirst(nomeuser) +", Seja Bem-Vindo!";
        }

        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
