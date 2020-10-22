using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Point orgLocalPoint;
        Size orgLocalSize;
        bool orgbool = true; 
        bool capbool = false;  
        Graphics ScreenG; 
        Bitmap Captwin; 
        public Form1()
        {InitializeComponent();}
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {  }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e){
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
    }
}
