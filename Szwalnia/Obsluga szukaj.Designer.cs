namespace Szwalnia
{
    partial class Obsluga_szukaj
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
            this.lblLaboratoria = new System.Windows.Forms.Label();
            this.txtboxlabki = new System.Windows.Forms.TextBox();
            this.btnwlwyl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Jaki rodzaj obsługi chcesz ywszukać?";
            // 
            // lblLaboratoria
            // 
            this.lblLaboratoria.AutoSize = true;
            this.lblLaboratoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLaboratoria.Location = new System.Drawing.Point(12, 6);
            this.lblLaboratoria.Name = "lblLaboratoria";
            this.lblLaboratoria.Size = new System.Drawing.Size(267, 29);
            this.lblLaboratoria.TabIndex = 16;
            this.lblLaboratoria.Text = "Laboratoria KWZP 2020";
            // 
            // txtboxlabki
            // 
            this.txtboxlabki.Location = new System.Drawing.Point(12, 64);
            this.txtboxlabki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxlabki.Name = "txtboxlabki";
            this.txtboxlabki.Size = new System.Drawing.Size(267, 22);
            this.txtboxlabki.TabIndex = 15;
            // 
            // btnwlwyl
            // 
            this.btnwlwyl.Location = new System.Drawing.Point(12, 92);
            this.btnwlwyl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnwlwyl.Name = "btnwlwyl";
            this.btnwlwyl.Size = new System.Drawing.Size(267, 36);
            this.btnwlwyl.TabIndex = 14;
            this.btnwlwyl.Text = "Szukaj";
            this.btnwlwyl.UseVisualStyleBackColor = true;
            this.btnwlwyl.Click += new System.EventHandler(this.btnwlwyl_Click_1);
            // 
            // Obsluga_szukaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 136);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLaboratoria);
            this.Controls.Add(this.txtboxlabki);
            this.Controls.Add(this.btnwlwyl);
            this.Name = "Obsluga_szukaj";
            this.Text = "Obsluga_szukaj";
            this.Load += new System.EventHandler(this.Obsluga_szukaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLaboratoria;
        private System.Windows.Forms.TextBox txtboxlabki;
        private System.Windows.Forms.Button btnwlwyl;
    }
}