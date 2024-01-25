namespace MTGColorTest
{
    partial class MainWindow
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
            this.mainSubtitle = new System.Windows.Forms.Label();
            this.mainTitle = new System.Windows.Forms.Label();
            this.beginButton = new System.Windows.Forms.Button();
            this.titleScreen = new System.Windows.Forms.Panel();
            this.testPanel = new System.Windows.Forms.Panel();
            this.slash = new System.Windows.Forms.Label();
            this.attemptsText = new System.Windows.Forms.Label();
            this.correctText = new System.Windows.Forms.Label();
            this.scoretext = new System.Windows.Forms.Label();
            this.colorGuess = new System.Windows.Forms.TextBox();
            this.leftColor = new System.Windows.Forms.PictureBox();
            this.rightColor = new System.Windows.Forms.PictureBox();
            this.middleColor = new System.Windows.Forms.PictureBox();
            this.reward = new System.Windows.Forms.Label();
            this.titleScreen.SuspendLayout();
            this.testPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleColor)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSubtitle
            // 
            this.mainSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainSubtitle.AutoSize = true;
            this.mainSubtitle.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainSubtitle.Location = new System.Drawing.Point(240, 62);
            this.mainSubtitle.Name = "mainSubtitle";
            this.mainSubtitle.Size = new System.Drawing.Size(440, 59);
            this.mainSubtitle.TabIndex = 0;
            this.mainSubtitle.Text = "Magic: the Gathering";
            this.mainSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainTitle
            // 
            this.mainTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Cambria", 75.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(202, 105);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(516, 118);
            this.mainTitle.TabIndex = 1;
            this.mainTitle.Text = "Color Test";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // beginButton
            // 
            this.beginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.beginButton.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.Location = new System.Drawing.Point(370, 270);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(196, 87);
            this.beginButton.TabIndex = 2;
            this.beginButton.Text = "BEGIN";
            this.beginButton.UseVisualStyleBackColor = false;
            this.beginButton.Click += new System.EventHandler(this.Beginbutton_Click);
            // 
            // titleScreen
            // 
            this.titleScreen.Controls.Add(this.beginButton);
            this.titleScreen.Controls.Add(this.mainSubtitle);
            this.titleScreen.Controls.Add(this.mainTitle);
            this.titleScreen.Location = new System.Drawing.Point(12, 12);
            this.titleScreen.Name = "titleScreen";
            this.titleScreen.Size = new System.Drawing.Size(920, 417);
            this.titleScreen.TabIndex = 3;
            // 
            // testPanel
            // 
            this.testPanel.Controls.Add(this.reward);
            this.testPanel.Controls.Add(this.slash);
            this.testPanel.Controls.Add(this.attemptsText);
            this.testPanel.Controls.Add(this.correctText);
            this.testPanel.Controls.Add(this.scoretext);
            this.testPanel.Controls.Add(this.colorGuess);
            this.testPanel.Controls.Add(this.leftColor);
            this.testPanel.Controls.Add(this.rightColor);
            this.testPanel.Controls.Add(this.middleColor);
            this.testPanel.Location = new System.Drawing.Point(12, 12);
            this.testPanel.Name = "testPanel";
            this.testPanel.Size = new System.Drawing.Size(920, 417);
            this.testPanel.TabIndex = 3;
            // 
            // slash
            // 
            this.slash.AutoSize = true;
            this.slash.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slash.Location = new System.Drawing.Point(506, 336);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(49, 57);
            this.slash.TabIndex = 7;
            this.slash.Text = "/";
            // 
            // attemptsText
            // 
            this.attemptsText.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attemptsText.Location = new System.Drawing.Point(543, 336);
            this.attemptsText.Name = "attemptsText";
            this.attemptsText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.attemptsText.Size = new System.Drawing.Size(107, 57);
            this.attemptsText.TabIndex = 6;
            this.attemptsText.Text = "0";
            this.attemptsText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // correctText
            // 
            this.correctText.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctText.Location = new System.Drawing.Point(410, 336);
            this.correctText.Name = "correctText";
            this.correctText.Size = new System.Drawing.Size(113, 57);
            this.correctText.TabIndex = 5;
            this.correctText.Text = "0";
            this.correctText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Location = new System.Drawing.Point(278, 336);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(150, 57);
            this.scoretext.TabIndex = 4;
            this.scoretext.Text = "Score:";
            // 
            // colorGuess
            // 
            this.colorGuess.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorGuess.Location = new System.Drawing.Point(290, 200);
            this.colorGuess.MaxLength = 10;
            this.colorGuess.Name = "colorGuess";
            this.colorGuess.Size = new System.Drawing.Size(340, 41);
            this.colorGuess.TabIndex = 3;
            this.colorGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colorGuess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorGuess_KeyDown);
            // 
            // leftColor
            // 
            this.leftColor.Location = new System.Drawing.Point(290, 66);
            this.leftColor.Name = "leftColor";
            this.leftColor.Size = new System.Drawing.Size(100, 100);
            this.leftColor.TabIndex = 2;
            this.leftColor.TabStop = false;
            // 
            // rightColor
            // 
            this.rightColor.Location = new System.Drawing.Point(530, 66);
            this.rightColor.Name = "rightColor";
            this.rightColor.Size = new System.Drawing.Size(100, 100);
            this.rightColor.TabIndex = 1;
            this.rightColor.TabStop = false;
            // 
            // middleColor
            // 
            this.middleColor.Location = new System.Drawing.Point(410, 66);
            this.middleColor.Name = "middleColor";
            this.middleColor.Size = new System.Drawing.Size(100, 100);
            this.middleColor.TabIndex = 0;
            this.middleColor.TabStop = false;
            // 
            // reward
            // 
            this.reward.AutoSize = true;
            this.reward.Font = new System.Drawing.Font("Cambria", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reward.Location = new System.Drawing.Point(349, 255);
            this.reward.Name = "reward";
            this.reward.Size = new System.Drawing.Size(222, 65);
            this.reward.TabIndex = 8;
            this.reward.Text = "Correct!";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 441);
            this.Controls.Add(this.testPanel);
            this.Controls.Add(this.titleScreen);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.titleScreen.ResumeLayout(false);
            this.titleScreen.PerformLayout();
            this.testPanel.ResumeLayout(false);
            this.testPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainSubtitle;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Panel titleScreen;
        private System.Windows.Forms.Panel testPanel;
        private System.Windows.Forms.PictureBox leftColor;
        private System.Windows.Forms.PictureBox rightColor;
        private System.Windows.Forms.PictureBox middleColor;
        private System.Windows.Forms.TextBox colorGuess;
        private System.Windows.Forms.Label attemptsText;
        private System.Windows.Forms.Label correctText;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Label slash;
        private System.Windows.Forms.Label reward;
    }
}

