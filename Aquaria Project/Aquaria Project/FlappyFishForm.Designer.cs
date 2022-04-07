
namespace Aquaria_Project
{
    partial class FlappyFishForm
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
            this.Ground = new System.Windows.Forms.PictureBox();
            this.PipeTopHigh = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.Fish = new System.Windows.Forms.PictureBox();
            this.score1 = new System.Windows.Forms.Label();
            this.PipeBottomLow = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.PipeTopLow = new System.Windows.Forms.PictureBox();
            this.PipeBottom = new System.Windows.Forms.PictureBox();
            this.PipeBottomHigh = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTopHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottomLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTopLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottomHigh)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground
            // 
            this.Ground.Image = global::Aquaria_Project.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-15, 545);
            this.Ground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(492, 73);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 13;
            this.Ground.TabStop = false;
            // 
            // PipeTopHigh
            // 
            this.PipeTopHigh.BackColor = System.Drawing.Color.Transparent;
            this.PipeTopHigh.Image = global::Aquaria_Project.Properties.Resources.pipedown;
            this.PipeTopHigh.Location = new System.Drawing.Point(379, -129);
            this.PipeTopHigh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PipeTopHigh.Name = "PipeTopHigh";
            this.PipeTopHigh.Size = new System.Drawing.Size(79, 229);
            this.PipeTopHigh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTopHigh.TabIndex = 18;
            this.PipeTopHigh.TabStop = false;
            this.PipeTopHigh.Visible = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(246, 276);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(165, 73);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Visible = false;
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Restart.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Restart.Location = new System.Drawing.Point(37, 276);
            this.Restart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(165, 73);
            this.Restart.TabIndex = 16;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Fish
            // 
            this.Fish.BackColor = System.Drawing.Color.Transparent;
            this.Fish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Fish.Image = global::Aquaria_Project.Properties.Resources.bird;
            this.Fish.Location = new System.Drawing.Point(91, 207);
            this.Fish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Fish.Name = "Fish";
            this.Fish.Size = new System.Drawing.Size(45, 33);
            this.Fish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fish.TabIndex = 12;
            this.Fish.TabStop = false;
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.Color.Transparent;
            this.score1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.ForeColor = System.Drawing.Color.Black;
            this.score1.Location = new System.Drawing.Point(-4, 27);
            this.score1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(222, 59);
            this.score1.TabIndex = 15;
            this.score1.Text = "Score: 0 ";
            // 
            // PipeBottomLow
            // 
            this.PipeBottomLow.Image = global::Aquaria_Project.Properties.Resources.pipe;
            this.PipeBottomLow.Location = new System.Drawing.Point(379, 482);
            this.PipeBottomLow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PipeBottomLow.Name = "PipeBottomLow";
            this.PipeBottomLow.Size = new System.Drawing.Size(79, 237);
            this.PipeBottomLow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottomLow.TabIndex = 21;
            this.PipeBottomLow.TabStop = false;
            this.PipeBottomLow.Visible = false;
            // 
            // PipeTop
            // 
            this.PipeTop.BackColor = System.Drawing.Color.Transparent;
            this.PipeTop.Image = global::Aquaria_Project.Properties.Resources.pipedown;
            this.PipeTop.Location = new System.Drawing.Point(379, 10);
            this.PipeTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(79, 229);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 11;
            this.PipeTop.TabStop = false;
            // 
            // PipeTopLow
            // 
            this.PipeTopLow.BackColor = System.Drawing.Color.Transparent;
            this.PipeTopLow.Image = global::Aquaria_Project.Properties.Resources.pipedown;
            this.PipeTopLow.Location = new System.Drawing.Point(379, 10);
            this.PipeTopLow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PipeTopLow.Name = "PipeTopLow";
            this.PipeTopLow.Size = new System.Drawing.Size(79, 339);
            this.PipeTopLow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTopLow.TabIndex = 20;
            this.PipeTopLow.TabStop = false;
            this.PipeTopLow.Visible = false;
            // 
            // PipeBottom
            // 
            this.PipeBottom.Image = global::Aquaria_Project.Properties.Resources.pipe;
            this.PipeBottom.Location = new System.Drawing.Point(379, 372);
            this.PipeBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(79, 312);
            this.PipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom.TabIndex = 19;
            this.PipeBottom.TabStop = false;
            // 
            // PipeBottomHigh
            // 
            this.PipeBottomHigh.Image = global::Aquaria_Project.Properties.Resources.pipe;
            this.PipeBottomHigh.Location = new System.Drawing.Point(379, 233);
            this.PipeBottomHigh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PipeBottomHigh.Name = "PipeBottomHigh";
            this.PipeBottomHigh.Size = new System.Drawing.Size(79, 324);
            this.PipeBottomHigh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottomHigh.TabIndex = 14;
            this.PipeBottomHigh.TabStop = false;
            this.PipeBottomHigh.Visible = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // FlappyFishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FlappyFishForm";
            this.Text = "Flappy Fish";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlappyFishForm_FormClosing);
            this.Load += new System.EventHandler(this.FlappyFishForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpaceKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTopHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottomLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTopLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottomHigh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox PipeTopHigh;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.PictureBox Fish;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.PictureBox PipeBottomLow;
        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox PipeTopLow;
        private System.Windows.Forms.PictureBox PipeBottom;
        private System.Windows.Forms.PictureBox PipeBottomHigh;
        private System.Windows.Forms.Timer GameTimer;
    }
}