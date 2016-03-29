using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatsRoll
{
    public partial class TemposForm : Form
    {
        EnumGanhador ganhador;
        EnumGanhador segundo;

        String nomeGanhador = null;
        int? tempoGanhador = null;

        String nomeSegundo = null;
        int? tempoSegundo = null;

        public TemposForm(EnumGanhador ganhador, String nomeGanhador, int? tempoGanhador, EnumGanhador segundo, String nomeSegundo, int? tempoSegundo)
        {
            InitializeComponent();
            this.ganhador = ganhador;
            this.nomeGanhador = nomeGanhador;
            this.tempoGanhador = tempoGanhador;

            this.segundo = segundo;
            this.nomeSegundo = nomeSegundo;
            this.tempoSegundo = tempoSegundo;

            if (tempoGanhador != null)
            {
                Decimal tempoGanhadorDecimal = Decimal.Divide((int)tempoGanhador, 1000);
                lb_ganhador.Text = nomeGanhador + ": " + tempoGanhadorDecimal.ToString() + "s";
            }
            else
            {
                lb_ganhador.Text = nomeGanhador + ": " + 0 + "s";
            }

            if (tempoSegundo != null)
            {
                Decimal tempoSegundoDecimal = Decimal.Divide((int)tempoSegundo, 1000);
                lb_segundo.Text = nomeSegundo + ": " + tempoSegundoDecimal.ToString() + "s";
            }
            else
            {
                lb_segundo.Text = nomeSegundo + ": " + 0 + "s";
            }
        }


        private void GanhadorForm_Load(object sender, EventArgs e)
        {

        }

        private void lb_ganhador_Click(object sender, EventArgs e)
        {

        }
    }
}
