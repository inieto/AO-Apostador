namespace Apostador
{
    partial class Apostador
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moneyCBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblGanadas = new System.Windows.Forms.Label();
            this.lblPerdidas = new System.Windows.Forms.Label();
            this.lblMaxBet = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apostador de monedas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Argentum Online";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto inicial:";
            // 
            // moneyCBox
            // 
            this.moneyCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moneyCBox.FormattingEnabled = true;
            this.moneyCBox.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192",
            "16384"});
            this.moneyCBox.Location = new System.Drawing.Point(85, 91);
            this.moneyCBox.Name = "moneyCBox";
            this.moneyCBox.Size = new System.Drawing.Size(47, 21);
            this.moneyCBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Intervalo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "125";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ms";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(49, 167);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(92, 27);
            this.btnAction.TabIndex = 7;
            this.btnAction.Text = "Comenzar";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Resultados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ganadas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Reintentos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Máx. apuesta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ganadas%:";
            // 
            // lblGanadas
            // 
            this.lblGanadas.AutoSize = true;
            this.lblGanadas.Location = new System.Drawing.Point(128, 227);
            this.lblGanadas.Name = "lblGanadas";
            this.lblGanadas.Size = new System.Drawing.Size(13, 13);
            this.lblGanadas.TabIndex = 13;
            this.lblGanadas.Text = "0";
            // 
            // lblPerdidas
            // 
            this.lblPerdidas.AutoSize = true;
            this.lblPerdidas.Location = new System.Drawing.Point(128, 240);
            this.lblPerdidas.Name = "lblPerdidas";
            this.lblPerdidas.Size = new System.Drawing.Size(13, 13);
            this.lblPerdidas.TabIndex = 14;
            this.lblPerdidas.Text = "0";
            // 
            // lblMaxBet
            // 
            this.lblMaxBet.AutoSize = true;
            this.lblMaxBet.Location = new System.Drawing.Point(128, 253);
            this.lblMaxBet.Name = "lblMaxBet";
            this.lblMaxBet.Size = new System.Drawing.Size(13, 13);
            this.lblMaxBet.TabIndex = 15;
            this.lblMaxBet.Text = "0";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(122, 266);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(19, 13);
            this.lblBalance.TabIndex = 16;
            this.lblBalance.Text = "50";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "%";
            // 
            // Apostador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 298);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblMaxBet);
            this.Controls.Add(this.lblPerdidas);
            this.Controls.Add(this.lblGanadas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.moneyCBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Apostador";
            this.Text = "Apostador - Argentum Online";
            this.Load += new System.EventHandler(this.Apostador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox moneyCBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGanadas;
        private System.Windows.Forms.Label lblPerdidas;
        private System.Windows.Forms.Label lblMaxBet;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label11;

    }
}

