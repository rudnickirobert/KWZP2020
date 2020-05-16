namespace Szwalnia
{
    partial class ElementyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementyForm));
            this.btnWybor = new System.Windows.Forms.Button();
            this.btnElement = new System.Windows.Forms.Button();
            this.btnTyp = new System.Windows.Forms.Button();
            this.btnCecha = new System.Windows.Forms.Button();
            this.btnJednostka = new System.Windows.Forms.Button();
            this.btnCechyElementow = new System.Windows.Forms.Button();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWybor
            // 
            this.btnWybor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWybor.Location = new System.Drawing.Point(13, 14);
            this.btnWybor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWybor.Name = "btnWybor";
            this.btnWybor.Size = new System.Drawing.Size(249, 62);
            this.btnWybor.TabIndex = 0;
            this.btnWybor.Text = "Wybierz element";
            this.btnWybor.UseVisualStyleBackColor = true;
            this.btnWybor.Click += new System.EventHandler(this.btnWybor_Click);
            // 
            // btnElement
            // 
            this.btnElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnElement.Location = new System.Drawing.Point(13, 80);
            this.btnElement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnElement.Name = "btnElement";
            this.btnElement.Size = new System.Drawing.Size(249, 62);
            this.btnElement.TabIndex = 1;
            this.btnElement.Text = "Dodaj element";
            this.btnElement.UseVisualStyleBackColor = true;
            this.btnElement.Click += new System.EventHandler(this.btnElement_Click);
            // 
            // btnTyp
            // 
            this.btnTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTyp.Location = new System.Drawing.Point(13, 146);
            this.btnTyp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTyp.Name = "btnTyp";
            this.btnTyp.Size = new System.Drawing.Size(249, 62);
            this.btnTyp.TabIndex = 2;
            this.btnTyp.Text = "Dodaj typ elementu";
            this.btnTyp.UseVisualStyleBackColor = true;
            this.btnTyp.Click += new System.EventHandler(this.btnTyp_Click);
            // 
            // btnCecha
            // 
            this.btnCecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCecha.Location = new System.Drawing.Point(13, 214);
            this.btnCecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCecha.Name = "btnCecha";
            this.btnCecha.Size = new System.Drawing.Size(249, 62);
            this.btnCecha.TabIndex = 3;
            this.btnCecha.Text = "Dodaj cechę elementu";
            this.btnCecha.UseVisualStyleBackColor = true;
            this.btnCecha.Click += new System.EventHandler(this.btnCecha_Click);
            // 
            // btnJednostka
            // 
            this.btnJednostka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJednostka.Location = new System.Drawing.Point(12, 281);
            this.btnJednostka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJednostka.Name = "btnJednostka";
            this.btnJednostka.Size = new System.Drawing.Size(249, 62);
            this.btnJednostka.TabIndex = 4;
            this.btnJednostka.Text = "Dodaj jednostkę miary";
            this.btnJednostka.UseVisualStyleBackColor = true;
            this.btnJednostka.Click += new System.EventHandler(this.btnJednostka_Click);
            // 
            // btnCechyElementow
            // 
            this.btnCechyElementow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCechyElementow.Location = new System.Drawing.Point(13, 348);
            this.btnCechyElementow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCechyElementow.Name = "btnCechyElementow";
            this.btnCechyElementow.Size = new System.Drawing.Size(249, 62);
            this.btnCechyElementow.TabIndex = 5;
            this.btnCechyElementow.Text = "Przypisz cechy elementom";
            this.btnCechyElementow.UseVisualStyleBackColor = true;
            this.btnCechyElementow.Click += new System.EventHandler(this.btnCechyElementow_Click);
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(197, 427);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(77, 30);
            this.btnWstecz.TabIndex = 25;
            this.btnWstecz.Text = "Wstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // ElementyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 472);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.btnCechyElementow);
            this.Controls.Add(this.btnJednostka);
            this.Controls.Add(this.btnCecha);
            this.Controls.Add(this.btnTyp);
            this.Controls.Add(this.btnElement);
            this.Controls.Add(this.btnWybor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ElementyForm";
            this.Text = "ElementyForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ElementyForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWybor;
        private System.Windows.Forms.Button btnElement;
        private System.Windows.Forms.Button btnTyp;
        private System.Windows.Forms.Button btnCecha;
        private System.Windows.Forms.Button btnJednostka;
        private System.Windows.Forms.Button btnCechyElementow;
        private System.Windows.Forms.Button btnWstecz;
    }
}