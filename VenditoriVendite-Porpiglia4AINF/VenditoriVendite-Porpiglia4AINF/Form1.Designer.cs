
namespace VenditoriVendite_Porpiglia4AINF
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
            this.label4 = new System.Windows.Forms.Label();
            this.NUDmese = new System.Windows.Forms.NumericUpDown();
            this.TXTnome = new System.Windows.Forms.TextBox();
            this.TXTvendite = new System.Windows.Forms.TextBox();
            this.BTaggingi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDmese)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendite annuali";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mese";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Venditore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vendite";
            // 
            // NUDmese
            // 
            this.NUDmese.Location = new System.Drawing.Point(56, 44);
            this.NUDmese.Name = "NUDmese";
            this.NUDmese.Size = new System.Drawing.Size(120, 20);
            this.NUDmese.TabIndex = 4;
            // 
            // TXTnome
            // 
            this.TXTnome.Location = new System.Drawing.Point(86, 75);
            this.TXTnome.Name = "TXTnome";
            this.TXTnome.Size = new System.Drawing.Size(100, 20);
            this.TXTnome.TabIndex = 5;
            // 
            // TXTvendite
            // 
            this.TXTvendite.Location = new System.Drawing.Point(88, 106);
            this.TXTvendite.Name = "TXTvendite";
            this.TXTvendite.Size = new System.Drawing.Size(100, 20);
            this.TXTvendite.TabIndex = 6;
            // 
            // BTaggingi
            // 
            this.BTaggingi.Location = new System.Drawing.Point(74, 145);
            this.BTaggingi.Name = "BTaggingi";
            this.BTaggingi.Size = new System.Drawing.Size(75, 23);
            this.BTaggingi.TabIndex = 7;
            this.BTaggingi.Text = "Aggiungi";
            this.BTaggingi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTaggingi);
            this.Controls.Add(this.TXTvendite);
            this.Controls.Add(this.TXTnome);
            this.Controls.Add(this.NUDmese);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUDmese)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUDmese;
        private System.Windows.Forms.TextBox TXTnome;
        private System.Windows.Forms.TextBox TXTvendite;
        private System.Windows.Forms.Button BTaggingi;
    }
}

