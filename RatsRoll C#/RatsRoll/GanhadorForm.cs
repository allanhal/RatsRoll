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
    public enum EnumGanhador
    {
        Branco = 1,
        Preto = 2,
        Empate = 3
    }

    public partial class GanhadorForm : Form
    {
        EnumGanhador ganhador;
        EnumGanhador segundo;

        String nomeGanhador = null;
        int? tempoGanhador = null;

        String nomeSegundo = null;
        int? tempoSegundo = null;

        public GanhadorForm(EnumGanhador ganhador, String nome, int tempo)
        {
            InitializeComponent();
            if (ganhador == EnumGanhador.Branco)
            {
                this.BackgroundImage = Properties.Resources.rato_branco_winer;
            }
            else if (ganhador == EnumGanhador.Preto)
            {
                this.BackgroundImage = Properties.Resources.rato_preto_winer;
            }
            else
            {
                this.timer_mostrar_tempos.Interval = 1;
            }
            this.ganhador = ganhador;
            this.nomeGanhador = nome;
            this.tempoGanhador = tempo;
            lb_ganhador.Text = nome;
        }

        public void setSegundoLugar(EnumGanhador segundo, String nome, int tempo)
        {
            if (this.nomeSegundo == null && this.tempoSegundo == null && segundo != ganhador)
            {
                this.timer_mostrar_tempos.Enabled = true;

                this.segundo = segundo;
                this.nomeSegundo = nome;
                this.tempoSegundo = tempo;
            }
        }

        private void GanhadorForm_Load(object sender, EventArgs e)
        {

        }

        private void timer_mostrar_tempos_Tick(object sender, EventArgs e)
        {
            if (tempoGanhador != null && tempoSegundo != null)
            {
                timer_mostrar_tempos.Enabled = false;
                TemposForm temposForm = new TemposForm(ganhador, nomeGanhador, tempoGanhador, segundo, nomeSegundo, tempoSegundo);
                temposForm.ShowDialog();
            }
        }
    }
}
