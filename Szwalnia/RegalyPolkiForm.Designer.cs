namespace Szwalnia
{
    partial class RegalyPolkiForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.btnSearchStorage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(115, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "WYSZUKAJ REGAŁ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Oznaczenie regału";
            // 
            // txtStorage
            // 
            this.txtStorage.Location = new System.Drawing.Point(203, 113);
            this.txtStorage.Name = "txtStorage";
            this.txtStorage.Size = new System.Drawing.Size(237, 20);
            this.txtStorage.TabIndex = 2;
            this.txtStorage.TextChanged += new System.EventHandler(this.txtStorage_TextChanged);
            // 
            // btnSearchStorage
            // 
            this.btnSearchStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSearchStorage.Location = new System.Drawing.Point(203, 153);
            this.btnSearchStorage.Name = "btnSearchStorage";
            this.btnSearchStorage.Size = new System.Drawing.Size(103, 36);
            this.btnSearchStorage.TabIndex = 3;
            this.btnSearchStorage.Text = "SZUKAJ";
            this.btnSearchStorage.UseVisualStyleBackColor = true;
            this.btnSearchStorage.Click += new System.EventHandler(this.btnSearchStorage_Click);
            // 
            // RegalyPolkiForm
            // 
            this.ClientSize = new System.Drawing.Size(511, 256);
            this.Controls.Add(this.btnSearchStorage);
            this.Controls.Add(this.txtStorage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "RegalyPolkiForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.Button btnSearchStorage;
    }
}