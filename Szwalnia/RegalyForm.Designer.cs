namespace Szwalnia
{
    partial class RegalyForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegal = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(57, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "WYSZUKIWANIE REGAŁÓW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oznaczenie regału";
            // 
            // txtRegal
            // 
            this.txtRegal.Location = new System.Drawing.Point(235, 88);
            this.txtRegal.Name = "txtRegal";
            this.txtRegal.Size = new System.Drawing.Size(131, 20);
            this.txtRegal.TabIndex = 2;
            this.txtRegal.TextChanged += new System.EventHandler(this.txtRegal_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(196, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 41);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SZUKAJ";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // RegalyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 225);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtRegal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegalyForm";
            this.Text = "RegalyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegal;
        private System.Windows.Forms.Button btnSearch;
    }
}