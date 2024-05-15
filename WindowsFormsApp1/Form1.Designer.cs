namespace Survival
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerMovement = new System.Windows.Forms.Timer(this.components);
            this.timerSpawnMonster = new System.Windows.Forms.Timer(this.components);
            this.timerDeadMonster = new System.Windows.Forms.Timer(this.components);
            this.labelKilledCount = new System.Windows.Forms.Label();
            this.labelLevelName = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelWoodCount = new System.Windows.Forms.Label();
            this.labelWood = new System.Windows.Forms.Label();
            this.labelKilled = new System.Windows.Forms.Label();
            this.labelQuit = new System.Windows.Forms.Label();
            this.labelResume = new System.Windows.Forms.Label();
            this.labelPause = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKilledCount
            // 
            this.labelKilledCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKilledCount.BackColor = System.Drawing.Color.Transparent;
            this.labelKilledCount.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKilledCount.ForeColor = System.Drawing.Color.Black;
            this.labelKilledCount.Location = new System.Drawing.Point(340, 39);
            this.labelKilledCount.Name = "labelKilledCount";
            this.labelKilledCount.Size = new System.Drawing.Size(79, 45);
            this.labelKilledCount.TabIndex = 7;
            this.labelKilledCount.Text = "0";
            this.labelKilledCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLevelName
            // 
            this.labelLevelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLevelName.BackColor = System.Drawing.Color.Transparent;
            this.labelLevelName.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelName.ForeColor = System.Drawing.Color.Black;
            this.labelLevelName.Location = new System.Drawing.Point(29, 712);
            this.labelLevelName.Name = "labelLevelName";
            this.labelLevelName.Size = new System.Drawing.Size(108, 45);
            this.labelLevelName.TabIndex = 9;
            this.labelLevelName.Text = "Level:";
            this.labelLevelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLevel
            // 
            this.labelLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel.ForeColor = System.Drawing.Color.Green;
            this.labelLevel.Location = new System.Drawing.Point(116, 712);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(152, 45);
            this.labelLevel.TabIndex = 10;
            this.labelLevel.Text = "EASY";
            this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWoodCount
            // 
            this.labelWoodCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWoodCount.BackColor = System.Drawing.Color.Transparent;
            this.labelWoodCount.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWoodCount.ForeColor = System.Drawing.Color.Black;
            this.labelWoodCount.Location = new System.Drawing.Point(228, 37);
            this.labelWoodCount.Name = "labelWoodCount";
            this.labelWoodCount.Size = new System.Drawing.Size(64, 45);
            this.labelWoodCount.TabIndex = 11;
            this.labelWoodCount.Text = "0";
            this.labelWoodCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWood
            // 
            this.labelWood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWood.BackColor = System.Drawing.Color.Transparent;
            this.labelWood.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWood.ForeColor = System.Drawing.Color.Black;
            this.labelWood.Image = ((System.Drawing.Image)(resources.GetObject("labelWood.Image")));
            this.labelWood.Location = new System.Drawing.Point(147, 19);
            this.labelWood.Name = "labelWood";
            this.labelWood.Size = new System.Drawing.Size(89, 84);
            this.labelWood.TabIndex = 12;
            this.labelWood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWood.Click += new System.EventHandler(this.labelWood_Click);
            // 
            // labelKilled
            // 
            this.labelKilled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKilled.BackColor = System.Drawing.Color.Transparent;
            this.labelKilled.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKilled.ForeColor = System.Drawing.Color.Black;
            this.labelKilled.Image = global::Survival.Properties.Resources.grave;
            this.labelKilled.Location = new System.Drawing.Point(287, 38);
            this.labelKilled.Name = "labelKilled";
            this.labelKilled.Size = new System.Drawing.Size(51, 45);
            this.labelKilled.TabIndex = 8;
            this.labelKilled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQuit
            // 
            this.labelQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuit.BackColor = System.Drawing.Color.Maroon;
            this.labelQuit.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuit.ForeColor = System.Drawing.Color.Black;
            this.labelQuit.Image = global::Survival.Properties.Resources.longBoard;
            this.labelQuit.Location = new System.Drawing.Point(301, 378);
            this.labelQuit.Name = "labelQuit";
            this.labelQuit.Size = new System.Drawing.Size(241, 52);
            this.labelQuit.TabIndex = 5;
            this.labelQuit.Text = "Quit";
            this.labelQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuit.Visible = false;
            this.labelQuit.Click += new System.EventHandler(this.labelQuit_Click);
            this.labelQuit.MouseEnter += new System.EventHandler(this.labelQuit_MouseEnter);
            this.labelQuit.MouseLeave += new System.EventHandler(this.labelQuit_MouseLeave);
            // 
            // labelResume
            // 
            this.labelResume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResume.BackColor = System.Drawing.Color.Maroon;
            this.labelResume.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelResume.ForeColor = System.Drawing.Color.Black;
            this.labelResume.Image = global::Survival.Properties.Resources.longBoard;
            this.labelResume.Location = new System.Drawing.Point(301, 295);
            this.labelResume.Name = "labelResume";
            this.labelResume.Size = new System.Drawing.Size(243, 52);
            this.labelResume.TabIndex = 2;
            this.labelResume.Text = "Resume";
            this.labelResume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResume.Visible = false;
            this.labelResume.Click += new System.EventHandler(this.labelResume_Click);
            this.labelResume.MouseEnter += new System.EventHandler(this.labelResume_MouseEnter);
            this.labelResume.MouseLeave += new System.EventHandler(this.labelResume_MouseLeave);
            // 
            // labelPause
            // 
            this.labelPause.BackColor = System.Drawing.Color.Transparent;
            this.labelPause.Font = new System.Drawing.Font("Comic Sans MS", 15.8F, System.Drawing.FontStyle.Bold);
            this.labelPause.Image = global::Survival.Properties.Resources.PauseBoard1;
            this.labelPause.Location = new System.Drawing.Point(713, 26);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(117, 80);
            this.labelPause.TabIndex = 1;
            this.labelPause.Text = "Pause";
            this.labelPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPause.Click += new System.EventHandler(this.labelPause_Click);
            this.labelPause.MouseEnter += new System.EventHandler(this.labelPause_MouseEnter);
            this.labelPause.MouseLeave += new System.EventHandler(this.labelPause_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 777);
            this.Controls.Add(this.labelWoodCount);
            this.Controls.Add(this.labelWood);
            this.Controls.Add(this.labelLevelName);
            this.Controls.Add(this.labelKilledCount);
            this.Controls.Add(this.labelKilled);
            this.Controls.Add(this.labelQuit);
            this.Controls.Add(this.labelResume);
            this.Controls.Add(this.labelPause);
            this.Controls.Add(this.labelLevel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(869, 824);
            this.MinimumSize = new System.Drawing.Size(869, 824);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ratopia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerMovement;
        private System.Windows.Forms.Timer timerSpawnMonster;
        private System.Windows.Forms.Timer timerDeadMonster;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Label labelResume;
        private System.Windows.Forms.Label labelQuit;
        private System.Windows.Forms.Label labelKilledCount;
        private System.Windows.Forms.Label labelKilled;
        private System.Windows.Forms.Label labelLevelName;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelWoodCount;
        private System.Windows.Forms.Label labelWood;
    }
}

