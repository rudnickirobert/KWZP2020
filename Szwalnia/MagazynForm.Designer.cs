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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElementyForm
            // 
            this.btnElementyForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnElementyForm.Location = new System.Drawing.Point(12, 12);
            this.btnElementyForm.Name = "btnElementyForm";
            this.btnElementyForm.Size = new System.Drawing.Size(218, 67);
            this.btnElementyForm.TabIndex = 0;
            this.btnElementyForm.Text = "Elementy";
            this.btnElementyForm.UseVisualStyleBackColor = true;
            this.btnElementyForm.Click += new System.EventHandler(this.btnElementyForm_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(370, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Układ Magazynu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MagazynForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnElementyForm);
            this.Name = "MagazynForm";
            this.Text = "Moduł magazynowy";
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button btnElementyForm;
        private System.Windows.Forms.Button button1;
    }
}