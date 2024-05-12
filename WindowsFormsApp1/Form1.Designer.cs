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
            this.labelnumKilled = new System.Windows.Forms.Label();
            this.labelLevelName = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelKilled = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelGoOn = new System.Windows.Forms.Label();
            this.labelPause = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelnumKilled
            // 
            this.labelnumKilled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelnumKilled.BackColor = System.Drawing.Color.Transparent;
            this.labelnumKilled.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnumKilled.ForeColor = System.Drawing.Color.Black;
            this.labelnumKilled.Location = new System.Drawing.Point(315, 24);
            this.labelnumKilled.Name = "labelnumKilled";
            this.labelnumKilled.Size = new System.Drawing.Size(79, 45);
            this.labelnumKilled.TabIndex = 7;
            this.labelnumKilled.Text = "0";
            this.labelnumKilled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelnumKilled.Click += new System.EventHandler(this.labelnumKilled_Click);
            // 
            // labelLevelName
            // 
            this.labelLevelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLevelName.BackColor = System.Drawing.Color.Transparent;
            this.labelLevelName.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelName.ForeColor = System.Drawing.Color.Black;
            this.labelLevelName.Location = new System.Drawing.Point(22, 22);
            this.labelLevelName.Name = "labelLevelName";
            this.labelLevelName.Size = new System.Drawing.Size(108, 45);
            this.labelLevelName.TabIndex = 9;
            this.labelLevelName.Text = "Level:";
            this.labelLevelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLevelName.Click += new System.EventHandler(this.labelLevelName_Click);
            // 
            // labelLevel
            // 
            this.labelLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel.ForeColor = System.Drawing.Color.Firebrick;
            this.labelLevel.Location = new System.Drawing.Point(111, 22);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(152, 45);
            this.labelLevel.TabIndex = 10;
            this.labelLevel.Text = "EASY";
            this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelKilled
            // 
            this.labelKilled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKilled.BackColor = System.Drawing.Color.Transparent;
            this.labelKilled.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKilled.ForeColor = System.Drawing.Color.Black;
            this.labelKilled.Image = global::Survival.Properties.Resources.grave;
            this.labelKilled.Location = new System.Drawing.Point(263, 23);
            this.labelKilled.Name = "labelKilled";
            this.labelKilled.Size = new System.Drawing.Size(51, 45);
            this.labelKilled.TabIndex = 8;
            this.labelKilled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKilled.Click += new System.EventHandler(this.labelKilled_Click);
            // 
            // labelExit
            // 
            this.labelExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelExit.BackColor = System.Drawing.Color.Maroon;
            this.labelExit.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.Black;
            this.labelExit.Image = global::Survival.Properties.Resources.longBoard;
            this.labelExit.Location = new System.Drawing.Point(301, 215);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(241, 52);
            this.labelExit.TabIndex = 5;
            this.labelExit.Text = "Exit ";
            this.labelExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExit.Visible = false;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelGoOn
            // 
            this.labelGoOn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGoOn.BackColor = System.Drawing.Color.Maroon;
            this.labelGoOn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelGoOn.ForeColor = System.Drawing.Color.Black;
            this.labelGoOn.Image = global::Survival.Properties.Resources.longBoard;
            this.labelGoOn.Location = new System.Drawing.Point(301, 144);
            this.labelGoOn.Name = "labelGoOn";
            this.labelGoOn.Size = new System.Drawing.Size(243, 52);
            this.labelGoOn.TabIndex = 2;
            this.labelGoOn.Text = "Go on";
            this.labelGoOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGoOn.Visible = false;
            this.labelGoOn.Click += new System.EventHandler(this.labelGoOn_Click);
            // 
            // labelPause
            // 
            this.labelPause.BackColor = System.Drawing.Color.Transparent;
            this.labelPause.Font = new System.Drawing.Font("Comic Sans MS", 15.8F, System.Drawing.FontStyle.Bold);
            this.labelPause.Image = global::Survival.Properties.Resources.board;
            this.labelPause.Location = new System.Drawing.Point(671, 25);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(156, 50);
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
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelLevelName);
            this.Controls.Add(this.labelnumKilled);
            this.Controls.Add(this.labelKilled);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelGoOn);
            this.Controls.Add(this.labelPause);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(869, 824);
            this.MinimumSize = new System.Drawing.Size(869, 824);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ratopia";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerMovement;
        private System.Windows.Forms.Timer timerSpawnMonster;
        private System.Windows.Forms.Timer timerDeadMonster;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Label labelGoOn;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelnumKilled;
        private System.Windows.Forms.Label labelKilled;
        private System.Windows.Forms.Label labelLevelName;
        private System.Windows.Forms.Label labelLevel;
    }
}

