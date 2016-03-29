using GDIDB;
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
    public partial class Corrida : Form
    {
        Decimal distancia1;
        Decimal velocidade1;
        Decimal distancia2;
        Decimal velocidade2;

        Rato rato_branco = new Rato(15, 430);
        Rato rato_preto = new Rato(15, 560);

        Image[] arcoiris = new Image[2];
        int spriteCounterArcoIris = 0;

        private DBGraphics memGraphics;

        String valorMsgAtual = "";

        String nome_rato_1 = null;
        String nome_rato_2 = null;

        int numeroCountDown = 9;

        int distanciaFinal = 500;

        //int tempoCorrida = 0;
        DateTime? inicioCorrida = null;

        Boolean janelaVencedorAberta = false;

        int? tempoRato1 = null;
        int? tempoRato2 = null;

        GanhadorForm ganhadorForm = null;

        public Corrida(String com, String rato_1, String rato_2)
        {
            InitializeComponent();
            serialPort.PortName = com;
            serialPort.BaudRate = 9600;
            serialPort.Open();

            memGraphics = new DBGraphics();

            arcoiris[0] = Properties.Resources.arcoiris_1;
            arcoiris[1] = Properties.Resources.arcoiris_2;

            this.nome_rato_1 = rato_1;
            this.nome_rato_2 = rato_2;

            lb_nome_rato_1_distancia.Text = rato_1;
            lb_nome_rato_1_velocidade.Text = rato_1;
            lb_nome_rato_2_distancia.Text = rato_2;
            lb_nome_rato_2_velocidade.Text = rato_2;

            iniciarContagem();
        }

        public void iniciarContagem()
        {
            timerCountDown.Enabled = true;
            lb_countDown.Visible = true;
            lb_countDown.Dock = DockStyle.Fill;
        }

        public void iniciarContagemTempoCompetidores()
        {
            inicioCorrida = DateTime.Now;
            timerTempoCorrida.Enabled = true;
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String msg = serialPort.ReadExisting();
            receberMensagem(msg);
        }

        public void receberMensagem(String msg)
        {
            try
            {
                String mensagem = msg;
                while (mensagem != "")
                {
                    if (mensagem[0] != 'w' && mensagem[0] != 'x' && mensagem[0] != 'y' && mensagem[0] != 'z')
                    {
                        valorMsgAtual = valorMsgAtual + mensagem[0];
                        mensagem = mensagem.Remove(0, 1);
                    }
                    else
                    {
                        switch (mensagem[0])
                        {
                            case 'w':
                                distancia1 = Convert.ToDecimal(valorMsgAtual.Replace('.', ','));
                                if (distancia1 < distanciaFinal)
                                {
                                    lb_distancia_rato_1.Invoke((MethodInvoker)(() => lb_distancia_rato_1.Text = Math.Round(distancia1, 0).ToString() + "m"));
                                }
                                else
                                {
                                    lb_distancia_rato_1.Invoke((MethodInvoker)(() => lb_distancia_rato_1.Text = (distanciaFinal).ToString() + "m"));
                                }
                                valorMsgAtual = "";
                                break;
                            case 'x':
                                velocidade1 = Convert.ToDecimal(valorMsgAtual.Replace('.', ','));
                                lb_velocidade_rato_1.Invoke((MethodInvoker)(() => lb_velocidade_rato_1.Text = velocidade1.ToString() + " Km/h"));
                                valorMsgAtual = "";
                                break;
                            case 'y':
                                distancia2 = Convert.ToDecimal(valorMsgAtual.Replace('.', ','));
                                if (distancia2 < distanciaFinal)
                                {
                                    lb_distancia_rato_2.Invoke((MethodInvoker)(() => lb_distancia_rato_2.Text = Math.Round(distancia2, 0).ToString() + "m"));
                                }
                                else
                                {
                                    lb_distancia_rato_2.Invoke((MethodInvoker)(() => lb_distancia_rato_2.Text = (500).ToString() + "m"));
                                }
                                valorMsgAtual = "";
                                break;
                            case 'z':
                                velocidade2 = Convert.ToDecimal(valorMsgAtual.Replace('.', ','));
                                lb_velocidade_rato_2.Invoke((MethodInvoker)(() => lb_velocidade_rato_2.Text = velocidade2.ToString() + " Km/h"));
                                valorMsgAtual = "";
                                break;
                        }
                        mensagem = mensagem.Remove(0, 1);
                        desenharRatos();
                    }
                }
            }
            catch
            {

            }
        }

        public void desenharRatos()
        {

            int posicao_rato_branco = Convert.ToInt32(Math.Round(distancia1 * 2.1M, 1));
            int posicao_rato_preto = Convert.ToInt32(Math.Round(distancia2 * 2.1M, 1));

            if (posicao_rato_branco < 1060)
            {
                rato_branco.X = posicao_rato_branco;
            }
            else
            {
                rato_branco.X = 1060;
            }

            if (posicao_rato_preto < 1060)
            {
                rato_preto.X = posicao_rato_preto;
            }
            else
            {
                rato_preto.X = 1060;
            }


            pb_graphics.Invalidate();
        }

        private void Corrida_Load(object sender, EventArgs e)
        {
            memGraphics.CreateDoubleBuffer(this.CreateGraphics(), this.ClientRectangle.Width, this.ClientRectangle.Height);
        }

        private void pb_graphics_Click(object sender, EventArgs e)
        {

        }

        private void pb_graphics_Paint(object sender, PaintEventArgs e)
        {

            memGraphics.g.Clear(Color.Transparent);
            if (velocidade1 > 50 && distancia1 <= distanciaFinal)
            {
                memGraphics.g.DrawImage(arcoiris[spriteCounterArcoIris], rato_branco.X - 10, rato_branco.Y + 20, 60, 30);
            }
            memGraphics.g.DrawImage(Properties.Resources.Rato_branco, rato_branco.X, rato_branco.Y, 120, 130);

            if (velocidade2 > 50 && distancia2 <= distanciaFinal)
            {
                memGraphics.g.DrawImage(arcoiris[spriteCounterArcoIris], rato_preto.X - 10, rato_preto.Y + 90, 60, 30);
            }
            memGraphics.g.DrawImage(Properties.Resources.Rato_preto, rato_preto.X, rato_preto.Y, 120, 130);

            incrementarSpriteArcoIris();


            memGraphics.Render(e.Graphics);
        }

        private void Corrida_Paint(object sender, PaintEventArgs e)
        {

        }

        public void incrementarSpriteArcoIris()
        {
            spriteCounterArcoIris = spriteCounterArcoIris + 1;
            if (spriteCounterArcoIris == 2)
            {
                spriteCounterArcoIris = 0;
            }
        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            if (numeroCountDown != 0)
            {
                lb_countDown.Text = numeroCountDown.ToString();
            }
            else
            {
                lb_countDown.Text = "GO!";
                lb_countDown.SendToBack();
                lb_countDown.Hide();
                iniciarContagemTempoCompetidores();
            }
            numeroCountDown = numeroCountDown - 1;
        }

        private void timerTempoCorrida_Tick(object sender, EventArgs e)
        {         
            if (distancia1 >= distanciaFinal && tempoRato1 == null)
            {
                tempoRato1 = Convert.ToInt32(DateTime.Now.Subtract((DateTime)inicioCorrida).TotalMilliseconds);
            }
            if (distancia2 >= distanciaFinal && tempoRato2 == null)
            {
                tempoRato2 = Convert.ToInt32(DateTime.Now.Subtract((DateTime)inicioCorrida).TotalMilliseconds);
            }

            if (distancia1 >= distanciaFinal && distancia2 >= distanciaFinal)
            {
                if (ganhadorForm == null)
                {
                    if (tempoRato1 < tempoRato2)
                    {
                        ganhadorForm = new GanhadorForm(EnumGanhador.Branco, nome_rato_1, tempoRato1.Value);
                        ganhadorForm.setSegundoLugar(EnumGanhador.Preto, nome_rato_2, tempoRato2.Value);
                    }
                    else if(tempoRato1 > tempoRato2)
                    {
                        ganhadorForm = new GanhadorForm(EnumGanhador.Preto, nome_rato_2, tempoRato2.Value);
                        ganhadorForm.setSegundoLugar(EnumGanhador.Branco, nome_rato_1, tempoRato1.Value);
                    }
                    else
                    {
                        ganhadorForm = new GanhadorForm(EnumGanhador.Empate, nome_rato_2, tempoRato2.Value);
                        ganhadorForm.setSegundoLugar(EnumGanhador.Branco, nome_rato_1, tempoRato1.Value);
                    }
                }

                if (janelaVencedorAberta == false && ganhadorForm != null)
                {
                    if (tempoRato1 != tempoRato2)
                    {
                        ganhadorForm.Show();
                    }
                    janelaVencedorAberta = true;
                }
            }
        }
    }
}