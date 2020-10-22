namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picbScreen = new System.Windows.Forms.PictureBox();
            this.stsMenu = new System.Windows.Forms.StatusStrip();
            this.tsslText = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picbScreen)).BeginInit();
            this.stsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbScreen
            // 
            this.picbScreen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picbScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbScreen.Location = new System.Drawing.Point(0, 0);
            this.picbScreen.Name = "picbScreen";
            this.picbScreen.Size = new System.Drawing.Size(800, 450);
            this.picbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbScreen.TabIndex = 0;
            this.picbScreen.TabStop = false;
            this.picbScreen.Click += new System.EventHandler(this.picbScreen_Click);
            // 
            // stsMenu
            // 
            this.stsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslText});
            this.stsMenu.Location = new System.Drawing.Point(0, 424);
            this.stsMenu.Name = "stsMenu";
            this.stsMenu.Size = new System.Drawing.Size(800, 26);
            this.stsMenu.TabIndex = 1;
            this.stsMenu.Text = "statusStrip1";
            // 
            // tsslText
            // 
            this.tsslText.Name = "tsslText";
            this.tsslText.Size = new System.Drawing.Size(270, 20);
            this.tsslText.Text = "화면캡쳐: c , 화면지우기: e, 캡쳐저장: s";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stsMenu);
            this.Controls.Add(this.picbScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "화면캡쳐";
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picbScreen)).EndInit();
            this.stsMenu.ResumeLayout(false);
            this.stsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbScreen;
        private System.Windows.Forms.StatusStrip stsMenu;
        private System.Windows.Forms.ToolStripStatusLabel tsslText;
    }
}

