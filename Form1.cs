using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;
using System.Reflection.Emit;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double rate = 2.0;
        Point orgLocalPoint;
        Size orgLocalSize;
        bool orgbool = true; 
        bool capbool = false;  
        Graphics ScreenG; 
        Bitmap Captwin; 
        public Form1(
            )
        {InitializeComponent();

            timer1.Enabled = true;

            this.MouseWheel += new MouseEventHandler(Form_MouseWheel);
        }
        private void timer1_Tick(object sender, EventArgs e)
{
            label1.Text = "배율 : x" + rate;

            Size size = new Size(pictureBox1.Width, pictureBox1.Height);

            Bitmap bitmap = new Bitmap((int)(size.Width / rate), (int)(size.Height / rate));
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.CopyFromScreen((int)(MousePosition.X - size.Width / (rate * 2)), (int)(MousePosition.Y - size.Height / (rate * 2)), 0, 0, size, CopyPixelOperation.SourceCopy);

            pictureBox1.Image = bitmap;
        }

        private void Form_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0 && rate > 0.2)
            {
                rate -= 0.1;
            }
            else if (e.Delta > 0 && rate < 5.0)
            {
                rate += 0.1;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {  }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            int curX = Cursor.Position.X;
            int curY = Cursor.Position.Y;

            int screenWidth = 50;
            int screeHeight = 50;

            Size size = new Size(screenWidth, screeHeight);
            Bitmap bitmap = new Bitmap(size.Width, size.Height);

            double rate = 2.0;

            Graphics graphic = Graphics.FromImage(bitmap);
            graphic.CopyFromScreen(curX - (screenWidth / 2), curY - (screeHeight / 2), 0, 0, size);

            int zoominWidth = (int)(screenWidth * rate);
            int zoominHeight = (int)(screeHeight * rate);

            Bitmap zoomin = new Bitmap(zoominWidth, zoominHeight);

            for (int i = 0; i < zoominWidth; i++)
            {
                for (int j = 0; j < zoominHeight; j++)
                {
                    int row = (int)(i / rate);
                    int col = (int)(j / rate);
                    zoomin.SetPixel(i, j, bitmap.GetPixel(row, col));
                }
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar =='d')
            {
                label1.Text = "배율 : x" + rate;

                Size size = new Size(picbScreen.Width, picbScreen.Height);

                Bitmap bitmap = new Bitmap((int)(size.Width / rate), (int)(size.Height / rate));
                Graphics graphics = Graphics.FromImage(bitmap);

                graphics.CopyFromScreen((int)(MousePosition.X - size.Width / (rate * 2)), (int)(MousePosition.Y - size.Height / (rate * 2)), 0, 0, size, CopyPixelOperation.SourceCopy);

                picbScreen.Image = bitmap;
            }
            if (e.KeyChar == 'c'){
                orgbool = false;//폼의 위치가 바뀌는 것을 감지하여 ture로 설정
                capbool = true; //초기설정을 false로 바꾸고 캡쳐가 될경우 true가 되게 함
                this.Opacity = 0.0; //폼의 투명도를 설정하는 구문

                this.FormBorderStyle = FormBorderStyle.None; //Borderstyle 속성을 설정하는 것으로 폼 테두리가 보이지 않게 None
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.Bounds.Size;
                var fullScreen = Screen.PrimaryScreen.Bounds;
                Captwin = new Bitmap(fullScreen.Width, fullScreen.Height);
                ScreenG = Graphics.FromImage(Captwin);
                ScreenG.CopyFromScreen(PointToScreen(new Point(0, 0)),
                        new Point(0, 0), fullScreen.Size);
                this.picbScreen.Image = Captwin;
                this.Opacity = 100.0;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.Location = orgLocalPoint;
                this.Size = orgLocalSize;
                orgbool = true;
            }
            else if (e.KeyChar == 'e'){
                capbool = false;
                this.picbScreen.Image = null;
            }
            else if (e.KeyChar == 's') {
                if (capbool == true){
                    using (var SFile = new SaveFileDialog()){
                        SFile.OverwritePrompt = true;
                        SFile.FileName = "화면캡쳐";
                        SFile.Filter = "이미지 파일(*.jpg)|*.jpg";
                        DialogResult rst = SFile.ShowDialog();
                        if (rst == DialogResult.OK)
                            Captwin.Save(SFile.FileName, ImageFormat.Jpeg);
                    }
                }
                else{
                    MessageBox.Show("화면을 캡쳐할 수 없음", "알림",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void Form1_LocationChanged(object sender, EventArgs e){
            if (orgbool == true){
                orgLocalPoint = this.Location;
                orgLocalSize = this.Size;
            }
        }
        private void picbScreen_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void stsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
