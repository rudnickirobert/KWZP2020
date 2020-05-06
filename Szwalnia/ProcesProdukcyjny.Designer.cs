namespace Szwalnia
{
    partial class ProcesProdukcyjny
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
            this.btnPrzegladProcesow = new System.Windows.Forms.Button();
            this.btnNowyProces = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrzegladProcesow
            // 
            this.btnPrzegladProcesow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzegladProcesow.Location = new System.Drawing.Point(68, 47);
            this.btnPrzegladProcesow.Name = "btnPrzegladProcesow";
            this.btnPrzegladProcesow.Size = new System.Drawing.Size(300, 120);
            this.btnPrzegladProcesow.TabIndex = 0;
            this.btnPrzegladProcesow.Text = "Przegląd procesów";
            this.btnPrzegladProcesow.UseVisualStyleBackColor = true;
            // 
            // btnNowyProces
            // 
            this.btnNowyProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNowyProces.Location = new System.Drawing.Point(68, 201);
            this.btnNowyProces.Name = "btnNowyProces";
            this.btnNowyProces.Size = new System.Drawing.Size(300, 120);
            this.btnNowyProces.TabIndex = 0;
            this.btnNowyProces.Text = "Nowy proces";
            this.btnNowyProces.UseVisualStyleBackColor = true;
            // 
            // ProcesProdukcyjny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.btnNowyProces);
            this.Controls.Add(this.btnPrzegladProcesow);
            this.Name = "ProcesProdukcyjny";
            this.Text = "Proces Produkcyjny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrzegladProcesow;
        private System.Windows.Forms.Button btnNowyProces;
    }
}