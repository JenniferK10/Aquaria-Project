
namespace Flappy_Fish
{
    partial class FlappyFish
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyFish));
            this.score1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Restart = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.PipeTopHigh = new System.Windows.Forms.PictureBox();
            this.Fish = new System.Windows.Forms.PictureBox();
            this.PipeBottomHigh = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.PipeBottom = new System.Windows.Forms.PictureBox();
            this.PipeTopLow = new System.Windows.Forms.PictureBox();
            this.PipeBottomLow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTopHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottomHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTopLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottomLow)).BeginInit();
            this.SuspendLayout();
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.Color.Transparent;
            this.score1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.ForeColor = System.Drawing.Color.Black;
            this.score1.Location = new System.Drawing.Point(2, 8);
            this.score1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(222, 59);
            this.score1.TabIndex = 4;
            this.score1.Text = "Score: 0 ";
            this.score1.Click += new System.EventHandler(this.score1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Restart.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Restart.Location = new System.Drawing.Point(43, 257);
            this.Restart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(165, 73);
            this.Restart.TabIndex = 5;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(252, 257);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(165, 73);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Ground
            // 
            this.Ground.Image = global::Aquaria_Project.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-9, 525);
            this.Ground.Margin = new System.Windows.Forms.Padding(2);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(492, 73);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 2;
            this.Ground.TabStop = false;
            // 
            // PipeTopHigh
            // 
            this.PipeTopHigh.BackColor = System.Drawing.Color.Transparent;
            this.PipeTopHigh.Image = global::Aquaria_Project.Properties.Resources.pipedown;
            this.PipeTopHigh.Location = new System.Drawing.Point(385, -148);
            this.PipeTopHigh.Margin = new System.Windows.Forms.Padding(2);
            this.PipeTopHigh.Name = "PipeTopHigh";
            this.PipeTopHigh.Size = new System.Drawing.Size(79, 229);
            this.PipeTopHigh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTopHigh.TabIndex = 7;
            this.PipeTopHigh.TabStop = false;
            this.PipeTopHigh.Visible = false;
            // 
            // Fish
            // 
            this.Fish.BackColor = System.Drawing.Color.Transparent;
            this.Fish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Fish.Image = global::Aquaria_Project.Properties.Resources.bird;
            this.Fish.Location = new System.Drawing.Point(97, 187);
            this.Fish.Margin = new System.Windows.Forms.Padding(2);
            this.Fish.Name = "Fish";
            this.Fish.Size = new System.Drawing.Size(45, 33);
            this.Fish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fish.TabIndex = 1;
            this.Fish.TabStop = false;
            this.Fish.Click += new System.EventHandler(this.Fish_Click);
            // 
            // PipeBottomHigh
            // 
            this.PipeBottomHigh.Image = global::Aquaria_Project.Properties.Resources.pipe;
            this.PipeBottomHigh.Location = new System.Drawing.Point(385, 214);
            this.PipeBottomHigh.Margin = new System.Windows.Forms.Padding(2);
            this.PipeBottomHigh.Name = "PipeBottomHigh";
            this.PipeBottomHigh.Size = new System.Drawing.Size(79, 324);
            this.PipeBottomHigh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottomHigh.TabIndex = 3;
            this.PipeBottomHigh.TabStop = false;
            this.PipeBottomHigh.Visible = false;
            this.PipeBottomHigh.Click += new System.EventHandler(this.GameTimerEvent);
            // 
            // PipeTop
            // 
            this.PipeTop.BackColor = System.Drawing.Color.Transparent;
            this.PipeTop.Image = global::Aquaria_Project.Properties.Resources.pipedown;
            this.PipeTop.Location = new System.Drawing.Point(385, -9);
            this.PipeTop.Margin = new System.Windows.Forms.Padding(2);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(79, 229);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 0;
            this.PipeTop.TabStop = false;
            // 
            // PipeBottom
            // 
            this.PipeBottom.Image = global::Aquaria_Project.Properties.Resources.pipe;
            this.PipeBottom.Location = new System.Drawing.Point(385, 353);
            this.PipeBottom.Margin = new System.Windows.Forms.Padding(2);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(79, 312);
            this.PipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom.TabIndex = 8;
            this.PipeBottom.TabStop = false;
            this.PipeBottom.Click += new System.EventHandler(this.PipeBottom_Click);
            // 
            // PipeTopLow
            // 
            this.PipeTopLow.BackColor = System.Drawing.Color.Transparent;
            this.PipeTopLow.Image = global::Aquaria_Project.Properties.Resources.pipedown;
            this.PipeTopLow.Location = new System.Drawing.Point(385, -9);
            this.PipeTopLow.Margin = new System.Windows.Forms.Padding(2);
            this.PipeTopLow.Name = "PipeTopLow";
            this.PipeTopLow.Size = new System.Drawing.Size(79, 339);
            this.PipeTopLow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTopLow.TabIndex = 9;
            this.PipeTopLow.TabStop = false;
            this.PipeTopLow.Visible = false;
            // 
            // PipeBottomLow
            // 
            this.PipeBottomLow.Image = global::Aquaria_Project.Properties.Resources.pipe;
            this.PipeBottomLow.Location = new System.Drawing.Point(385, 463);
            this.PipeBottomLow.Margin = new System.Windows.Forms.Padding(2);
            this.PipeBottomLow.Name = "PipeBottomLow";
            this.PipeBottomLow.Size = new System.Drawing.Size(79, 237);
            this.PipeBottomLow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottomLow.TabIndex = 10;
            this.PipeBottomLow.TabStop = false;
            this.PipeBottomLow.Visible = false;
            // 
            // FlappyFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(462, 590);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PipeTopHigh);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Fish);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.PipeBottomLow);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.PipeTopLow);
            this.Controls.Add(this.PipeBottom);
            this.Controls.Add(this.PipeBottomHigh);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FlappyFish";
            this.Text = "Flappy Fish";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyFish_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FlappyFish_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTopHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottomHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTopLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottomLow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox Fish;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox PipeBottomHigh;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox PipeBottom;
        private System.Windows.Forms.PictureBox PipeTopHigh;
        private System.Windows.Forms.PictureBox PipeBottomLow;
        private System.Windows.Forms.PictureBox PipeTopLow;
    }
}

