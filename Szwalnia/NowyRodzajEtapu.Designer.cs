namespace Szwalnia
{
    partial class NowyRodzajEtapu
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
            this.lblNazwaEtapu = new System.Windows.Forms.Label();
            this.tbNazwaEtapu = new System.Windows.Forms.TextBox();
            this.btnWyzerujEtap = new System.Windows.Forms.Button();
            this.btnAnulujEtap = new System.Windows.Forms.Button();
            this.btnZapiszEtap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNazwaEtapu
            // 
            this.lblNazwaEtapu.AutoSize = true;
            this.lblNazwaEtapu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaEtapu.Location = new System.Drawing.Point(73, 104);
            this.lblNazwaEtapu.Name = "lblNazwaEtapu";
            this.lblNazwaEtapu.Size = new System.Drawing.Size(147, 20);
            this.lblNazwaEtapu.TabIndex = 0;
            this.lblNazwaEtapu.Text = "Wpisz nazwę etapu";
            // 
            // tbNazwaEtapu
            // 
            this.tbNazwaEtapu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNazwaEtapu.Location = new System.Drawing.Point(293, 103);
            this.tbNazwaEtapu.Name = "tbNazwaEtapu";
            this.tbNazwaEtapu.Size = new System.Drawing.Size(175, 26);
            this.tbNazwaEtapu.TabIndex = 1;
            // 
            // btnWyzerujEtap
            // 
            this.btnWyzerujEtap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyzerujEtap.Location = new System.Drawing.Point(353, 183);
            this.btnWyzerujEtap.Name = "btnWyzerujEtap";
            this.btnWyzerujEtap.Size = new System.Drawing.Size(80, 50);
            this.btnWyzerujEtap.TabIndex = 4;
            this.btnWyzerujEtap.Text = "Wyzeruj";
            this.btnWyzerujEtap.UseVisualStyleBackColor = true;
            // 
            // btnAnulujEtap
            // 
            this.btnAnulujEtap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnulujEtap.Location = new System.Drawing.Point(245, 183);
            this.btnAnulujEtap.Name = "btnAnulujEtap";
            this.btnAnulujEtap.Size = new System.Drawing.Size(80, 50);
            this.btnAnulujEtap.TabIndex = 5;
            this.btnAnulujEtap.Text = "Anuluj";
            this.btnAnulujEtap.UseVisualStyleBackColor = true;
            // 
            // btnZapiszEtap
            // 
            this.btnZapiszEtap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapiszEtap.Location = new System.Drawing.Point(126, 183);
            this.btnZapiszEtap.Name = "btnZapiszEtap";
            this.btnZapiszEtap.Size = new System.Drawing.Size(80, 50);
            this.btnZapiszEtap.TabIndex = 6;
            this.btnZapiszEtap.Text = "Zapisz";
            this.btnZapiszEtap.UseVisualStyleBackColor = true;
            // 
            // NowyRodzajEtapu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 297);
            this.Controls.Add(this.btnWyzerujEtap);
            this.Controls.Add(this.btnAnulujEtap);
            this.Controls.Add(this.btnZapiszEtap);
            this.Controls.Add(this.tbNazwaEtapu);
            this.Controls.Add(this.lblNazwaEtapu);
            this.Name = "NowyRodzajEtapu";
            this.Text = "Nowy rodzaj etapu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazwaEtapu;
        private System.Windows.Forms.TextBox tbNazwaEtapu;
        private System.Windows.Forms.Button btnWyzerujEtap;
        private System.Windows.Forms.Button btnAnulujEtap;
        private System.Windows.Forms.Button btnZapiszEtap;
    }
}