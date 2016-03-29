namespace RatsRoll
{
    partial class Menu
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_com = new System.Windows.Forms.ComboBox();
            this.txt_rato_1 = new System.Windows.Forms.TextBox();
            this.txt_rato_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Iniciar Corrida";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Porta COM:";
            // 
            // cb_com
            // 
            this.cb_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_com.FormattingEnabled = true;
            this.cb_com.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20"});
            this.cb_com.Location = new System.Drawing.Point(72, 65);
            this.cb_com.Name = "cb_com";
            this.cb_com.Size = new System.Drawing.Size(142, 21);
            this.cb_com.TabIndex = 6;
            // 
            // txt_rato_1
            // 
            this.txt_rato_1.Location = new System.Drawing.Point(72, 13);
            this.txt_rato_1.Name = "txt_rato_1";
            this.txt_rato_1.Size = new System.Drawing.Size(142, 20);
            this.txt_rato_1.TabIndex = 4;
            // 
            // txt_rato_2
            // 
            this.txt_rato_2.Location = new System.Drawing.Point(72, 39);
            this.txt_rato_2.Name = "txt_rato_2";
            this.txt_rato_2.Size = new System.Drawing.Size(142, 20);
            this.txt_rato_2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rato Branco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rato Preto:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(240, 123);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_rato_2);
            this.Controls.Add(this.txt_rato_1);
            this.Controls.Add(this.cb_com);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rat\'s Roll";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_com;
        private System.Windows.Forms.TextBox txt_rato_1;
        private System.Windows.Forms.TextBox txt_rato_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

