namespace Szwalnia
{
    partial class NowaRealizacjaProcesu
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
            this.btnZapisz = new System.Windows.Forms.Button();
            this.lblOpis = new System.Windows.Forms.Label();
            this.tbEtap = new System.Windows.Forms.TextBox();
            this.btnRodzajEtapu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZapisz
            // 
            this.btnZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.Location = new System.Drawing.Point(155, 159);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(80, 30);
            this.btnZapisz.TabIndex = 0;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(33, 58);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(140, 18);
            this.lblOpis.TabIndex = 1;
            this.lblOpis.Text = "Wprowadź ID Etapu";
            // 
            // tbEtap
            // 
            this.tbEtap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEtap.Location = new System.Drawing.Point(224, 58);
            this.tbEtap.Name = "tbEtap";
            this.tbEtap.Size = new System.Drawing.Size(100, 24);
            this.tbEtap.TabIndex = 2;
            // 
            // btnRodzajEtapu
            // 
            this.btnRodzajEtapu.Location = new System.Drawing.Point(141, 120);
            this.btnRodzajEtapu.Name = "btnRodzajEtapu";
            this.btnRodzajEtapu.Size = new System.Drawing.Size(116, 23);
            this.btnRodzajEtapu.TabIndex = 3;
            this.btnRodzajEtapu.Text = "Rodzaj etapu";
            this.btnRodzajEtapu.UseVisualStyleBackColor = true;
            this.btnRodzajEtapu.Click += new System.EventHandler(this.button1_Click);
            // 
            // NowaRealizacjaProcesu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 236);
            this.Controls.Add(this.btnRodzajEtapu);
            this.Controls.Add(this.tbEtap);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.btnZapisz);
            this.Name = "NowaRealizacjaProcesu";
            this.Text = "Nowa Realizacja Procesu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox tbEtap;
        private System.Windows.Forms.Button btnRodzajEtapu;
    }
}