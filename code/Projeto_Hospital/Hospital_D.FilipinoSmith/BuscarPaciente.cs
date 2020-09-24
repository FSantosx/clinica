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
    public partial class BuscarPaciente : Form
    {
        bool okbusca;
        public BuscarPaciente()
        {
            InitializeComponent();
        }

        private void voltar (object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscar (object sender, EventArgs e)
        {
            pesquisa();
        }

        private void pesquisa()
        {
            okbusca = true;
            lbbuscaerro.Visible = false;
            if (okbusca)
            {
                Banco.Pesquisa_Paciente(Mtxtbusca.Text.Trim(), txtnomepac, txtsitupac, txtleitopac,
                                        txttellpac, txtcellpac, pbperfil, ref okbusca);
                if (okbusca)
                    GB_dados.Visible = true;
                else
                {
                    GB_dados.Visible = false;
                    lbbuscaerro.Visible = true;
                }
            }                
        }

    }
}
