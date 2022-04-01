namespace Aquaria_Project
{
    partial class badGuessForm
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
            this.sadFishPicture = new System.Windows.Forms.PictureBox();
            this.badBoxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sadFishPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // sadFishPicture
            // 
            this.sadFishPicture.Image = global::Aquaria_Project.Properties.Resources.sadfish;
            this.sadFishPicture.Location = new System.Drawing.Point(85, 24);
            this.sadFishPicture.Name = "sadFishPicture";
            this.sadFishPicture.Size = new System.Drawing.Size(191, 164);
            this.sadFishPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sadFishPicture.TabIndex = 0;
            this.sadFishPicture.TabStop = false;
            // 
            // badBoxLabel
            // 
            this.badBoxLabel.AutoSize = true;
            this.badBoxLabel.BackColor = System.Drawing.Color.Transparent;
            this.badBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badBoxLabel.Location = new System.Drawing.Point(12, 200);
            this.badBoxLabel.Name = "badBoxLabel";
            this.badBoxLabel.Size = new System.Drawing.Size(378, 20);
            this.badBoxLabel.TabIndex = 1;
            this.badBoxLabel.Text = "Sorry, this was a bad box. The game will reset.";
            // 
            // badGuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquaria_Project.Properties.Resources.waterGuessingGame;
            this.ClientSize = new System.Drawing.Size(431, 255);
            this.Controls.Add(this.badBoxLabel);
            this.Controls.Add(this.sadFishPicture);
            this.Name = "badGuessForm";
            this.Text = "badGuessForm";
            ((System.ComponentModel.ISupportInitialize)(this.sadFishPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sadFishPicture;
        private System.Windows.Forms.Label badBoxLabel;
    }
}