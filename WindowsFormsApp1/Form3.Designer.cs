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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.labelQuit.Location = new System.Drawing.Point(133, 641);
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
            this.labelScore.Location = new System.Drawing.Point(133, 489);
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
            this.labelRecord.Location = new System.Drawing.Point(133, 427);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(249, 57);
            this.labelRecord.TabIndex = 3;
            this.labelRecord.Text = "New Record!";
            this.labelRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Image = global::Survival.Properties.Resources.longBoard;
            this.label1.Location = new System.Drawing.Point(133, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Restart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Image = global::Survival.Properties.Resources.longBoard;
            this.label2.Location = new System.Drawing.Point(615, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 57);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stars";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(851, 777);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}