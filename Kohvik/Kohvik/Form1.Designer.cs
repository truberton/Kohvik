namespace Kohvik
{
    partial class Kohvik
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
            this.Kohvi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Toit = new System.Windows.Forms.ComboBox();
            this.Osta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kohvi
            // 
            this.Kohvi.FormattingEnabled = true;
            this.Kohvi.Location = new System.Drawing.Point(12, 42);
            this.Kohvi.Name = "Kohvi";
            this.Kohvi.Size = new System.Drawing.Size(121, 21);
            this.Kohvi.TabIndex = 0;
            this.Kohvi.SelectedIndexChanged += new System.EventHandler(this.Kohvi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tere tulemast Gerdi kohvikusse, mis te täna tahate?";
            // 
            // Toit
            // 
            this.Toit.FormattingEnabled = true;
            this.Toit.Location = new System.Drawing.Point(144, 42);
            this.Toit.Name = "Toit";
            this.Toit.Size = new System.Drawing.Size(121, 21);
            this.Toit.TabIndex = 2;
            this.Toit.SelectedIndexChanged += new System.EventHandler(this.Toit_SelectedIndexChanged);
            // 
            // Osta
            // 
            this.Osta.Location = new System.Drawing.Point(12, 113);
            this.Osta.Name = "Osta";
            this.Osta.Size = new System.Drawing.Size(75, 23);
            this.Osta.TabIndex = 3;
            this.Osta.Text = "Osta";
            this.Osta.UseVisualStyleBackColor = true;
            this.Osta.Click += new System.EventHandler(this.Osta_Click);
            // 
            // Kohvik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Osta);
            this.Controls.Add(this.Toit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kohvi);
            this.Name = "Kohvik";
            this.Text = "Kohvik";
            this.Load += new System.EventHandler(this.Kohvik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Kohvi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Toit;
        private System.Windows.Forms.Button Osta;
    }
}

