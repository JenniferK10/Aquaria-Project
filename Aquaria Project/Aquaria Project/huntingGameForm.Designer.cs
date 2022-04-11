namespace Aquaria_Project
{
    partial class huntingGameForm
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
            this.lab_miss = new System.Windows.Forms.Label();
            this.lab_hunt = new System.Windows.Forms.Label();
            this.lab_score = new System.Windows.Forms.Label();
            this.lab_timer = new System.Windows.Forms.Label();
            this.lab_over = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fish1 = new System.Windows.Forms.PictureBox();
            this.fish2 = new System.Windows.Forms.PictureBox();
            this.fish3 = new System.Windows.Forms.PictureBox();
            this.fish4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fish5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fish1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish5)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_miss
            // 
            this.lab_miss.AutoSize = true;
            this.lab_miss.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_miss.Location = new System.Drawing.Point(8, -1);
            this.lab_miss.Name = "lab_miss";
            this.lab_miss.Size = new System.Drawing.Size(245, 56);
            this.lab_miss.TabIndex = 5;
            this.lab_miss.Text = "Missed: 0";
            // 
            // lab_hunt
            // 
            this.lab_hunt.AutoSize = true;
            this.lab_hunt.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_hunt.Location = new System.Drawing.Point(259, -1);
            this.lab_hunt.Name = "lab_hunt";
            this.lab_hunt.Size = new System.Drawing.Size(246, 56);
            this.lab_hunt.TabIndex = 6;
            this.lab_hunt.Text = "Hunted: 0";
            // 
            // lab_score
            // 
            this.lab_score.AutoSize = true;
            this.lab_score.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_score.Location = new System.Drawing.Point(524, -1);
            this.lab_score.Name = "lab_score";
            this.lab_score.Size = new System.Drawing.Size(215, 56);
            this.lab_score.TabIndex = 7;
            this.lab_score.Text = "Score: 0";
            // 
            // lab_timer
            // 
            this.lab_timer.AutoSize = true;
            this.lab_timer.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_timer.Location = new System.Drawing.Point(801, -1);
            this.lab_timer.Name = "lab_timer";
            this.lab_timer.Size = new System.Drawing.Size(212, 56);
            this.lab_timer.TabIndex = 3;
            this.lab_timer.Text = "Timer: 0";
            // 
            // lab_over
            // 
            this.lab_over.AutoSize = true;
            this.lab_over.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_over.Location = new System.Drawing.Point(389, 238);
            this.lab_over.Name = "lab_over";
            this.lab_over.Size = new System.Drawing.Size(346, 65);
            this.lab_over.TabIndex = 4;
            this.lab_over.Text = "Game Over!";
            this.lab_over.Visible = false;
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(342, 297);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(157, 50);
            this.Restart.TabIndex = 9;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click_1);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(505, 297);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(157, 50);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Visible = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fish1
            // 
            this.fish1.Image = global::Aquaria_Project.Properties.Resources.clown;
            this.fish1.Location = new System.Drawing.Point(732, 287);
            this.fish1.Name = "fish1";
            this.fish1.Size = new System.Drawing.Size(156, 85);
            this.fish1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fish1.TabIndex = 7;
            this.fish1.TabStop = false;
            this.fish1.Click += new System.EventHandler(this.fish1_Click);
            // 
            // fish2
            // 
            this.fish2.Image = global::Aquaria_Project.Properties.Resources.fish11;
            this.fish2.Location = new System.Drawing.Point(35, 320);
            this.fish2.Name = "fish2";
            this.fish2.Size = new System.Drawing.Size(184, 157);
            this.fish2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fish2.TabIndex = 6;
            this.fish2.TabStop = false;
            this.fish2.Click += new System.EventHandler(this.fish2_Click_1);
            // 
            // fish3
            // 
            this.fish3.Image = global::Aquaria_Project.Properties.Resources.crop;
            this.fish3.Location = new System.Drawing.Point(558, 127);
            this.fish3.Name = "fish3";
            this.fish3.Size = new System.Drawing.Size(216, 108);
            this.fish3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fish3.TabIndex = 5;
            this.fish3.TabStop = false;
            this.fish3.Click += new System.EventHandler(this.fish3_Click_1);
            // 
            // fish4
            // 
            this.fish4.Image = global::Aquaria_Project.Properties.Resources.fish5;
            this.fish4.Location = new System.Drawing.Point(81, 12);
            this.fish4.Name = "fish4";
            this.fish4.Size = new System.Drawing.Size(184, 157);
            this.fish4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fish4.TabIndex = 4;
            this.fish4.TabStop = false;
            this.fish4.Click += new System.EventHandler(this.fish4_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aquaria_Project.Properties.Resources.sandBrown;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 471);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1032, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Aquaria_Project.Properties.Resources.background;
            this.pictureBox2.Location = new System.Drawing.Point(918, 453);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // fish5
            // 
            this.fish5.Image = global::Aquaria_Project.Properties.Resources.cardinal;
            this.fish5.Location = new System.Drawing.Point(255, 252);
            this.fish5.Name = "fish5";
            this.fish5.Size = new System.Drawing.Size(128, 71);
            this.fish5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fish5.TabIndex = 13;
            this.fish5.TabStop = false;
            this.fish5.Click += new System.EventHandler(this.fish5_Click);
            // 
            // huntingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1028, 594);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.lab_over);
            this.Controls.Add(this.fish5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lab_score);
            this.Controls.Add(this.lab_hunt);
            this.Controls.Add(this.lab_miss);
            this.Controls.Add(this.fish1);
            this.Controls.Add(this.fish2);
            this.Controls.Add(this.fish3);
            this.Controls.Add(this.fish4);
            this.Controls.Add(this.lab_timer);
            this.Name = "huntingGameForm";
            this.Text = "huntingGameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.huntingGameForm_FormClosing);
            this.Load += new System.EventHandler(this.huntingGameForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.huntingGameForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.fish1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_miss;
        private System.Windows.Forms.Label lab_hunt;
        private System.Windows.Forms.Label lab_score;
        private System.Windows.Forms.Label lab_timer;
        private System.Windows.Forms.PictureBox fish4;
        private System.Windows.Forms.PictureBox fish3;
        private System.Windows.Forms.PictureBox fish2;
        private System.Windows.Forms.PictureBox fish1;
        private System.Windows.Forms.Label lab_over;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox fish5;
    }
}