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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxEnterName = new System.Windows.Forms.TextBox();
            this.textBoxEnterPassword = new System.Windows.Forms.TextBox();
            this.labelEnterPassword = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelEnterName = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelConfirm
            // 
            this.labelConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConfirm.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirm.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.labelConfirm.ForeColor = System.Drawing.Color.Black;
            this.labelConfirm.Image = global::Survival.Properties.Resources.longBoard;
            this.labelConfirm.Location = new System.Drawing.Point(309, 482);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(246, 87);
            this.labelConfirm.TabIndex = 4;
            this.labelConfirm.Text = "Sign up";
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
            this.labelClose.Location = new System.Drawing.Point(20, 691);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(107, 65);
            this.labelClose.TabIndex = 5;
            this.labelClose.Text = "Back";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 15.2F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Image = global::Survival.Properties.Resources.longBoardRed;
            this.labelName.Location = new System.Drawing.Point(310, 179);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(236, 72);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.textBoxEnterName.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxEnterName.ForeColor = System.Drawing.Color.White;
            this.textBoxEnterName.Location = new System.Drawing.Point(335, 254);
            this.textBoxEnterName.MaxLength = 12;
            this.textBoxEnterName.Name = "textBoxEnterName";
            this.textBoxEnterName.Size = new System.Drawing.Size(189, 38);
            this.textBoxEnterName.TabIndex = 8;
            this.textBoxEnterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEnterPassword
            // 
            this.textBoxEnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxEnterPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEnterPassword.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxEnterPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxEnterPassword.Location = new System.Drawing.Point(336, 413);
            this.textBoxEnterPassword.MaxLength = 12;
            this.textBoxEnterPassword.Name = "textBoxEnterPassword";
            this.textBoxEnterPassword.Size = new System.Drawing.Size(187, 38);
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
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Comic Sans MS", 15.2F, System.Drawing.FontStyle.Bold);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(174, 682);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(514, 85);
            this.labelError.TabIndex = 12;
            this.labelError.Text = "Error !";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelError.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(291, 101);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(284, 87);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Sign up";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Survival.Properties.Resources.HillAndForest;
            this.ClientSize = new System.Drawing.Size(851, 777);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxEnterPassword);
            this.Controls.Add(this.textBoxEnterName);
            this.Controls.Add(this.labelEnterPassword);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.labelConfirm);
            this.Controls.Add(this.labelEnterName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelTitle);
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
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxEnterName;
        private System.Windows.Forms.TextBox textBoxEnterPassword;
        private System.Windows.Forms.Label labelEnterPassword;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelEnterName;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelTitle;
    }
}