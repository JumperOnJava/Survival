namespace Survival
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBoxSkull = new System.Windows.Forms.PictureBox();
            this.timerSkull = new System.Windows.Forms.Timer(this.components);
            this.labelQuit = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.labelRestart = new System.Windows.Forms.Label();
            this.labelLeaders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkull)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSkull
            // 
            this.pictureBoxSkull.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSkull.Image = global::Survival.Properties.Resources.skullBlack;
            this.pictureBoxSkull.Location = new System.Drawing.Point(54, 38);
            this.pictureBoxSkull.Name = "pictureBoxSkull";
            this.pictureBoxSkull.Size = new System.Drawing.Size(404, 415);
            this.pictureBoxSkull.TabIndex = 0;
            this.pictureBoxSkull.TabStop = false;
            // 
            // labelQuit
            // 
            this.labelQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuit.BackColor = System.Drawing.Color.Transparent;
            this.labelQuit.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelQuit.Image = global::Survival.Properties.Resources.longBoard;
            this.labelQuit.Location = new System.Drawing.Point(128, 639);
            this.labelQuit.Name = "labelQuit";
            this.labelQuit.Size = new System.Drawing.Size(249, 57);
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
            this.labelScore.Location = new System.Drawing.Point(127, 466);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(249, 57);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score: 0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRecord
            // 
            this.labelRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRecord.BackColor = System.Drawing.Color.Transparent;
            this.labelRecord.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelRecord.ForeColor = System.Drawing.Color.White;
            this.labelRecord.Image = global::Survival.Properties.Resources.longBoardRed;
            this.labelRecord.Location = new System.Drawing.Point(127, 404);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(249, 57);
            this.labelRecord.TabIndex = 3;
            this.labelRecord.Text = "New Record!";
            this.labelRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRecord.Visible = false;
            // 
            // labelRestart
            // 
            this.labelRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRestart.BackColor = System.Drawing.Color.Transparent;
            this.labelRestart.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelRestart.Image = global::Survival.Properties.Resources.longBoard;
            this.labelRestart.Location = new System.Drawing.Point(127, 565);
            this.labelRestart.Name = "labelRestart";
            this.labelRestart.Size = new System.Drawing.Size(249, 57);
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
            this.labelLeaders.Image = global::Survival.Properties.Resources.PauseBoard1;
            this.labelLeaders.Location = new System.Drawing.Point(658, 29);
            this.labelLeaders.Name = "labelLeaders";
            this.labelLeaders.Size = new System.Drawing.Size(249, 57);
            this.labelLeaders.TabIndex = 5;
            this.labelLeaders.Text = "Stars";
            this.labelLeaders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLeaders.Click += new System.EventHandler(this.labelLeaders_Click);
            this.labelLeaders.MouseEnter += new System.EventHandler(this.labelLeaders_MouseEnter);
            this.labelLeaders.MouseLeave += new System.EventHandler(this.labelLeaders_MouseLeave);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(851, 777);
            this.Controls.Add(this.labelLeaders);
            this.Controls.Add(this.labelRestart);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelQuit);
            this.Controls.Add(this.pictureBoxSkull);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(869, 824);
            this.MinimumSize = new System.Drawing.Size(869, 824);
            this.Name = "Form3";
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
    }
}