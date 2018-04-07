namespace MP3_meta_editor
{
    partial class Sablon
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPotvrditi = new System.Windows.Forms.Button();
            this.btnOtkazati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite broj članova:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnPotvrditi
            // 
            this.btnPotvrditi.Location = new System.Drawing.Point(37, 77);
            this.btnPotvrditi.Name = "btnPotvrditi";
            this.btnPotvrditi.Size = new System.Drawing.Size(99, 35);
            this.btnPotvrditi.TabIndex = 2;
            this.btnPotvrditi.Text = "Potvrditi";
            this.btnPotvrditi.UseVisualStyleBackColor = true;
            this.btnPotvrditi.Click += new System.EventHandler(this.btnPotvrditi_Click);
            // 
            // btnOtkazati
            // 
            this.btnOtkazati.Location = new System.Drawing.Point(216, 77);
            this.btnOtkazati.Name = "btnOtkazati";
            this.btnOtkazati.Size = new System.Drawing.Size(99, 35);
            this.btnOtkazati.TabIndex = 3;
            this.btnOtkazati.Text = "Otkazati";
            this.btnOtkazati.UseVisualStyleBackColor = true;
            this.btnOtkazati.Click += new System.EventHandler(this.btnOtkazati_Click);
            // 
            // Sablon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 121);
            this.ControlBox = false;
            this.Controls.Add(this.btnOtkazati);
            this.Controls.Add(this.btnPotvrditi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Sablon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Članovi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPotvrditi;
        private System.Windows.Forms.Button btnOtkazati;
    }
}