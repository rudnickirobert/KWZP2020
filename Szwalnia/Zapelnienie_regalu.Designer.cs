namespace Szwalnia
{
    partial class Zapelnienie_regalu
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
            this.dgvRegaly = new System.Windows.Forms.ListView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dgvRegaly
            // 
            this.dgvRegaly.HideSelection = false;
            this.dgvRegaly.Location = new System.Drawing.Point(88, 209);
            this.dgvRegaly.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dgvRegaly.Name = "dgvRegaly";
            this.dgvRegaly.Size = new System.Drawing.Size(1018, 364);
            this.dgvRegaly.TabIndex = 3;
            this.dgvRegaly.UseCompatibleStateImageBehavior = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(530, 78);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 39);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "label1";
            // 
            // Zapelnienie_regalu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 606);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvRegaly);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Zapelnienie_regalu";
            this.Text = "Zapełnienie regału";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView dgvRegaly;
        private System.Windows.Forms.Label lblTitle;
    }
}