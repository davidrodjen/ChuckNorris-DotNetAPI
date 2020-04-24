namespace ChuckJoke
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
            this.getJokeBtn = new System.Windows.Forms.Button();
            this.jokeTxt = new System.Windows.Forms.TextBox();
            this.categoryBx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getJokeBtn
            // 
            this.getJokeBtn.Location = new System.Drawing.Point(12, 41);
            this.getJokeBtn.Name = "getJokeBtn";
            this.getJokeBtn.Size = new System.Drawing.Size(122, 50);
            this.getJokeBtn.TabIndex = 0;
            this.getJokeBtn.Text = "Get A Joke!";
            this.getJokeBtn.UseVisualStyleBackColor = true;
            this.getJokeBtn.Click += new System.EventHandler(this.getJokeBtn_ClickAsync);
            // 
            // jokeTxt
            // 
            this.jokeTxt.Enabled = false;
            this.jokeTxt.Location = new System.Drawing.Point(12, 119);
            this.jokeTxt.Name = "jokeTxt";
            this.jokeTxt.Size = new System.Drawing.Size(228, 20);
            this.jokeTxt.TabIndex = 1;
            // 
            // categoryBx
            // 
            this.categoryBx.FormattingEnabled = true;
            this.categoryBx.Location = new System.Drawing.Point(156, 70);
            this.categoryBx.Name = "categoryBx";
            this.categoryBx.Size = new System.Drawing.Size(168, 21);
            this.categoryBx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Joke Categories:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryBx);
            this.Controls.Add(this.jokeTxt);
            this.Controls.Add(this.getJokeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getJokeBtn;
        private System.Windows.Forms.TextBox jokeTxt;
        private System.Windows.Forms.ComboBox categoryBx;
        private System.Windows.Forms.Label label1;
    }
}

