namespace Survival
{
    partial class FormGameOverMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameOverMenu));
            this.pictureBoxSkull = new System.Windows.Forms.PictureBox();
            this.timerSkull = new System.Windows.Forms.Timer(this.components);
            this.labelQuit = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.labelRestart = new System.Windows.Forms.Label();
            this.labelLeaders = new System.Windows.Forms.Label();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.labelMusic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkull)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSkull
            // 
            this.pictureBoxSkull.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSkull.Image = global::Survival.Properties.Resources.skullBlack;
            this.pictureBoxSkull.Location = new System.Drawing.Point(40, 31);
            this.pictureBoxSkull.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSkull.Name = "pictureBoxSkull";
            this.pictureBoxSkull.Size = new System.Drawing.Size(303, 337);
            this.pictureBoxSkull.TabIndex = 0;
            this.pictureBoxSkull.TabStop = false;
            // 
            // labelQuit
            // 
            this.labelQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuit.BackColor = System.Drawing.Color.Transparent;
            this.labelQuit.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelQuit.Image = global::Survival.Properties.Resources.longBoard;
            this.labelQuit.Location = new System.Drawing.Point(231, 488);
            this.labelQuit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuit.Name = "labelQuit";
            this.labelQuit.Size = new System.Drawing.Size(187, 46);
            this.labelQuit.TabIndex = 1;
            this.labelQuit.Text = "Quit";
            this.labelQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelQuit.MouseEnter += new System.EventHandler(this.labelExit_MouseEnter);
            this.labelQuit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Image = global::Survival.Properties.Resources.longBoardRed;
            this.labelScore.Location = new System.Drawing.Point(230, 367);
            this.labelScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(187, 46);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score: 0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRecord
            // 
            this.labelRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRecord.BackColor = System.Drawing.Color.Transparent;
            this.labelRecord.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelRecord.ForeColor = System.Drawing.Color.Yellow;
            this.labelRecord.Location = new System.Drawing.Point(437, 578);
            this.labelRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(187, 46);
            this.labelRecord.TabIndex = 3;
            this.labelRecord.Text = "New Record !";
            this.labelRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRecord.Visible = false;
            // 
            // labelRestart
            // 
            this.labelRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRestart.BackColor = System.Drawing.Color.Transparent;
            this.labelRestart.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelRestart.Image = global::Survival.Properties.Resources.longBoard;
            this.labelRestart.Location = new System.Drawing.Point(230, 427);
            this.labelRestart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRestart.Name = "labelRestart";
            this.labelRestart.Size = new System.Drawing.Size(187, 46);
            this.labelRestart.TabIndex = 4;
            this.labelRestart.Text = "Restart";
            this.labelRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRestart.Click += new System.EventHandler(this.labelRestart_Click);
            this.labelRestart.MouseEnter += new System.EventHandler(this.labelRestart_MouseEnter);
            this.labelRestart.MouseLeave += new System.EventHandler(this.labelRestart_MouseLeave);
            // 
            // labelLeaders
            // 
            this.labelLeaders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLeaders.BackColor = System.Drawing.Color.Transparent;
            this.labelLeaders.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelLeaders.Image = global::Survival.Properties.Resources.board;
            this.labelLeaders.Location = new System.Drawing.Point(467, 31);
            this.labelLeaders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLeaders.Name = "labelLeaders";
            this.labelLeaders.Size = new System.Drawing.Size(187, 46);
            this.labelLeaders.TabIndex = 5;
            this.labelLeaders.Text = "Stars";
            this.labelLeaders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLeaders.Click += new System.EventHandler(this.labelLeaders_Click);
            this.labelLeaders.MouseEnter += new System.EventHandler(this.labelLeaders_MouseEnter);
            this.labelLeaders.MouseLeave += new System.EventHandler(this.labelLeaders_MouseLeave);
            // 
            // labelLogIn
            // 
            this.labelLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogIn.BackColor = System.Drawing.Color.Transparent;
            this.labelLogIn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelLogIn.ForeColor = System.Drawing.Color.Black;
            this.labelLogIn.Image = global::Survival.Properties.Resources.board;
            this.labelLogIn.Location = new System.Drawing.Point(503, 84);
            this.labelLogIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(116, 54);
            this.labelLogIn.TabIndex = 17;
            this.labelLogIn.Text = "Log In";
            this.labelLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLogIn.Click += new System.EventHandler(this.labelLogIn_Click);
            this.labelLogIn.MouseEnter += new System.EventHandler(this.labelLogIn_MouseEnter);
            this.labelLogIn.MouseLeave += new System.EventHandler(this.labelLogIn_MouseLeave);
            // 
            // labelSignUp
            // 
            this.labelSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSignUp.BackColor = System.Drawing.Color.Transparent;
            this.labelSignUp.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelSignUp.ForeColor = System.Drawing.Color.Black;
            this.labelSignUp.Image = global::Survival.Properties.Resources.board;
            this.labelSignUp.Location = new System.Drawing.Point(503, 140);
            this.labelSignUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(116, 54);
            this.labelSignUp.TabIndex = 15;
            this.labelSignUp.Text = "Sigh Up";
            this.labelSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSignUp.Click += new System.EventHandler(this.labelSignUp_Click);
            this.labelSignUp.MouseEnter += new System.EventHandler(this.labelSignUp_MouseEnter);
            this.labelSignUp.MouseLeave += new System.EventHandler(this.labelSignUp_MouseLeave);
            // 
            // labelMusic
            // 
            this.labelMusic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMusic.BackColor = System.Drawing.Color.Transparent;
            this.labelMusic.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelMusic.ForeColor = System.Drawing.Color.Black;
            this.labelMusic.Image = global::Survival.Properties.Resources.noteOff;
            this.labelMusic.Location = new System.Drawing.Point(2, 547);
            this.labelMusic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMusic.Name = "labelMusic";
            this.labelMusic.Size = new System.Drawing.Size(101, 76);
            this.labelMusic.TabIndex = 18;
            this.labelMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMusic.Click += new System.EventHandler(this.labelMusic_Click);
            // 
            // FormGameOverMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(640, 638);
            this.Controls.Add(this.labelMusic);
            this.Controls.Add(this.labelLogIn);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.labelLeaders);
            this.Controls.Add(this.labelRestart);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelQuit);
            this.Controls.Add(this.pictureBoxSkull);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(656, 677);
            this.MinimumSize = new System.Drawing.Size(656, 677);
            this.Name = "FormGameOverMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ratopia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkull)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSkull;
        private System.Windows.Forms.Timer timerSkull;
        private System.Windows.Forms.Label labelQuit;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Label labelRestart;
        private System.Windows.Forms.Label labelLeaders;
        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.Label labelMusic;
    }
}