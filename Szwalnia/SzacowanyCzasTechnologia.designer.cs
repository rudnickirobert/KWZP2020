namespace Szwalnia
{
    partial class SzacowanyCzasTechnologia
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.numIDZamowienia = new System.Windows.Forms.NumericUpDown();
            this.dgvCzasTechnologow = new System.Windows.Forms.DataGridView();
            this.btnSzacowanyCzasTechnologow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIDZamowienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzasTechnologow)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(262, 50);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(105, 18);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "ID zamówienia";
            // 
            // numIDZamowienia
            // 
            this.numIDZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numIDZamowienia.Location = new System.Drawing.Point(256, 87);
            this.numIDZamowienia.Margin = new System.Windows.Forms.Padding(2);
            this.numIDZamowienia.Name = "numIDZamowienia";
            this.numIDZamowienia.Size = new System.Drawing.Size(122, 24);
            this.numIDZamowienia.TabIndex = 7;
            // 
            // dgvCzasTechnologow
            // 
            this.dgvCzasTechnologow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzasTechnologow.Location = new System.Drawing.Point(22, 187);
            this.dgvCzasTechnologow.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCzasTechnologow.Name = "dgvCzasTechnologow";
            this.dgvCzasTechnologow.RowHeadersWidth = 51;
            this.dgvCzasTechnologow.RowTemplate.Height = 24;
            this.dgvCzasTechnologow.Size = new System.Drawing.Size(594, 123);
            this.dgvCzasTechnologow.TabIndex = 6;
            // 
            // btnSzacowanyCzasTechnologow
            // 
            this.btnSzacowanyCzasTechnologow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzacowanyCzasTechnologow.Location = new System.Drawing.Point(256, 128);
            this.btnSzacowanyCzasTechnologow.Margin = new System.Windows.Forms.Padding(2);
            this.btnSzacowanyCzasTechnologow.Name = "btnSzacowanyCzasTechnologow";
            this.btnSzacowanyCzasTechnologow.Size = new System.Drawing.Size(122, 35);
            this.btnSzacowanyCzasTechnologow.TabIndex = 5;
            this.btnSzacowanyCzasTechnologow.Text = "Pokaż szczegóły";
            this.btnSzacowanyCzasTechnologow.UseVisualStyleBackColor = true;
            this.btnSzacowanyCzasTechnologow.Click += new System.EventHandler(this.btnSzacowanyCzasTechnologow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Szacowany czas wykonania wg dokumentacji technologicznej";
            // 
            // SzacowanyCzasWgTechnologow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.numIDZamowienia);
            this.Controls.Add(this.dgvCzasTechnologow);
            this.Controls.Add(this.btnSzacowanyCzasTechnologow);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SzacowanyCzasWgTechnologow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szacowany czas - technologia";
            ((System.ComponentModel.ISupportInitialize)(this.numIDZamowienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCzasTechnologow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.NumericUpDown numIDZamowienia;
        private System.Windows.Forms.DataGridView dgvCzasTechnologow;
        private System.Windows.Forms.Button btnSzacowanyCzasTechnologow;
        private System.Windows.Forms.Label label1;
    }
}