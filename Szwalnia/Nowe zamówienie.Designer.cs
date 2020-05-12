namespace Szwalnia
{
    partial class Nowe_zamówienie
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
            this.lblOpisNumer = new System.Windows.Forms.Label();
            this.lblNumerZamowienia = new System.Windows.Forms.Label();
            this.tbIdZamowienieElement = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOpisNumer
            // 
            this.lblOpisNumer.AutoSize = true;
            this.lblOpisNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisNumer.Location = new System.Drawing.Point(33, 36);
            this.lblOpisNumer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpisNumer.Name = "lblOpisNumer";
            this.lblOpisNumer.Size = new System.Drawing.Size(269, 29);
            this.lblOpisNumer.TabIndex = 1;
            this.lblOpisNumer.Text = "ID nowego zamówienia:";
            this.lblOpisNumer.Click += new System.EventHandler(this.lblOpisNumer_Click);
            // 
            // lblNumerZamowienia
            // 
            this.lblNumerZamowienia.AutoSize = true;
            this.lblNumerZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumerZamowienia.Location = new System.Drawing.Point(471, 36);
            this.lblNumerZamowienia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumerZamowienia.Name = "lblNumerZamowienia";
            this.lblNumerZamowienia.Size = new System.Drawing.Size(64, 25);
            this.lblNumerZamowienia.TabIndex = 5;
            this.lblNumerZamowienia.Text = "label1";
            // 
            // tbIdZamowienieElement
            // 
            this.tbIdZamowienieElement.Location = new System.Drawing.Point(375, 81);
            this.tbIdZamowienieElement.Margin = new System.Windows.Forms.Padding(4);
            this.tbIdZamowienieElement.Name = "tbIdZamowienieElement";
            this.tbIdZamowienieElement.Size = new System.Drawing.Size(251, 22);
            this.tbIdZamowienieElement.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 111);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 22);
            this.textBox1.TabIndex = 7;
            // 
            // Nowe_zamówienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbIdZamowienieElement);
            this.Controls.Add(this.lblNumerZamowienia);
            this.Controls.Add(this.lblOpisNumer);
            this.Name = "Nowe_zamówienie";
            this.Text = "Nowe_zamówienie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpisNumer;
        private System.Windows.Forms.Label lblNumerZamowienia;
        private System.Windows.Forms.TextBox tbIdZamowienieElement;
        private System.Windows.Forms.TextBox textBox1;
    }
}