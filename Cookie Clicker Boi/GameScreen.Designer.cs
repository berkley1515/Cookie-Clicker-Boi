namespace Cookie_Clicker_Boi
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cookieButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cookieButton
            // 
            this.cookieButton.BackColor = System.Drawing.Color.Transparent;
            this.cookieButton.BackgroundImage = global::Cookie_Clicker_Boi.Properties.Resources.Cookie_Download_PNG;
            this.cookieButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cookieButton.FlatAppearance.BorderSize = 0;
            this.cookieButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cookieButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cookieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cookieButton.Location = new System.Drawing.Point(514, 318);
            this.cookieButton.Name = "cookieButton";
            this.cookieButton.Size = new System.Drawing.Size(226, 217);
            this.cookieButton.TabIndex = 0;
            this.cookieButton.UseVisualStyleBackColor = false;
            this.cookieButton.Click += new System.EventHandler(this.cookieButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Pixel Tandysoft", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(-3, 36);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(1336, 71);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Cookies: ";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cookie_Clicker_Boi.Properties.Resources.cookieBackground;
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.cookieButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1336, 768);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cookieButton;
        private System.Windows.Forms.Label ScoreLabel;
    }
}
