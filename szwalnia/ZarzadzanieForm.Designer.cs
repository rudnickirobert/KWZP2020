namespace Szwalnia
{
    partial class ZarzadzanieForm
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
            this.btnKlienciForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKlienciForm
            // 
            this.btnKlienciForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKlienciForm.Location = new System.Drawing.Point(30, 35);
            this.btnKlienciForm.Name = "btnKlienciForm";
            this.btnKlienciForm.Size = new System.Drawing.Size(190, 64);
            this.btnKlienciForm.TabIndex = 0;
            this.btnKlienciForm.Text = "Klienci";
            this.btnKlienciForm.UseVisualStyleBackColor = true;
            this.btnKlienciForm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnKlienciForm_MouseClick);
            // 
            // ZarzadzanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKlienciForm);
            this.Name = "ZarzadzanieForm";
            this.Text = "Moduł Zarządzanie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlienciForm;
    }
}