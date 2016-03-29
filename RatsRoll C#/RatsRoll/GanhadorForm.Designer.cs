namespace RatsRoll
{
    partial class GanhadorForm
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
            this.lb_ganhador = new System.Windows.Forms.Label();
            this.timer_mostrar_tempos = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb_ganhador
            // 
            this.lb_ganhador.BackColor = System.Drawing.Color.Transparent;
            this.lb_ganhador.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ganhador.ForeColor = System.Drawing.Color.White;
            this.lb_ganhador.Location = new System.Drawing.Point(264, 550);
            this.lb_ganhador.Name = "lb_ganhador";
            this.lb_ganhador.Size = new System.Drawing.Size(449, 80);
            this.lb_ganhador.TabIndex = 0;
            this.lb_ganhador.Text = "ganhador";
            // 
            // timer_mostrar_tempos
            // 

            this.timer_mostrar_tempos.Interval = 5000;
            this.timer_mostrar_tempos.Tick += new System.EventHandler(this.timer_mostrar_tempos_Tick);
            // 
            // GanhadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::RatsRoll.Properties.Resources.rato_branco_winer;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lb_ganhador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GanhadorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GanhadorForm";
            this.Load += new System.EventHandler(this.GanhadorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_ganhador;
        private System.Windows.Forms.Timer timer_mostrar_tempos;
    }
}