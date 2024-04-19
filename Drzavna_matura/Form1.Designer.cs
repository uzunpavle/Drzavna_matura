namespace Drzavna_matura
{
    partial class Form1
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
            this.Unesi_skolu = new System.Windows.Forms.Button();
            this.Pregledaj_ucenike = new System.Windows.Forms.Button();
            this.Unesi_ucenika = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Unesi_skolu
            // 
            this.Unesi_skolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unesi_skolu.Location = new System.Drawing.Point(157, 284);
            this.Unesi_skolu.Name = "Unesi_skolu";
            this.Unesi_skolu.Size = new System.Drawing.Size(177, 107);
            this.Unesi_skolu.TabIndex = 3;
            this.Unesi_skolu.Text = "Унеси шаблон/школу";
            this.Unesi_skolu.UseVisualStyleBackColor = true;
            this.Unesi_skolu.Click += new System.EventHandler(this.Unesi_skolu_Click);
            // 
            // Pregledaj_ucenike
            // 
            this.Pregledaj_ucenike.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pregledaj_ucenike.Location = new System.Drawing.Point(616, 284);
            this.Pregledaj_ucenike.Name = "Pregledaj_ucenike";
            this.Pregledaj_ucenike.Size = new System.Drawing.Size(177, 107);
            this.Pregledaj_ucenike.TabIndex = 2;
            this.Pregledaj_ucenike.Text = "Прегледај ученике";
            this.Pregledaj_ucenike.UseVisualStyleBackColor = true;
            this.Pregledaj_ucenike.Click += new System.EventHandler(this.Pregledaj_ucenike_Click);
            // 
            // Unesi_ucenika
            // 
            this.Unesi_ucenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unesi_ucenika.Location = new System.Drawing.Point(387, 284);
            this.Unesi_ucenika.Name = "Unesi_ucenika";
            this.Unesi_ucenika.Size = new System.Drawing.Size(177, 107);
            this.Unesi_ucenika.TabIndex = 1;
            this.Unesi_ucenika.Text = "Унеси ученика";
            this.Unesi_ucenika.UseVisualStyleBackColor = true;
            this.Unesi_ucenika.Click += new System.EventHandler(this.Unesi_ucenika_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Државна матура";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(964, 549);
            this.Controls.Add(this.Unesi_skolu);
            this.Controls.Add(this.Pregledaj_ucenike);
            this.Controls.Add(this.Unesi_ucenika);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Unesi_skolu;
        private System.Windows.Forms.Button Pregledaj_ucenike;
        private System.Windows.Forms.Button Unesi_ucenika;
        private System.Windows.Forms.Label label1;
    }
}

