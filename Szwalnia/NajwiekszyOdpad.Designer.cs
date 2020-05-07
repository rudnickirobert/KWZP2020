namespace Szwalnia
{
    partial class NajwiekszyOdpad
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
            this.dgvOdpad = new System.Windows.Forms.DataGridView();
            this.btnPokaz = new System.Windows.Forms.Button();
            this.nudNumerMiesiaca = new System.Windows.Forms.NumericUpDown();
            this.lblMiesiac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdpad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerMiesiaca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOdpad
            // 
            this.dgvOdpad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdpad.Location = new System.Drawing.Point(37, 56);
            this.dgvOdpad.Name = "dgvOdpad";
            this.dgvOdpad.Size = new System.Drawing.Size(714, 336);
            this.dgvOdpad.TabIndex = 0;
            // 
            // btnPokaz
            // 
            this.btnPokaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPokaz.Location = new System.Drawing.Point(516, 9);
            this.btnPokaz.Name = "btnPokaz";
            this.btnPokaz.Size = new System.Drawing.Size(75, 23);
            this.btnPokaz.TabIndex = 6;
            this.btnPokaz.Text = "Pokaż";
            this.btnPokaz.UseVisualStyleBackColor = true;
            this.btnPokaz.Click += new System.EventHandler(this.btnPokaz_Click);
            // 
            // nudNumerMiesiaca
            // 
            this.nudNumerMiesiaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudNumerMiesiaca.Location = new System.Drawing.Point(356, 12);
            this.nudNumerMiesiaca.Name = "nudNumerMiesiaca";
            this.nudNumerMiesiaca.Size = new System.Drawing.Size(120, 24);
            this.nudNumerMiesiaca.TabIndex = 5;
            // 
            // lblMiesiac
            // 
            this.lblMiesiac.AutoSize = true;
            this.lblMiesiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMiesiac.Location = new System.Drawing.Point(133, 15);
            this.lblMiesiac.Name = "lblMiesiac";
            this.lblMiesiac.Size = new System.Drawing.Size(159, 18);
            this.lblMiesiac.TabIndex = 4;
            this.lblMiesiac.Text = "Wpisz numer miesiąca";
            // 
            // NajwiekszyOdpad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPokaz);
            this.Controls.Add(this.nudNumerMiesiaca);
            this.Controls.Add(this.lblMiesiac);
            this.Controls.Add(this.dgvOdpad);
            this.Name = "NajwiekszyOdpad";
            this.Text = "Najwiekszy Odpad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdpad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumerMiesiaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOdpad;
        private System.Windows.Forms.Button btnPokaz;
        private System.Windows.Forms.NumericUpDown nudNumerMiesiaca;
        private System.Windows.Forms.Label lblMiesiac;
    }
}