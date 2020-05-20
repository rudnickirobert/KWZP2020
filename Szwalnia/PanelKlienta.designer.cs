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
            this.btnKlient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKlient.Location = new System.Drawing.Point(12, 26);
            this.btnKlient.Name = "btnKlient";
            this.btnKlient.Size = new System.Drawing.Size(201, 127);
            this.btnKlient.TabIndex = 0;
            this.btnKlient.Text = "Klienci";
            this.btnKlient.UseVisualStyleBackColor = true;
            this.btnKlient.Click += new System.EventHandler(this.btnKlient_Click);
            // 
            // btnNowyKlient
            // 
            this.btnNowyKlient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNowyKlient.Location = new System.Drawing.Point(236, 26);
            this.btnNowyKlient.Name = "btnNowyKlient";
            this.btnNowyKlient.Size = new System.Drawing.Size(201, 127);
            this.btnNowyKlient.TabIndex = 1;
            this.btnNowyKlient.Text = "Nowy klient";
            this.btnNowyKlient.UseVisualStyleBackColor = true;
            this.btnNowyKlient.Click += new System.EventHandler(this.btnNowyKlient_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(333, 203);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(104, 34);
            this.btnZamknij.TabIndex = 2;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // PanelKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(449, 256);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnNowyKlient);
            this.Controls.Add(this.btnKlient);
            this.Name = "PanelKlienta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel_Klienta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlient;
        private System.Windows.Forms.Button btnNowyKlient;
        private System.Windows.Forms.Button btnZamknij;
    }
}