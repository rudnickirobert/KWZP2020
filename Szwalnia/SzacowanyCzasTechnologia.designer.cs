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
            this.lbl1.Location = new System.Drawing.Point(206, 87);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(132, 24);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "ID zamówienia";
            // 
            // numIDZamowienia
            // 
            this.numIDZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numIDZamowienia.Location = new System.Drawing.Point(378, 85);
            this.numIDZamowienia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numIDZamowienia.Name = "numIDZamowienia";
            this.numIDZamowienia.Size = new System.Drawing.Size(163, 29);
            this.numIDZamowienia.TabIndex = 7;
            // 
            // dgvCzasTechnologow
            // 
            this.dgvCzasTechnologow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCzasTechnologow.Location = new System.Drawing.Point(29, 232);
            this.dgvCzasTechnologow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCzasTechnologow.Name = "dgvCzasTechnologow";
            this.dgvCzasTechnologow.RowHeadersWidth = 51;
            this.dgvCzasTechnologow.RowTemplate.Height = 24;
            this.dgvCzasTechnologow.Size = new System.Drawing.Size(708, 151);
            this.dgvCzasTechnologow.TabIndex = 6;
            // 
            // btnSzacowanyCzasTechnologow
            // 
            this.btnSzacowanyCzasTechnologow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzacowanyCzasTechnologow.Image = global::Szwalnia.Properties.Resources.lupa28x28;
            this.btnSzacowanyCzasTechnologow.Location = new System.Drawing.Point(339, 142);
            this.btnSzacowanyCzasTechnologow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSzacowanyCzasTechnologow.Name = "btnSzacowanyCzasTechnologow";
            this.btnSzacowanyCzasTechnologow.Size = new System.Drawing.Size(41, 43);
            this.btnSzacowanyCzasTechnologow.TabIndex = 5;
            this.btnSzacowanyCzasTechnologow.UseVisualStyleBackColor = true;
            this.btnSzacowanyCzasTechnologow.Click += new System.EventHandler(this.btnSzacowanyCzasTechnologow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(94, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Szacowany czas wykonania według dokumentacji technologicznej";
            // 
            // SzacowanyCzasTechnologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(783, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.numIDZamowienia);
            this.Controls.Add(this.dgvCzasTechnologow);
            this.Controls.Add(this.btnSzacowanyCzasTechnologow);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SzacowanyCzasTechnologia";
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