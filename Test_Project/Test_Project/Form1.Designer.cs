namespace Test_Project
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
            this.professorButton = new System.Windows.Forms.Button();
            this.teddyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // professorButton
            // 
            this.professorButton.Location = new System.Drawing.Point(22, 21);
            this.professorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.professorButton.Name = "professorButton";
            this.professorButton.Size = new System.Drawing.Size(84, 23);
            this.professorButton.TabIndex = 0;
            this.professorButton.Text = "Professor Says";
            this.professorButton.UseVisualStyleBackColor = true;
            this.professorButton.Click += new System.EventHandler(this.professorButton_Click);
            // 
            // teddyButton
            // 
            this.teddyButton.Location = new System.Drawing.Point(121, 21);
            this.teddyButton.Margin = new System.Windows.Forms.Padding(2);
            this.teddyButton.Name = "teddyButton";
            this.teddyButton.Size = new System.Drawing.Size(84, 23);
            this.teddyButton.TabIndex = 1;
            this.teddyButton.Text = "Teddy";
            this.teddyButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 351);
            this.Controls.Add(this.teddyButton);
            this.Controls.Add(this.professorButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button professorButton;
        private System.Windows.Forms.Button teddyButton;
    }
}

