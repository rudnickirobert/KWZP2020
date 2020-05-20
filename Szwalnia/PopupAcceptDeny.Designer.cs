namespace Szwalnia
{
    partial class PopupAcceptDeny
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDeny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(342, 93);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "lblInfo";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(56, 105);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(123, 42);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Akceptuj";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDeny
            // 
            this.btnDeny.Location = new System.Drawing.Point(185, 105);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(123, 42);
            this.btnDeny.TabIndex = 2;
            this.btnDeny.Text = "Odrzuć";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // PopupAcceptDeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 176);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblInfo);
            this.Name = "PopupAcceptDeny";
            this.Text = "PopupAcceptDeny";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PopupAcceptDeny_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDeny;
    }
}