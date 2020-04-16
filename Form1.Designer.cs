namespace Prog2
{
    partial class Program2
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
            this.InputLNameInitial = new System.Windows.Forms.TextBox();
            this.RseniorButton = new System.Windows.Forms.RadioButton();
            this.Rjuniorbutton = new System.Windows.Forms.RadioButton();
            this.RsophomoreButton = new System.Windows.Forms.RadioButton();
            this.RfreshmanButton = new System.Windows.Forms.RadioButton();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name Initial:";
            // 
            // InputLNameInitial
            // 
            this.InputLNameInitial.Location = new System.Drawing.Point(140, 58);
            this.InputLNameInitial.Name = "InputLNameInitial";
            this.InputLNameInitial.Size = new System.Drawing.Size(100, 20);
            this.InputLNameInitial.TabIndex = 1;
            // 
            // RseniorButton
            // 
            this.RseniorButton.AutoSize = true;
            this.RseniorButton.Location = new System.Drawing.Point(52, 96);
            this.RseniorButton.Name = "RseniorButton";
            this.RseniorButton.Size = new System.Drawing.Size(55, 17);
            this.RseniorButton.TabIndex = 2;
            this.RseniorButton.TabStop = true;
            this.RseniorButton.Text = "Senior";
            this.RseniorButton.UseVisualStyleBackColor = true;
            // 
            // Rjuniorbutton
            // 
            this.Rjuniorbutton.AutoSize = true;
            this.Rjuniorbutton.Location = new System.Drawing.Point(52, 119);
            this.Rjuniorbutton.Name = "Rjuniorbutton";
            this.Rjuniorbutton.Size = new System.Drawing.Size(53, 17);
            this.Rjuniorbutton.TabIndex = 3;
            this.Rjuniorbutton.TabStop = true;
            this.Rjuniorbutton.Text = "Junior";
            this.Rjuniorbutton.UseVisualStyleBackColor = true;
            // 
            // RsophomoreButton
            // 
            this.RsophomoreButton.AutoSize = true;
            this.RsophomoreButton.Location = new System.Drawing.Point(52, 143);
            this.RsophomoreButton.Name = "RsophomoreButton";
            this.RsophomoreButton.Size = new System.Drawing.Size(79, 17);
            this.RsophomoreButton.TabIndex = 4;
            this.RsophomoreButton.TabStop = true;
            this.RsophomoreButton.Text = "Sophomore";
            this.RsophomoreButton.UseVisualStyleBackColor = true;
            // 
            // RfreshmanButton
            // 
            this.RfreshmanButton.AutoSize = true;
            this.RfreshmanButton.Location = new System.Drawing.Point(52, 167);
            this.RfreshmanButton.Name = "RfreshmanButton";
            this.RfreshmanButton.Size = new System.Drawing.Size(71, 17);
            this.RfreshmanButton.TabIndex = 5;
            this.RfreshmanButton.TabStop = true;
            this.RfreshmanButton.Text = "Freshman";
            this.RfreshmanButton.UseVisualStyleBackColor = true;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(52, 209);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 6;
            this.ExecuteButton.Text = "Show";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // Program2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.RfreshmanButton);
            this.Controls.Add(this.RsophomoreButton);
            this.Controls.Add(this.Rjuniorbutton);
            this.Controls.Add(this.RseniorButton);
            this.Controls.Add(this.InputLNameInitial);
            this.Controls.Add(this.label1);
            this.Name = "Program2";
            this.Text = "Program2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputLNameInitial;
        private System.Windows.Forms.RadioButton RseniorButton;
        private System.Windows.Forms.RadioButton Rjuniorbutton;
        private System.Windows.Forms.RadioButton RsophomoreButton;
        private System.Windows.Forms.RadioButton RfreshmanButton;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Label label2;
    }
}

