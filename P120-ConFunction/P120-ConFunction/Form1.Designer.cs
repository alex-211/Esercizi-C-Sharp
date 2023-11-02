
namespace P120_ConFunction
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
            this.CBmateria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBsistema = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBvoto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LST1 = new System.Windows.Forms.ListBox();
            this.BTadd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia";
            // 
            // CBmateria
            // 
            this.CBmateria.FormattingEnabled = true;
            this.CBmateria.Items.AddRange(new object[] {
            "Italiano",
            "Storia",
            "Inglese",
            "Matematica",
            "Informatica",
            "Sistemi & Reti",
            "TPSIT",
            "Telecomunicazioni"});
            this.CBmateria.Location = new System.Drawing.Point(137, 43);
            this.CBmateria.Name = "CBmateria";
            this.CBmateria.Size = new System.Drawing.Size(121, 21);
            this.CBmateria.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sistema di valutazione";
            // 
            // CBsistema
            // 
            this.CBsistema.FormattingEnabled = true;
            this.CBsistema.Items.AddRange(new object[] {
            "Lettere",
            "Numeri 0-100",
            "Numeri 0-10"});
            this.CBsistema.Location = new System.Drawing.Point(137, 6);
            this.CBsistema.Name = "CBsistema";
            this.CBsistema.Size = new System.Drawing.Size(121, 21);
            this.CBsistema.TabIndex = 3;
            this.CBsistema.SelectedIndexChanged += new System.EventHandler(this.CBsistema_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Voto";
            // 
            // CBvoto
            // 
            this.CBvoto.FormattingEnabled = true;
            this.CBvoto.Items.AddRange(new object[] {
            "Seleziona un sistema di valutazione!"});
            this.CBvoto.Location = new System.Drawing.Point(137, 85);
            this.CBvoto.Name = "CBvoto";
            this.CBvoto.Size = new System.Drawing.Size(121, 21);
            this.CBvoto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pagella";
            // 
            // LST1
            // 
            this.LST1.FormattingEnabled = true;
            this.LST1.Items.AddRange(new object[] {
            "I tuoi voti appariranno quà..."});
            this.LST1.Location = new System.Drawing.Point(22, 184);
            this.LST1.Name = "LST1";
            this.LST1.Size = new System.Drawing.Size(236, 121);
            this.LST1.TabIndex = 7;
            // 
            // BTadd
            // 
            this.BTadd.Location = new System.Drawing.Point(22, 122);
            this.BTadd.Name = "BTadd";
            this.BTadd.Size = new System.Drawing.Size(236, 23);
            this.BTadd.TabIndex = 8;
            this.BTadd.Text = "Aggiungi voto";
            this.BTadd.UseVisualStyleBackColor = true;
            this.BTadd.Click += new System.EventHandler(this.BTadd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Il sistema di voti è stato selezionato";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 322);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTadd);
            this.Controls.Add(this.LST1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBvoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBsistema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBmateria);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBmateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBsistema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBvoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LST1;
        private System.Windows.Forms.Button BTadd;
        private System.Windows.Forms.Label label5;
    }
}

