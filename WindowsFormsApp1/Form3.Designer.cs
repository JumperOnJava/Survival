namespace WindowsFormsApp1
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
            this.labelExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkull)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSkull
            // 
            this.pictureBoxSkull.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSkull.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSkull.Image")));
            this.pictureBoxSkull.Location = new System.Drawing.Point(54, 38);
            this.pictureBoxSkull.Name = "pictureBoxSkull";
            this.pictureBoxSkull.Size = new System.Drawing.Size(404, 415);
            this.pictureBoxSkull.TabIndex = 0;
            this.pictureBoxSkull.TabStop = false;
            // 
            // labelExit
            // 
            this.labelExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.labelExit.Image = global::WindowsFormsApp1.Properties.Resources.longBoardRed;
            this.labelExit.Location = new System.Drawing.Point(146, 456);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(249, 57);
            this.labelExit.TabIndex = 1;
            this.labelExit.Text = "Exit";
            this.labelExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseEnter += new System.EventHandler(this.labelExit_MouseEnter);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(851, 777);
            this.Controls.Add(this.labelExit);
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
        private System.Windows.Forms.Label labelExit;
    }
}