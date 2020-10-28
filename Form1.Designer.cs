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
            this.components = new System.ComponentModel.Container();
            this.picbScreen = new System.Windows.Forms.PictureBox();
            this.stsMenu = new System.Windows.Forms.StatusStrip();
            this.tsslText = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbScreen)).BeginInit();
            this.stsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.stsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.stsMenu_ItemClicked);
            // 
            // tsslText
            // 
            this.tsslText.Name = "tsslText";
            this.tsslText.Size = new System.Drawing.Size(355, 20);
            this.tsslText.Text = "화면확대: d, 화면캡쳐: c , 화면지우기: e, 캡쳐저장: s";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(790, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 398);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.PictureBox picbScreen;
        private System.Windows.Forms.StatusStrip stsMenu;
        private System.Windows.Forms.ToolStripStatusLabel tsslText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

