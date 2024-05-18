namespace Survival
{
    partial class FormSignUpMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUpMenu));
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
            this.labelConfirm.Location = new System.Drawing.Point(232, 392);
            this.labelConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(184, 71);
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
            this.labelClose.Location = new System.Drawing.Point(15, 561);
            this.labelClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(80, 53);
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
            this.labelName.Location = new System.Drawing.Point(232, 145);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(177, 58);
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
            this.labelPassword.Location = new System.Drawing.Point(232, 270);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(178, 69);
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
            this.textBoxEnterName.Location = new System.Drawing.Point(251, 206);
            this.textBoxEnterName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEnterName.MaxLength = 12;
            this.textBoxEnterName.Name = "textBoxEnterName";
            this.textBoxEnterName.Size = new System.Drawing.Size(142, 32);
            this.textBoxEnterName.TabIndex = 8;
            this.textBoxEnterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEnterPassword
            // 
            this.textBoxEnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxEnterPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEnterPassword.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxEnterPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxEnterPassword.Location = new System.Drawing.Point(252, 336);
            this.textBoxEnterPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEnterPassword.MaxLength = 12;
            this.textBoxEnterPassword.Name = "textBoxEnterPassword";
            this.textBoxEnterPassword.Size = new System.Drawing.Size(141, 32);
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
            this.labelEnterPassword.Location = new System.Drawing.Point(212, 322);
            this.labelEnterPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnterPassword.Name = "labelEnterPassword";
            this.labelEnterPassword.Size = new System.Drawing.Size(220, 60);
            this.labelEnterPassword.TabIndex = 9;
            this.labelEnterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold);
            this.labelInfo.ForeColor = System.Drawing.Color.Black;
            this.labelInfo.Location = new System.Drawing.Point(103, 25);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(440, 58);
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
            this.labelEnterName.Location = new System.Drawing.Point(212, 193);
            this.labelEnterName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnterName.Name = "labelEnterName";
            this.labelEnterName.Size = new System.Drawing.Size(220, 58);
            this.labelEnterName.TabIndex = 2;
            this.labelEnterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Comic Sans MS", 15.2F, System.Drawing.FontStyle.Bold);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(107, 552);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(453, 69);
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
            this.labelTitle.Location = new System.Drawing.Point(218, 82);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(213, 71);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Sign up";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSignUpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Survival.Properties.Resources.HillAndForest;
            this.ClientSize = new System.Drawing.Size(640, 638);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(656, 677);
            this.MinimumSize = new System.Drawing.Size(656, 677);
            this.Name = "FormSignUpMenu";
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