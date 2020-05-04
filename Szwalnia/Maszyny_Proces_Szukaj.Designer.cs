namespace Szwalnia
{
    partial class Maszyny_Proces_Szukaj
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
            this.txtbox = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Wpisz ID_Maszyny_proces";
            // 
            // lblLaboratoria
            // 
            this.lblLaboratoria.AutoSize = true;
            this.lblLaboratoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLaboratoria.Location = new System.Drawing.Point(12, 6);
            this.lblLaboratoria.Name = "lblLaboratoria";
            this.lblLaboratoria.Size = new System.Drawing.Size(267, 29);
            this.lblLaboratoria.TabIndex = 12;
            this.lblLaboratoria.Text = "Laboratoria KWZP 2020";
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(12, 64);
            this.txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(267, 22);
            this.txtbox.TabIndex = 11;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(12, 109);
            this.btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(267, 36);
            this.btn.TabIndex = 10;
            this.btn.Text = "Szukaj";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Maszyny_Proces_Szukaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 166);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLaboratoria);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.btn);
            this.Name = "Maszyny_Proces_Szukaj";
            this.Text = "Maszyny_Proces_Szukaj";
            this.Load += new System.EventHandler(this.Maszyny_Proces_Szukaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLaboratoria;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button btn;
    }
}