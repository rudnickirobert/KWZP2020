namespace Szwalnia
{
    partial class btnSearch
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
            this.txtRegal = new System.Windows.Forms.TextBox();
            this.lblRegal = new System.Windows.Forms.Label();
            this.dgvRegaly = new System.Windows.Forms.ListView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRegal
            // 
            this.txtRegal.Location = new System.Drawing.Point(181, 108);
            this.txtRegal.Name = "txtRegal";
            this.txtRegal.Size = new System.Drawing.Size(361, 20);
            this.txtRegal.TabIndex = 0;
            this.txtRegal.TextChanged += new System.EventHandler(this.txtRegal_TextChanged);
            // 
            // lblRegal
            // 
            this.lblRegal.AutoSize = true;
            this.lblRegal.Location = new System.Drawing.Point(60, 111);
            this.lblRegal.Name = "lblRegal";
            this.lblRegal.Size = new System.Drawing.Size(97, 13);
            this.lblRegal.TabIndex = 1;
            this.lblRegal.Text = "Oznaczenie regału";
            // 
            // dgvRegaly
            // 
            this.dgvRegaly.HideSelection = false;
            this.dgvRegaly.Location = new System.Drawing.Point(13, 209);
            this.dgvRegaly.Name = "dgvRegaly";
            this.dgvRegaly.Size = new System.Drawing.Size(591, 177);
            this.dgvRegaly.TabIndex = 2;
            this.dgvRegaly.UseCompatibleStateImageBehavior = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(218, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 39);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "REGAŁY";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "SZUKAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvRegaly);
            this.Controls.Add(this.lblRegal);
            this.Controls.Add(this.txtRegal);
            this.Name = "btnSearch";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegal;
        private System.Windows.Forms.Label lblRegal;
        private System.Windows.Forms.ListView dgvRegaly;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
    }
}