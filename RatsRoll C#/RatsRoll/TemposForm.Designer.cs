namespace RatsRoll
{
    partial class TemposForm
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
            this.lb_ganhador = new System.Windows.Forms.Label();
            this.lb_segundo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_ganhador
            // 
            this.lb_ganhador.Font = new System.Drawing.Font("Arial", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ganhador.Location = new System.Drawing.Point(12, 220);
            this.lb_ganhador.Name = "lb_ganhador";
            this.lb_ganhador.Size = new System.Drawing.Size(1256, 97);
            this.lb_ganhador.TabIndex = 1;
            this.lb_ganhador.Text = "GANHADOR";
            this.lb_ganhador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_ganhador.Click += new System.EventHandler(this.lb_ganhador_Click);
            // 
            // lb_segundo
            // 
            this.lb_segundo.Font = new System.Drawing.Font("Arial", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_segundo.Location = new System.Drawing.Point(12, 415);
            this.lb_segundo.Name = "lb_segundo";
            this.lb_segundo.Size = new System.Drawing.Size(1256, 97);
            this.lb_segundo.TabIndex = 2;
            this.lb_segundo.Text = "SEGUNDO";
            this.lb_segundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TemposForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lb_segundo);
            this.Controls.Add(this.lb_ganhador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TemposForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GanhadorForm";
            this.Load += new System.EventHandler(this.GanhadorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_ganhador;
        private System.Windows.Forms.Label lb_segundo;
    }
}