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
    public partial class Sucess_Cad : Form
    {
        public Sucess_Cad(string tipo)
        {
            InitializeComponent();
            Banco.Select_dadosCadSucess(lbNome,tipo);
        }

        public void main(object sender, EventArgs e)
        {
            this.Close();
        }

        public void again(object sender, EventArgs e)
        {
            this.Hide();
            bool which = false;
            CadastroPaciente again = new CadastroPaciente(which);
            again.ShowDialog();
            this.Close();
        }
    }
}
