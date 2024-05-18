namespace Survival
{
    partial class FormLogInMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogInMenu));
            this.labelError = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxEnterPassword = new System.Windows.Forms.TextBox();
            this.textBoxEnterName = new System.Windows.Forms.TextBox();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.labelNmae = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogInTitle = new System.Windows.Forms.Label();
            this.labelEnterPassword = new System.Windows.Forms.Label();
            this.labelEnterName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Comic Sans MS", 15.2F, System.Drawing.FontStyle.Bold);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(129, 558);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(428, 69);
            this.labelError.TabIndex = 23;
            this.labelError.Text = "Error !";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelError.Visible = false;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold);
            this.labelInfo.ForeColor = System.Drawing.Color.Black;
            this.labelInfo.Location = new System.Drawing.Point(100, 29);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(440, 58);
            this.labelInfo.TabIndex = 22;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEnterPassword
            // 
            this.textBoxEnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxEnterPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEnterPassword.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxEnterPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxEnterPassword.Location = new System.Drawing.Point(249, 340);
            this.textBoxEnterPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEnterPassword.MaxLength = 12;
            this.textBoxEnterPassword.Name = "textBoxEnterPassword";
            this.textBoxEnterPassword.Size = new System.Drawing.Size(141, 32);
            this.textBoxEnterPassword.TabIndex = 21;
            this.textBoxEnterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEnterName
            // 
            this.textBoxEnterName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxEnterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxEnterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEnterName.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxEnterName.ForeColor = System.Drawing.Color.White;
            this.textBoxEnterName.Location = new System.Drawing.Point(248, 210);
            this.textBoxEnterName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEnterName.MaxLength = 12;
            this.textBoxEnterName.Name = "textBoxEnterName";
            this.textBoxEnterName.Size = new System.Drawing.Size(142, 32);
            this.textBoxEnterName.TabIndex = 19;
            this.textBoxEnterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelClose
            // 
            this.labelClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClose.BackColor = System.Drawing.Color.Transparent;
            this.labelClose.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.labelClose.ForeColor = System.Drawing.Color.Black;
            this.labelClose.Image = global::Survival.Properties.Resources.PauseBoard1;
            this.labelClose.Location = new System.Drawing.Point(20, 561);
            this.labelClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(80, 53);
            this.labelClose.TabIndex = 16;
            this.labelClose.Text = "Back";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // labelConfirm
            // 
            this.labelConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConfirm.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirm.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.labelConfirm.ForeColor = System.Drawing.Color.Black;
            this.labelConfirm.Image = global::Survival.Properties.Resources.longBoard;
            this.labelConfirm.Location = new System.Drawing.Point(229, 409);
            this.labelConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(182, 52);
            this.labelConfirm.TabIndex = 15;
            this.labelConfirm.Text = "Login";
            this.labelConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelConfirm.Click += new System.EventHandler(this.labelConfirm_Click);
            this.labelConfirm.MouseEnter += new System.EventHandler(this.labelConfirm_MouseEnter);
            this.labelConfirm.MouseLeave += new System.EventHandler(this.labelConfirm_MouseLeave);
            // 
            // labelNmae
            // 
            this.labelNmae.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNmae.BackColor = System.Drawing.Color.Transparent;
            this.labelNmae.Font = new System.Drawing.Font("Comic Sans MS", 15.2F, System.Drawing.FontStyle.Bold);
            this.labelNmae.ForeColor = System.Drawing.Color.White;
            this.labelNmae.Image = global::Survival.Properties.Resources.longBoardRed;
            this.labelNmae.Location = new System.Drawing.Point(230, 150);
            this.labelNmae.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNmae.Name = "labelNmae";
            this.labelNmae.Size = new System.Drawing.Size(177, 58);
            this.labelNmae.TabIndex = 17;
            this.labelNmae.Text = "Name";
            this.labelNmae.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Comic Sans MS", 15.2F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Image = global::Survival.Properties.Resources.longBoardRed;
            this.labelPassword.Location = new System.Drawing.Point(230, 274);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(178, 69);
            this.labelPassword.TabIndex = 18;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogInTitle
            // 
            this.labelLogInTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogInTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelLogInTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogInTitle.ForeColor = System.Drawing.Color.White;
            this.labelLogInTitle.Location = new System.Drawing.Point(177, 83);
            this.labelLogInTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogInTitle.Name = "labelLogInTitle";
            this.labelLogInTitle.Size = new System.Drawing.Size(289, 71);
            this.labelLogInTitle.TabIndex = 24;
            this.labelLogInTitle.Text = "Log In";
            this.labelLogInTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEnterPassword
            // 
            this.labelEnterPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEnterPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelEnterPassword.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelEnterPassword.ForeColor = System.Drawing.Color.Black;
            this.labelEnterPassword.Image = global::Survival.Properties.Resources.longBoardWider;
            this.labelEnterPassword.Location = new System.Drawing.Point(208, 326);
            this.labelEnterPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnterPassword.Name = "labelEnterPassword";
            this.labelEnterPassword.Size = new System.Drawing.Size(220, 60);
            this.labelEnterPassword.TabIndex = 20;
            this.labelEnterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEnterName
            // 
            this.labelEnterName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEnterName.BackColor = System.Drawing.Color.Transparent;
            this.labelEnterName.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelEnterName.ForeColor = System.Drawing.Color.Black;
            this.labelEnterName.Image = global::Survival.Properties.Resources.longBoardWider;
            this.labelEnterName.Location = new System.Drawing.Point(208, 197);
            this.labelEnterName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnterName.Name = "labelEnterName";
            this.labelEnterName.Size = new System.Drawing.Size(220, 58);
            this.labelEnterName.TabIndex = 14;
            this.labelEnterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogInMenu
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
            this.Controls.Add(this.labelNmae);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogInTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(656, 677);
            this.MinimumSize = new System.Drawing.Size(656, 677);
            this.Name = "FormLogInMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ratopia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxEnterPassword;
        private System.Windows.Forms.TextBox textBoxEnterName;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.Label labelNmae;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogInTitle;
        private System.Windows.Forms.Label labelEnterPassword;
        private System.Windows.Forms.Label labelEnterName;
    }
}