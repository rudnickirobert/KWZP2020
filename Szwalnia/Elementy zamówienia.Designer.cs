namespace Szwalnia
{
    partial class ElementyZamowienia
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
            this.btnNowy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.cbElement = new System.Windows.Forms.ComboBox();
            this.lblStary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNowy
            // 
            this.btnNowy.Location = new System.Drawing.Point(69, 28);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Size = new System.Drawing.Size(163, 35);
            this.btnNowy.TabIndex = 0;
            this.btnNowy.Text = "Dodaj nowy element";
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość";
            // 
            // txtIlosc
            // 
            this.txtIlosc.Location = new System.Drawing.Point(69, 187);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(163, 22);
            this.txtIlosc.TabIndex = 2;
            // 
            // cbElement
            // 
            this.cbElement.FormattingEnabled = true;
            this.cbElement.Location = new System.Drawing.Point(69, 98);
            this.cbElement.Name = "cbElement";
            this.cbElement.Size = new System.Drawing.Size(203, 24);
            this.cbElement.TabIndex = 3;
            // 
            // lblStary
            // 
            this.lblStary.AutoSize = true;
            this.lblStary.Location = new System.Drawing.Point(66, 78);
            this.lblStary.Name = "lblStary";
            this.lblStary.Size = new System.Drawing.Size(175, 17);
            this.lblStary.TabIndex = 5;
            this.lblStary.Text = "Wybierz istniejący element";
            // 
            // ElementyZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 538);
            this.Controls.Add(this.lblStary);
            this.Controls.Add(this.cbElement);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNowy);
            this.Name = "ElementyZamowienia";
            this.Text = "Elementy_zamówienia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIlosc;
        private System.Windows.Forms.ComboBox cbElement;
        private System.Windows.Forms.Label lblStary;
    }
}