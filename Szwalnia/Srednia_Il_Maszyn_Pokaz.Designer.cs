namespace Szwalnia
{
    partial class Srednia_Il_Maszyn_Pokaz
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
            this.dgv_Srednia_Il = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Srednia_Il)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Srednia_Il
            // 
            this.dgv_Srednia_Il.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Srednia_Il.Location = new System.Drawing.Point(13, 42);
            this.dgv_Srednia_Il.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Srednia_Il.Name = "dgv_Srednia_Il";
            this.dgv_Srednia_Il.RowHeadersWidth = 51;
            this.dgv_Srednia_Il.Size = new System.Drawing.Size(340, 154);
            this.dgv_Srednia_Il.TabIndex = 3;
            this.dgv_Srednia_Il.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Srednia_Il_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Srednia ilosc maszyn";
            // 
            // Srednia_Il_Maszyn_Pokaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 208);
            this.Controls.Add(this.dgv_Srednia_Il);
            this.Controls.Add(this.label1);
            this.Name = "Srednia_Il_Maszyn_Pokaz";
            this.Text = "Srednia_Il_Maszyn_Pokaz";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Srednia_Il)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Srednia_Il;
        private System.Windows.Forms.Label label1;
    }
}