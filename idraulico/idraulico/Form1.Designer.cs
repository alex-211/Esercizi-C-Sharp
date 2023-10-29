
namespace idraulico
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDday = new System.Windows.Forms.NumericUpDown();
            this.TXTservice = new System.Windows.Forms.TextBox();
            this.TXTrevenue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTsrch = new System.Windows.Forms.TextBox();
            this.BTadd = new System.Windows.Forms.Button();
            this.LST1 = new System.Windows.Forms.ListBox();
            this.TXTavgIncome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTmaxIcome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUDday)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giorno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Intervento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Incasso ";
            // 
            // NUDday
            // 
            this.NUDday.Location = new System.Drawing.Point(15, 25);
            this.NUDday.Name = "NUDday";
            this.NUDday.Size = new System.Drawing.Size(120, 20);
            this.NUDday.TabIndex = 3;
            // 
            // TXTservice
            // 
            this.TXTservice.Location = new System.Drawing.Point(151, 25);
            this.TXTservice.Name = "TXTservice";
            this.TXTservice.Size = new System.Drawing.Size(101, 20);
            this.TXTservice.TabIndex = 4;
            // 
            // TXTrevenue
            // 
            this.TXTrevenue.Location = new System.Drawing.Point(263, 25);
            this.TXTrevenue.Name = "TXTrevenue";
            this.TXTrevenue.Size = new System.Drawing.Size(100, 20);
            this.TXTrevenue.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cerca intervento per tipo:";
            // 
            // TXTsrch
            // 
            this.TXTsrch.Location = new System.Drawing.Point(144, 74);
            this.TXTsrch.Name = "TXTsrch";
            this.TXTsrch.Size = new System.Drawing.Size(346, 20);
            this.TXTsrch.TabIndex = 7;
            this.TXTsrch.TextChanged += new System.EventHandler(this.TXTsrch_TextChanged);
            // 
            // BTadd
            // 
            this.BTadd.Location = new System.Drawing.Point(369, 17);
            this.BTadd.Name = "BTadd";
            this.BTadd.Size = new System.Drawing.Size(75, 33);
            this.BTadd.TabIndex = 8;
            this.BTadd.Text = "Aggiungi";
            this.BTadd.UseVisualStyleBackColor = true;
            this.BTadd.Click += new System.EventHandler(this.BTadd_Click);
            // 
            // LST1
            // 
            this.LST1.FormattingEnabled = true;
            this.LST1.Items.AddRange(new object[] {
            "Lascia la casella di ricerca vuota per vedere tutti gli interventi oppure inizia " +
                "a digitare..."});
            this.LST1.Location = new System.Drawing.Point(13, 104);
            this.LST1.Name = "LST1";
            this.LST1.Size = new System.Drawing.Size(477, 134);
            this.LST1.TabIndex = 9;
            // 
            // TXTavgIncome
            // 
            this.TXTavgIncome.Location = new System.Drawing.Point(191, 247);
            this.TXTavgIncome.Name = "TXTavgIncome";
            this.TXTavgIncome.Size = new System.Drawing.Size(100, 20);
            this.TXTavgIncome.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Media di incassi per tipo intervento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Incasso massimo";
            // 
            // TXTmaxIcome
            // 
            this.TXTmaxIcome.Location = new System.Drawing.Point(390, 247);
            this.TXTmaxIcome.Name = "TXTmaxIcome";
            this.TXTmaxIcome.Size = new System.Drawing.Size(100, 20);
            this.TXTmaxIcome.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 378);
            this.Controls.Add(this.TXTmaxIcome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTavgIncome);
            this.Controls.Add(this.LST1);
            this.Controls.Add(this.BTadd);
            this.Controls.Add(this.TXTsrch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTrevenue);
            this.Controls.Add(this.TXTservice);
            this.Controls.Add(this.NUDday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUDday;
        private System.Windows.Forms.TextBox TXTservice;
        private System.Windows.Forms.TextBox TXTrevenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTsrch;
        private System.Windows.Forms.Button BTadd;
        private System.Windows.Forms.ListBox LST1;
        private System.Windows.Forms.TextBox TXTavgIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTmaxIcome;
    }
}

