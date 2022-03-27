namespace Aquaria_Project
{
    partial class Aquarium
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
            this.GuessingGameStart = new System.Windows.Forms.Button();
            this.FlappyFishStart = new System.Windows.Forms.Button();
            this.HuntingGameStart = new System.Windows.Forms.Button();
            this.TriviaGameStart = new System.Windows.Forms.Button();
            this.CollectionBookOpen = new System.Windows.Forms.Button();
            this.BuyFishStore = new System.Windows.Forms.Button();
            this.MysteryFishButton = new System.Windows.Forms.Button();
            this.DecortationStore = new System.Windows.Forms.Button();
            this.SandColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuessingGameStart
            // 
            this.GuessingGameStart.Location = new System.Drawing.Point(26, 24);
            this.GuessingGameStart.Name = "GuessingGameStart";
            this.GuessingGameStart.Size = new System.Drawing.Size(145, 50);
            this.GuessingGameStart.TabIndex = 0;
            this.GuessingGameStart.Text = "Guessing Game";
            this.GuessingGameStart.UseVisualStyleBackColor = true;
            this.GuessingGameStart.Click += new System.EventHandler(this.GuessingGameStart_Click);
            // 
            // FlappyFishStart
            // 
            this.FlappyFishStart.Location = new System.Drawing.Point(26, 100);
            this.FlappyFishStart.Name = "FlappyFishStart";
            this.FlappyFishStart.Size = new System.Drawing.Size(145, 50);
            this.FlappyFishStart.TabIndex = 1;
            this.FlappyFishStart.Text = "Flappy Fish";
            this.FlappyFishStart.UseVisualStyleBackColor = true;
            // 
            // HuntingGameStart
            // 
            this.HuntingGameStart.Location = new System.Drawing.Point(26, 176);
            this.HuntingGameStart.Name = "HuntingGameStart";
            this.HuntingGameStart.Size = new System.Drawing.Size(145, 50);
            this.HuntingGameStart.TabIndex = 2;
            this.HuntingGameStart.Text = "Hunting Game";
            this.HuntingGameStart.UseVisualStyleBackColor = true;
            // 
            // TriviaGameStart
            // 
            this.TriviaGameStart.Location = new System.Drawing.Point(26, 256);
            this.TriviaGameStart.Name = "TriviaGameStart";
            this.TriviaGameStart.Size = new System.Drawing.Size(145, 50);
            this.TriviaGameStart.TabIndex = 3;
            this.TriviaGameStart.Text = "Trivia Game";
            this.TriviaGameStart.UseVisualStyleBackColor = true;
            // 
            // CollectionBookOpen
            // 
            this.CollectionBookOpen.Location = new System.Drawing.Point(810, 51);
            this.CollectionBookOpen.Name = "CollectionBookOpen";
            this.CollectionBookOpen.Size = new System.Drawing.Size(141, 46);
            this.CollectionBookOpen.TabIndex = 4;
            this.CollectionBookOpen.Text = "Collection Book";
            this.CollectionBookOpen.UseVisualStyleBackColor = true;
            this.CollectionBookOpen.Click += new System.EventHandler(this.CollectionBookOpen_Click);
            // 
            // BuyFishStore
            // 
            this.BuyFishStore.Location = new System.Drawing.Point(810, 126);
            this.BuyFishStore.Name = "BuyFishStore";
            this.BuyFishStore.Size = new System.Drawing.Size(141, 46);
            this.BuyFishStore.TabIndex = 5;
            this.BuyFishStore.Text = "Buy Fish";
            this.BuyFishStore.UseVisualStyleBackColor = true;
            this.BuyFishStore.Click += new System.EventHandler(this.button1_Click);
            // 
            // MysteryFishButton
            // 
            this.MysteryFishButton.Location = new System.Drawing.Point(810, 192);
            this.MysteryFishButton.Name = "MysteryFishButton";
            this.MysteryFishButton.Size = new System.Drawing.Size(141, 46);
            this.MysteryFishButton.TabIndex = 6;
            this.MysteryFishButton.Text = "Mystery Fish";
            this.MysteryFishButton.UseVisualStyleBackColor = true;
            // 
            // DecortationStore
            // 
            this.DecortationStore.Location = new System.Drawing.Point(810, 260);
            this.DecortationStore.Name = "DecortationStore";
            this.DecortationStore.Size = new System.Drawing.Size(141, 46);
            this.DecortationStore.TabIndex = 7;
            this.DecortationStore.Text = "Decoration";
            this.DecortationStore.UseVisualStyleBackColor = true;
            // 
            // SandColorButton
            // 
            this.SandColorButton.Location = new System.Drawing.Point(810, 339);
            this.SandColorButton.Name = "SandColorButton";
            this.SandColorButton.Size = new System.Drawing.Size(141, 46);
            this.SandColorButton.TabIndex = 8;
            this.SandColorButton.Text = "Sand Color";
            this.SandColorButton.UseVisualStyleBackColor = true;
            // 
            // Aquarium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 578);
            this.Controls.Add(this.SandColorButton);
            this.Controls.Add(this.DecortationStore);
            this.Controls.Add(this.MysteryFishButton);
            this.Controls.Add(this.BuyFishStore);
            this.Controls.Add(this.CollectionBookOpen);
            this.Controls.Add(this.TriviaGameStart);
            this.Controls.Add(this.HuntingGameStart);
            this.Controls.Add(this.FlappyFishStart);
            this.Controls.Add(this.GuessingGameStart);
            this.Name = "Aquarium";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GuessingGameStart;
        private System.Windows.Forms.Button FlappyFishStart;
        private System.Windows.Forms.Button HuntingGameStart;
        private System.Windows.Forms.Button TriviaGameStart;
        private System.Windows.Forms.Button CollectionBookOpen;
        private System.Windows.Forms.Button BuyFishStore;
        private System.Windows.Forms.Button MysteryFishButton;
        private System.Windows.Forms.Button DecortationStore;
        private System.Windows.Forms.Button SandColorButton;
    }
}

