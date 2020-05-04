namespace Szwalnia
{
    partial class Suma_Czasu_Pokaz
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Suma_Czas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Suma_Czas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(960, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sumy czasow dla poszczegolnych procesow technologicznych";
            // 
            // dgv_Suma_Czas
            // 
            this.dgv_Suma_Czas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Suma_Czas.Location = new System.Drawing.Point(13, 112);
            this.dgv_Suma_Czas.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Suma_Czas.Name = "dgv_Suma_Czas";
            this.dgv_Suma_Czas.RowHeadersWidth = 51;
            this.dgv_Suma_Czas.Size = new System.Drawing.Size(1024, 325);
            this.dgv_Suma_Czas.TabIndex = 2;
            // 
            // Suma_Czasu_Pokaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Suma_Czas);
            this.Name = "Suma_Czasu_Pokaz";
            this.Text = "Suma_Czasu_Pokaz";
            this.Load += new System.EventHandler(this.Suma_Czasu_Pokaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Suma_Czas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Suma_Czas;
    }
}