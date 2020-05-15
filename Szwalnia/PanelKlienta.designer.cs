namespace Szwalnia
{
    partial class PanelKlienta
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
            this.btnKlient = new System.Windows.Forms.Button();
            this.btnNowyKlient = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKlient
            // 
            this.btnKlient.Location = new System.Drawing.Point(48, 42);
            this.btnKlient.Name = "btnKlient";
            this.btnKlient.Size = new System.Drawing.Size(191, 54);
            this.btnKlient.TabIndex = 0;
            this.btnKlient.Text = "Klienci";
            this.btnKlient.UseVisualStyleBackColor = true;
            this.btnKlient.Click += new System.EventHandler(this.btnKlient_Click);
            // 
            // btnNowyKlient
            // 
            this.btnNowyKlient.Location = new System.Drawing.Point(48, 113);
            this.btnNowyKlient.Name = "btnNowyKlient";
            this.btnNowyKlient.Size = new System.Drawing.Size(191, 54);
            this.btnNowyKlient.TabIndex = 1;
            this.btnNowyKlient.Text = "Nowy klient";
            this.btnNowyKlient.UseVisualStyleBackColor = true;
            this.btnNowyKlient.Click += new System.EventHandler(this.btnNowyKlient_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(48, 268);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(191, 54);
            this.btnZamknij.TabIndex = 2;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // Panel_Klienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 335);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnNowyKlient);
            this.Controls.Add(this.btnKlient);
            this.Name = "Panel_Klienta";
            this.Text = "Panel_Klienta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlient;
        private System.Windows.Forms.Button btnNowyKlient;
        private System.Windows.Forms.Button btnZamknij;
    }
}