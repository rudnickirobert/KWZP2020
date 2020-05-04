namespace Szwalnia
{
    partial class MagazynForm
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
            this.btnElementyForm = new System.Windows.Forms.Button();
            this.btnKurierzy = new System.Windows.Forms.Button();
            this.btnOferty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElementyForm
            // 
            this.btnElementyForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnElementyForm.Location = new System.Drawing.Point(16, 15);
            this.btnElementyForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnElementyForm.Name = "btnElementyForm";
            this.btnElementyForm.Size = new System.Drawing.Size(291, 82);
            this.btnElementyForm.TabIndex = 0;
            this.btnElementyForm.Text = "Elementy";
            this.btnElementyForm.UseVisualStyleBackColor = true;
            this.btnElementyForm.Click += new System.EventHandler(this.btnElementyForm_Click);
          
            // 
            // MagazynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKurierzy);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnOferty);
            this.Controls.Add(this.btnElementyForm);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MagazynForm";
            this.Text = "Moduł magazynowy";
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button btnElementyForm;
        private System.Windows.Forms.Button btnKurierzy;
        private System.Windows.Forms.Button btnOferty;
    }
}