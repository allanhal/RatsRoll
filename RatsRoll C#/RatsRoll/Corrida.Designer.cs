namespace RatsRoll
{
    partial class Corrida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_nome_rato_1_distancia = new System.Windows.Forms.Label();
            this.lb_nome_rato_2_distancia = new System.Windows.Forms.Label();
            this.lb_nome_rato_2_velocidade = new System.Windows.Forms.Label();
            this.lb_nome_rato_1_velocidade = new System.Windows.Forms.Label();
            this.lb_distancia_rato_2 = new System.Windows.Forms.Label();
            this.lb_distancia_rato_1 = new System.Windows.Forms.Label();
            this.lb_velocidade_rato_2 = new System.Windows.Forms.Label();
            this.lb_velocidade_rato_1 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.pb_graphics = new System.Windows.Forms.PictureBox();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.lb_countDown = new System.Windows.Forms.Label();
            this.timerTempoCorrida = new System.Windows.Forms.Timer(this.components);
            this.timerCronometro = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_graphics)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nome_rato_1_distancia
            // 
            this.lb_nome_rato_1_distancia.BackColor = System.Drawing.Color.Transparent;
            this.lb_nome_rato_1_distancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_rato_1_distancia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_nome_rato_1_distancia.Location = new System.Drawing.Point(941, 65);
            this.lb_nome_rato_1_distancia.Name = "lb_nome_rato_1_distancia";
            this.lb_nome_rato_1_distancia.Size = new System.Drawing.Size(152, 55);
            this.lb_nome_rato_1_distancia.TabIndex = 0;
            this.lb_nome_rato_1_distancia.Text = "VLADIMIR";
            this.lb_nome_rato_1_distancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_nome_rato_2_distancia
            // 
            this.lb_nome_rato_2_distancia.BackColor = System.Drawing.Color.Transparent;
            this.lb_nome_rato_2_distancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_rato_2_distancia.Location = new System.Drawing.Point(941, 132);
            this.lb_nome_rato_2_distancia.Name = "lb_nome_rato_2_distancia";
            this.lb_nome_rato_2_distancia.Size = new System.Drawing.Size(152, 55);
            this.lb_nome_rato_2_distancia.TabIndex = 1;
            this.lb_nome_rato_2_distancia.Text = "RATO 2";
            this.lb_nome_rato_2_distancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_nome_rato_2_velocidade
            // 
            this.lb_nome_rato_2_velocidade.BackColor = System.Drawing.Color.Transparent;
            this.lb_nome_rato_2_velocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_rato_2_velocidade.Location = new System.Drawing.Point(29, 131);
            this.lb_nome_rato_2_velocidade.Name = "lb_nome_rato_2_velocidade";
            this.lb_nome_rato_2_velocidade.Size = new System.Drawing.Size(152, 55);
            this.lb_nome_rato_2_velocidade.TabIndex = 3;
            this.lb_nome_rato_2_velocidade.Text = "RATO 2";
            this.lb_nome_rato_2_velocidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_nome_rato_1_velocidade
            // 
            this.lb_nome_rato_1_velocidade.BackColor = System.Drawing.Color.Transparent;
            this.lb_nome_rato_1_velocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_rato_1_velocidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_nome_rato_1_velocidade.Location = new System.Drawing.Point(29, 65);
            this.lb_nome_rato_1_velocidade.Name = "lb_nome_rato_1_velocidade";
            this.lb_nome_rato_1_velocidade.Size = new System.Drawing.Size(152, 55);
            this.lb_nome_rato_1_velocidade.TabIndex = 2;
            this.lb_nome_rato_1_velocidade.Text = "RATO 1";
            this.lb_nome_rato_1_velocidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_distancia_rato_2
            // 
            this.lb_distancia_rato_2.BackColor = System.Drawing.Color.Transparent;
            this.lb_distancia_rato_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_distancia_rato_2.Location = new System.Drawing.Point(1102, 131);
            this.lb_distancia_rato_2.Name = "lb_distancia_rato_2";
            this.lb_distancia_rato_2.Size = new System.Drawing.Size(152, 55);
            this.lb_distancia_rato_2.TabIndex = 5;
            this.lb_distancia_rato_2.Text = "00";
            this.lb_distancia_rato_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_distancia_rato_1
            // 
            this.lb_distancia_rato_1.BackColor = System.Drawing.Color.Transparent;
            this.lb_distancia_rato_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_distancia_rato_1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_distancia_rato_1.Location = new System.Drawing.Point(1103, 66);
            this.lb_distancia_rato_1.Name = "lb_distancia_rato_1";
            this.lb_distancia_rato_1.Size = new System.Drawing.Size(152, 55);
            this.lb_distancia_rato_1.TabIndex = 4;
            this.lb_distancia_rato_1.Text = "00";
            this.lb_distancia_rato_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_velocidade_rato_2
            // 
            this.lb_velocidade_rato_2.BackColor = System.Drawing.Color.Transparent;
            this.lb_velocidade_rato_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_velocidade_rato_2.Location = new System.Drawing.Point(191, 131);
            this.lb_velocidade_rato_2.Name = "lb_velocidade_rato_2";
            this.lb_velocidade_rato_2.Size = new System.Drawing.Size(152, 55);
            this.lb_velocidade_rato_2.TabIndex = 7;
            this.lb_velocidade_rato_2.Text = "00";
            this.lb_velocidade_rato_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_velocidade_rato_1
            // 
            this.lb_velocidade_rato_1.BackColor = System.Drawing.Color.Transparent;
            this.lb_velocidade_rato_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_velocidade_rato_1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_velocidade_rato_1.Location = new System.Drawing.Point(191, 65);
            this.lb_velocidade_rato_1.Name = "lb_velocidade_rato_1";
            this.lb_velocidade_rato_1.Size = new System.Drawing.Size(152, 55);
            this.lb_velocidade_rato_1.TabIndex = 6;
            this.lb_velocidade_rato_1.Text = "00";
            this.lb_velocidade_rato_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // pb_graphics
            // 
            this.pb_graphics.BackColor = System.Drawing.Color.Transparent;
            this.pb_graphics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_graphics.Location = new System.Drawing.Point(0, 0);
            this.pb_graphics.Name = "pb_graphics";
            this.pb_graphics.Size = new System.Drawing.Size(1280, 720);
            this.pb_graphics.TabIndex = 11;
            this.pb_graphics.TabStop = false;
            this.pb_graphics.Click += new System.EventHandler(this.pb_graphics_Click);
            this.pb_graphics.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_graphics_Paint);
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1000;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // lb_countDown
            // 
            this.lb_countDown.Font = new System.Drawing.Font("Arial", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_countDown.Location = new System.Drawing.Point(559, 131);
            this.lb_countDown.Name = "lb_countDown";
            this.lb_countDown.Size = new System.Drawing.Size(251, 206);
            this.lb_countDown.TabIndex = 12;
            this.lb_countDown.Text = "10";
            this.lb_countDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_countDown.Visible = false;
            // 
            // timerTempoCorrida
            // 
            this.timerTempoCorrida.Tick += new System.EventHandler(this.timerTempoCorrida_Tick);
            // 
            // timerCronometro
            // 
            this.timerCronometro.Interval = 10;
            // 
            // Corrida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RatsRoll.Properties.Resources.background_corrida_full_hd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lb_countDown);
            this.Controls.Add(this.lb_velocidade_rato_2);
            this.Controls.Add(this.lb_velocidade_rato_1);
            this.Controls.Add(this.lb_distancia_rato_2);
            this.Controls.Add(this.lb_distancia_rato_1);
            this.Controls.Add(this.lb_nome_rato_2_velocidade);
            this.Controls.Add(this.lb_nome_rato_1_velocidade);
            this.Controls.Add(this.lb_nome_rato_2_distancia);
            this.Controls.Add(this.lb_nome_rato_1_distancia);
            this.Controls.Add(this.pb_graphics);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Corrida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corrida";
            this.Load += new System.EventHandler(this.Corrida_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Corrida_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb_graphics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_nome_rato_1_distancia;
        private System.Windows.Forms.Label lb_nome_rato_2_distancia;
        private System.Windows.Forms.Label lb_nome_rato_2_velocidade;
        private System.Windows.Forms.Label lb_nome_rato_1_velocidade;
        private System.Windows.Forms.Label lb_distancia_rato_2;
        private System.Windows.Forms.Label lb_distancia_rato_1;
        private System.Windows.Forms.Label lb_velocidade_rato_2;
        private System.Windows.Forms.Label lb_velocidade_rato_1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.PictureBox pb_graphics;
        private System.Windows.Forms.Timer timerCountDown;
        private System.Windows.Forms.Label lb_countDown;
        private System.Windows.Forms.Timer timerTempoCorrida;
        private System.Windows.Forms.Timer timerCronometro;
    }
}