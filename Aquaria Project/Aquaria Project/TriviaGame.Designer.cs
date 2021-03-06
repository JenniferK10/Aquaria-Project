namespace Aquaria_Project
{
    partial class TriviaGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriviaGame));
            this.questionBox = new System.Windows.Forms.TextBox();
            this.ButtonA = new System.Windows.Forms.Button();
            this.ButtonB = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.BackColor = System.Drawing.SystemColors.Control;
            this.questionBox.Location = new System.Drawing.Point(76, 93);
            this.questionBox.Margin = new System.Windows.Forms.Padding(2);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(625, 26);
            this.questionBox.TabIndex = 0;
            this.questionBox.Text = "Question";
            // 
            // ButtonA
            // 
            this.ButtonA.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonA.Location = new System.Drawing.Point(92, 176);
            this.ButtonA.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonA.Name = "ButtonA";
            this.ButtonA.Size = new System.Drawing.Size(586, 64);
            this.ButtonA.TabIndex = 1;
            this.ButtonA.Text = "Choice A";
            this.ButtonA.UseVisualStyleBackColor = false;
            this.ButtonA.Click += new System.EventHandler(this.ButtonA_Click);
            // 
            // ButtonB
            // 
            this.ButtonB.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonB.Location = new System.Drawing.Point(92, 274);
            this.ButtonB.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonB.Name = "ButtonB";
            this.ButtonB.Size = new System.Drawing.Size(586, 64);
            this.ButtonB.TabIndex = 2;
            this.ButtonB.Text = "Choice B";
            this.ButtonB.UseVisualStyleBackColor = false;
            this.ButtonB.Click += new System.EventHandler(this.ButtonB_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 18);
            this.button3.TabIndex = 10;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.Control;
            this.nextButton.Location = new System.Drawing.Point(589, 504);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(164, 54);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Start/Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click_1);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(0, 0);
            this.quitButton.Margin = new System.Windows.Forms.Padding(2);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(56, 18);
            this.quitButton.TabIndex = 7;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.Control;
            this.resetButton.Location = new System.Drawing.Point(32, 504);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(164, 54);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // ButtonC
            // 
            this.ButtonC.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonC.Location = new System.Drawing.Point(92, 372);
            this.ButtonC.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(586, 64);
            this.ButtonC.TabIndex = 9;
            this.ButtonC.Text = "Choice C";
            this.ButtonC.UseVisualStyleBackColor = false;
            this.ButtonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.Control;
            this.ExitButton.Location = new System.Drawing.Point(309, 504);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(164, 54);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TriviaGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 587);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ButtonC);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ButtonB);
            this.Controls.Add(this.ButtonA);
            this.Controls.Add(this.questionBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TriviaGame";
            this.Text = "TriviaGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TriviaGame_FormClosing);
            this.Load += new System.EventHandler(this.TriviaGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.Button ButtonA;
        private System.Windows.Forms.Button ButtonB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Button ExitButton;
    }
}