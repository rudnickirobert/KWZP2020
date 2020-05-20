namespace Szwalnia
{
    partial class ObslugaZamowien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObslugaZamowien));
            this.btnAddWorkersDeliverers = new System.Windows.Forms.Button();
            this.btnWydajKurierowi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddWorkersDeliverers
            // 
            this.btnAddWorkersDeliverers.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddWorkersDeliverers.Location = new System.Drawing.Point(12, 12);
            this.btnAddWorkersDeliverers.Name = "btnAddWorkersDeliverers";
            this.btnAddWorkersDeliverers.Size = new System.Drawing.Size(256, 111);
            this.btnAddWorkersDeliverers.TabIndex = 1;
            this.btnAddWorkersDeliverers.Text = "Przypisz pracowników i kurierów";
            this.btnAddWorkersDeliverers.UseVisualStyleBackColor = false;
            this.btnAddWorkersDeliverers.Click += new System.EventHandler(this.btnAddWorkersDeliverers_Click);
            // 
            // btnWydajKurierowi
            // 
            this.btnWydajKurierowi.BackColor = System.Drawing.SystemColors.Control;
            this.btnWydajKurierowi.Location = new System.Drawing.Point(12, 167);
            this.btnWydajKurierowi.Name = "btnWydajKurierowi";
            this.btnWydajKurierowi.Size = new System.Drawing.Size(256, 111);
            this.btnWydajKurierowi.TabIndex = 2;
            this.btnWydajKurierowi.Text = "Zrealizuj wydanie zamówienia kurierowi.";
            this.btnWydajKurierowi.UseVisualStyleBackColor = false;
            this.btnWydajKurierowi.Click += new System.EventHandler(this.btnWydajKurierowi_Click);
            // 
            // ObslugaZamowien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWydajKurierowi);
            this.Controls.Add(this.btnAddWorkersDeliverers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ObslugaZamowien";
            this.Text = "ObslugaZamowien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ObslugaZamowien_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddWorkersDeliverers;
        private System.Windows.Forms.Button btnWydajKurierowi;
    }
}