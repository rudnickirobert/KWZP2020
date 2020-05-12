namespace Szwalnia
{
    partial class MaszynyProcesSzukaj
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
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblLaboratoria = new System.Windows.Forms.Label();
            this.txtbSzukaj = new System.Windows.Forms.TextBox();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(47, 45);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(243, 17);
            this.lblOpis.TabIndex = 13;
            this.lblOpis.Text = "Wpisz  ID Procesu Technologicznego";
            // 
            // lblLaboratoria
            // 
            this.lblLaboratoria.AutoSize = true;
            this.lblLaboratoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLaboratoria.Location = new System.Drawing.Point(12, 6);
            this.lblLaboratoria.Name = "lblLaboratoria";
            this.lblLaboratoria.Size = new System.Drawing.Size(307, 29);
            this.lblLaboratoria.TabIndex = 12;
            this.lblLaboratoria.Text = "Maszyny użyte w procesach";
            // 
            // txtbSzukaj
            // 
            this.txtbSzukaj.Location = new System.Drawing.Point(17, 64);
            this.txtbSzukaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbSzukaj.Name = "txtbSzukaj";
            this.txtbSzukaj.Size = new System.Drawing.Size(302, 22);
            this.txtbSzukaj.TabIndex = 11;
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(12, 109);
            this.btnSzukaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(307, 36);
            this.btnSzukaj.TabIndex = 10;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // MaszynyProcesSzukaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 166);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblLaboratoria);
            this.Controls.Add(this.txtbSzukaj);
            this.Controls.Add(this.btnSzukaj);
            this.Name = "MaszynyProcesSzukaj";
            this.Text = "Maszyny_Proces_Szukaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblLaboratoria;
        private System.Windows.Forms.TextBox txtbSzukaj;
        private System.Windows.Forms.Button btnSzukaj;
    }
}