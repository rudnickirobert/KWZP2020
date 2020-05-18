namespace Szwalnia
{
    partial class PanelJezykow
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
            this.btnZnajomosc = new System.Windows.Forms.Button();
            this.btnNowy = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZnajomosc
            // 
            this.btnZnajomosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZnajomosc.Location = new System.Drawing.Point(31, 22);
            this.btnZnajomosc.Name = "btnZnajomosc";
            this.btnZnajomosc.Size = new System.Drawing.Size(192, 144);
            this.btnZnajomosc.TabIndex = 0;
            this.btnZnajomosc.Text = "Sprawdź znajomość języków u pracowników";
            this.btnZnajomosc.UseVisualStyleBackColor = true;
            this.btnZnajomosc.Click += new System.EventHandler(this.btnZnajomosc_Click);
            // 
            // btnNowy
            // 
            this.btnNowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNowy.Location = new System.Drawing.Point(262, 22);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Size = new System.Drawing.Size(197, 144);
            this.btnNowy.TabIndex = 1;
            this.btnNowy.Text = "Dodaj pracownikowi znajomość języka";
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(309, 179);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(150, 43);
            this.btnZamknij.TabIndex = 2;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // PanelJezykow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 237);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnNowy);
            this.Controls.Add(this.btnZnajomosc);
            this.Name = "PanelJezykow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel języków";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZnajomosc;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.Button btnZamknij;
    }
}