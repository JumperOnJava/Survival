namespace Survival
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.labelConfirm = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelNmae = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxEnterName = new System.Windows.Forms.TextBox();
            this.textBoxEnterPassword = new System.Windows.Forms.TextBox();
            this.labelEnterPassword = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelEnterName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelConfirm
            // 
            this.labelConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConfirm.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirm.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.labelConfirm.ForeColor = System.Drawing.Color.Black;
            this.labelConfirm.Image = global::Survival.Properties.Resources.PauseBoard1;
            this.labelConfirm.Location = new System.Drawing.Point(449, 515);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(102, 64);
            this.labelConfirm.TabIndex = 4;
            this.labelConfirm.Text = "Yes";
            this.labelConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelConfirm.Click += new System.EventHandler(this.labelConfirm_Click);
            this.labelConfirm.MouseEnter += new System.EventHandler(this.labelConfirm_MouseEnter);
            this.labelConfirm.MouseLeave += new System.EventHandler(this.labelConfirm_MouseLeave);
            // 
            // labelClose
            // 
            this.labelClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClose.BackColor = System.Drawing.Color.Transparent;
            this.labelClose.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.labelClose.ForeColor = System.Drawing.Color.Black;
            this.labelClose.Image = global::Survival.Properties.Resources.PauseBoard1;
            this.labelClose.Location = new System.Drawing.Point(310, 514);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(107, 65);
            this.labelClose.TabIndex = 5;
            this.labelClose.Text = "No";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // labelNmae
            // 
            this.labelNmae.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNmae.BackColor = System.Drawing.Color.Transparent;
            this.labelNmae.Font = new System.Drawing.Font("Comic Sans MS", 15.2F, System.Drawing.FontStyle.Bold);
            this.labelNmae.ForeColor = System.Drawing.Color.White;
            this.labelNmae.Image = global::Survival.Properties.Resources.longBoardRed;
            this.labelNmae.Location = new System.Drawing.Point(310, 179);
            this.labelNmae.Name = "labelNmae";
            this.labelNmae.Size = new System.Drawing.Size(236, 72);
            this.labelNmae.TabIndex = 6;
            this.labelNmae.Text = "Name";
            this.labelNmae.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNmae.Click += new System.EventHandler(this.labelNmae_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Comic Sans MS", 15.2F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Image = global::Survival.Properties.Resources.longBoardRed;
            this.labelPassword.Location = new System.Drawing.Point(310, 332);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(238, 85);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEnterName
            // 
            this.textBoxEnterName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxEnterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxEnterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEnterName.Font = new System.Drawing.Font("Comic Sans MS", 14.6F, System.Drawing.FontStyle.Bold);
            this.textBoxEnterName.ForeColor = System.Drawing.Color.White;
            this.textBoxEnterName.Location = new System.Drawing.Point(335, 252);
            this.textBoxEnterName.Name = "textBoxEnterName";
            this.textBoxEnterName.Size = new System.Drawing.Size(189, 41);
            this.textBoxEnterName.TabIndex = 8;
            this.textBoxEnterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEnterPassword
            // 
            this.textBoxEnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxEnterPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEnterPassword.Font = new System.Drawing.Font("Comic Sans MS", 14.6F, System.Drawing.FontStyle.Bold);
            this.textBoxEnterPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxEnterPassword.Location = new System.Drawing.Point(336, 411);
            this.textBoxEnterPassword.Name = "textBoxEnterPassword";
            this.textBoxEnterPassword.Size = new System.Drawing.Size(187, 41);
            this.textBoxEnterPassword.TabIndex = 10;
            this.textBoxEnterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelEnterPassword
            // 
            this.labelEnterPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEnterPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelEnterPassword.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelEnterPassword.ForeColor = System.Drawing.Color.Black;
            this.labelEnterPassword.Image = global::Survival.Properties.Resources.longBoardWider;
            this.labelEnterPassword.Location = new System.Drawing.Point(282, 396);
            this.labelEnterPassword.Name = "labelEnterPassword";
            this.labelEnterPassword.Size = new System.Drawing.Size(294, 74);
            this.labelEnterPassword.TabIndex = 9;
            this.labelEnterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold);
            this.labelInfo.ForeColor = System.Drawing.Color.Black;
            this.labelInfo.Location = new System.Drawing.Point(137, 31);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(587, 72);
            this.labelInfo.TabIndex = 11;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEnterName
            // 
            this.labelEnterName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEnterName.BackColor = System.Drawing.Color.Transparent;
            this.labelEnterName.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelEnterName.ForeColor = System.Drawing.Color.Black;
            this.labelEnterName.Image = global::Survival.Properties.Resources.longBoardWider;
            this.labelEnterName.Location = new System.Drawing.Point(282, 238);
            this.labelEnterName.Name = "labelEnterName";
            this.labelEnterName.Size = new System.Drawing.Size(293, 72);
            this.labelEnterName.TabIndex = 2;
            this.labelEnterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Survival.Properties.Resources.HillAndForest;
            this.ClientSize = new System.Drawing.Size(851, 777);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxEnterPassword);
            this.Controls.Add(this.textBoxEnterName);
            this.Controls.Add(this.labelEnterPassword);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.labelConfirm);
            this.Controls.Add(this.labelEnterName);
            this.Controls.Add(this.labelNmae);
            this.Controls.Add(this.labelPassword);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(869, 824);
            this.MinimumSize = new System.Drawing.Size(869, 824);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ratopia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelNmae;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxEnterName;
        private System.Windows.Forms.TextBox textBoxEnterPassword;
        private System.Windows.Forms.Label labelEnterPassword;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelEnterName;
    }
}