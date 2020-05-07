namespace Szwalnia
{
    partial class ProcesyProdukcyjneDlaZamowienieElement
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
            this.btnPokaz = new System.Windows.Forms.Button();
            this.dgvProcesProdukcyjny = new System.Windows.Forms.DataGridView();
            this.nudIdProcesu = new System.Windows.Forms.NumericUpDown();
            this.lblOpis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesProdukcyjny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdProcesu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPokaz
            // 
            this.btnPokaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPokaz.Location = new System.Drawing.Point(581, 67);
            this.btnPokaz.Name = "btnPokaz";
            this.btnPokaz.Size = new System.Drawing.Size(75, 30);
            this.btnPokaz.TabIndex = 7;
            this.btnPokaz.Text = "Pokaż";
            this.btnPokaz.UseVisualStyleBackColor = true;
            this.btnPokaz.Click += new System.EventHandler(this.btnPokaz_Click);
            // 
            // dgvProcesProdukcyjny
            // 
            this.dgvProcesProdukcyjny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesProdukcyjny.Location = new System.Drawing.Point(51, 109);
            this.dgvProcesProdukcyjny.Name = "dgvProcesProdukcyjny";
            this.dgvProcesProdukcyjny.Size = new System.Drawing.Size(697, 88);
            this.dgvProcesProdukcyjny.TabIndex = 6;
            // 
            // nudIdProcesu
            // 
            this.nudIdProcesu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudIdProcesu.Location = new System.Drawing.Point(387, 73);
            this.nudIdProcesu.Name = "nudIdProcesu";
            this.nudIdProcesu.Size = new System.Drawing.Size(120, 24);
            this.nudIdProcesu.TabIndex = 5;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(125, 73);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(237, 18);
            this.lblOpis.TabIndex = 4;
            this.lblOpis.Text = "Wprowadź ID zamowienia element";
            // 
            // ProcesyProdukcyjneDlaZamowienieElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.btnPokaz);
            this.Controls.Add(this.dgvProcesProdukcyjny);
            this.Controls.Add(this.nudIdProcesu);
            this.Controls.Add(this.lblOpis);
            this.Name = "ProcesyProdukcyjneDlaZamowienieElement";
            this.Text = "Proces Produkcyjny Dla Zamowienie Element";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesProdukcyjny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdProcesu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPokaz;
        private System.Windows.Forms.DataGridView dgvProcesProdukcyjny;
        private System.Windows.Forms.NumericUpDown nudIdProcesu;
        private System.Windows.Forms.Label lblOpis;
    }
}