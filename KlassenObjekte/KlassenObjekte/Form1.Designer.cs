namespace KlassenUndObjekte
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.vectorX = new System.Windows.Forms.TextBox();
            this.vectorY = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.magBox = new System.Windows.Forms.TextBox();
            this.headingBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vectorX
            // 
            this.vectorX.Location = new System.Drawing.Point(22, 25);
            this.vectorX.Name = "vectorX";
            this.vectorX.Size = new System.Drawing.Size(100, 20);
            this.vectorX.TabIndex = 0;
            // 
            // vectorY
            // 
            this.vectorY.Location = new System.Drawing.Point(154, 25);
            this.vectorY.Name = "vectorY";
            this.vectorY.Size = new System.Drawing.Size(100, 20);
            this.vectorY.TabIndex = 0;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(101, 75);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "Click!";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // magBox
            // 
            this.magBox.Enabled = false;
            this.magBox.Location = new System.Drawing.Point(22, 167);
            this.magBox.Name = "magBox";
            this.magBox.Size = new System.Drawing.Size(100, 20);
            this.magBox.TabIndex = 2;
            // 
            // headingBox
            // 
            this.headingBox.Enabled = false;
            this.headingBox.Location = new System.Drawing.Point(154, 167);
            this.headingBox.Name = "headingBox";
            this.headingBox.Size = new System.Drawing.Size(100, 20);
            this.headingBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vector X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vector Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vector Magnitude:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vector Heading:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headingBox);
            this.Controls.Add(this.magBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.vectorY);
            this.Controls.Add(this.vectorX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vectorX;
        private System.Windows.Forms.TextBox vectorY;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox magBox;
        private System.Windows.Forms.TextBox headingBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

