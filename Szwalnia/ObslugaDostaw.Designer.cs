namespace Szwalnia
{
    partial class ObslugaDostaw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObslugaDostaw));
            this.btnAddDelivery = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnPrzyjmijDostawe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddDelivery
            // 
            this.btnAddDelivery.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddDelivery.Location = new System.Drawing.Point(12, 12);
            this.btnAddDelivery.Name = "btnAddDelivery";
            this.btnAddDelivery.Size = new System.Drawing.Size(256, 111);
            this.btnAddDelivery.TabIndex = 0;
            this.btnAddDelivery.Text = "Dodaj dostawę";
            this.btnAddDelivery.UseVisualStyleBackColor = false;
            this.btnAddDelivery.Click += new System.EventHandler(this.btnAddDelivery_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lblInfo.Location = new System.Drawing.Point(65, 34);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(156, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Istnieją niezamówione materiały";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // btnPrzyjmijDostawe
            // 
            this.btnPrzyjmijDostawe.Location = new System.Drawing.Point(12, 129);
            this.btnPrzyjmijDostawe.Name = "btnPrzyjmijDostawe";
            this.btnPrzyjmijDostawe.Size = new System.Drawing.Size(256, 111);
            this.btnPrzyjmijDostawe.TabIndex = 2;
            this.btnPrzyjmijDostawe.Text = "Przyjmij dostawę";
            this.btnPrzyjmijDostawe.UseVisualStyleBackColor = true;
            this.btnPrzyjmijDostawe.Click += new System.EventHandler(this.btnPrzyjmijDostawe_Click);
            // 
            // ObslugaDostaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrzyjmijDostawe);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAddDelivery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ObslugaDostaw";
            this.Text = "ObslugaDostaw";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ObslugaDostaw_FormClosed);
            this.Load += new System.EventHandler(this.ObslugaDostaw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDelivery;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnPrzyjmijDostawe;
    }
}