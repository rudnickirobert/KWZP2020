namespace Szwalnia
{
    partial class Produkcja
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
            this.btnProcesProdukcyjny = new System.Windows.Forms.Button();
            this.btnRaporty = new System.Windows.Forms.Button();
            this.btnInne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcesProdukcyjny
            // 
            this.btnProcesProdukcyjny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProcesProdukcyjny.Location = new System.Drawing.Point(99, 55);
            this.btnProcesProdukcyjny.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcesProdukcyjny.Name = "btnProcesProdukcyjny";
            this.btnProcesProdukcyjny.Size = new System.Drawing.Size(400, 148);
            this.btnProcesProdukcyjny.TabIndex = 3;
            this.btnProcesProdukcyjny.Text = "Proces produkcyjny";
            this.btnProcesProdukcyjny.UseVisualStyleBackColor = true;
            this.btnProcesProdukcyjny.Click += new System.EventHandler(this.btnProcesProdukcyjny_Click);
            // 
            // btnRaporty
            // 
            this.btnRaporty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRaporty.Location = new System.Drawing.Point(99, 210);
            this.btnRaporty.Margin = new System.Windows.Forms.Padding(4);
            this.btnRaporty.Name = "btnRaporty";
            this.btnRaporty.Size = new System.Drawing.Size(400, 148);
            this.btnRaporty.TabIndex = 4;
            this.btnRaporty.Text = "Raporty";
            this.btnRaporty.UseVisualStyleBackColor = true;
            this.btnRaporty.Click += new System.EventHandler(this.btnRaporty_Click);
            // 
            // btnInne
            // 
            this.btnInne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInne.Location = new System.Drawing.Point(99, 366);
            this.btnInne.Margin = new System.Windows.Forms.Padding(4);
            this.btnInne.Name = "btnInne";
            this.btnInne.Size = new System.Drawing.Size(400, 148);
            this.btnInne.TabIndex = 5;
            this.btnInne.Text = "Inne";
            this.btnInne.UseVisualStyleBackColor = true;
            this.btnInne.Click += new System.EventHandler(this.btnInne_Click);
            // 
            // Produkcja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(579, 567);
            this.Controls.Add(this.btnInne);
            this.Controls.Add(this.btnRaporty);
            this.Controls.Add(this.btnProcesProdukcyjny);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Produkcja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkcja";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnProcesProdukcyjny;
        private System.Windows.Forms.Button btnRaporty;
        private System.Windows.Forms.Button btnInne;
    }
}