using SliderCaptcha.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SliderCaptcha.WinForms.Example
{
    public partial class SliderForm : Form
    {
        private int SliderMaxX = 0;
        private int pb2MaxX = 0;
        public SliderForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            pb2.Parent = pb1;
            pb2.Location = new Point(0, 0);
            pb2.Width = Config.l + Config.d + Config.blod;
            lblArea.Location = new Point(0, 0);
            lblArea.Width = 0;
            lblArea.Height = lblbox.Height - 2;
            lblArea.Parent = lblbox;
            lblSlider.Parent = lblbox;
            lblSlider.Location = new Point(-1, -1);
            lblSlider.BringToFront();
            lblRefresh.Parent = pb1;
            lblRefresh.Location = new Point(pb1.Width - lblRefresh.Width + 1, -1);
            lblRefresh.BringToFront();
            SliderMaxX = lblbox.Width - lblSlider.Width - 1;
            pb2MaxX = pb1.Width - pb2.Width;
        }


        
        int CorrectX = 0;

        public void Generate()
        {
            CaptchaModel model = Captcha.Generate();
            CorrectX = model.X;
            //pb2.Size = new Size(model.Slide.Width, model.Slide.Height);
            //pb1.Size = new Size(model.Background.Width, model.Background.Height);
            pb2.Image = model.Slide;
            pb1.Image = model.Background;
            Bitmap bitmap = (Bitmap)model.Background;
            Color color = bitmap.GetPixel(bitmap.Width - lblRefresh.Width, lblRefresh.Height);
            lblRefresh.ForeColor = Captcha.AntiColor(color);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Generate();
        }



        private string[] sliderTexts = new string[] { "➞", "✓", "✕" };
        private Color[] sliderColors = new Color[] { Color.FromArgb(25, 145, 250), Color.FromArgb(82, 204, 186), Color.FromArgb(245, 122, 122) };

        private Color[] BackColors = new Color[] { Color.FromArgb(209, 233, 254), Color.FromArgb(210, 244, 239), Color.FromArgb(252, 225, 225) };

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            sliderlock = false;
            Generate();
            SliderStyle(0);
        }



        private int sliderX = 0;//滑块x坐标
        private bool isMouseDown = false;//记录鼠标按键是否按下 
        private bool sliderlock = false;

        private void lblSlider_MouseMove(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            if (isMouseDown && !sliderlock)
            {
                label.BackColor = sliderColors[0];
                Point mousePos = Control.MousePosition;
                mousePos.Offset(sliderX, 0);
                int left = mousePos.X - this.Location.X;
                if (left < -1) left = -1;
                if (left > SliderMaxX) left = SliderMaxX;
                sliderArea(0);
                double pleft = left / (SliderMaxX * 1.0) * pb2MaxX;
                pb2.Location = new Point((int)pleft, 0);
                label.Location = new Point(left, -1);
                lblbox.Text = "";
            }
        }

        private void lblSlider_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Location.X == -1)
            {
                label.BackColor = Color.White;
            }
        }

        private void lblSlider_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                sliderX = xOffset;
                isMouseDown = true;
            }
        }


        private void lblSlider_MouseUp(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            if (e.Button == MouseButtons.Left)
            {
                sliderlock = true;
                isMouseDown = false;
                int difX = CorrectX - pb2.Location.X;
                if (difX >= 0 - Config.blod && difX <= Config.blod)
                {
                    SliderStyle(1);
                }
                else
                {
                    SliderStyle(2);
                }

            }
        }



        public void SliderStyle(int status)
        {
            lblSlider.Text = sliderTexts[status];
            lblSlider.BackColor = sliderColors[status];
            sliderArea(status);
            if (status == 2)
            {
                new Thread(() =>
                {
                    Thread.Sleep(1000);
                    this.Invoke((Action)delegate
                    {
                        SliderStyle(0);
                        Generate();
                    });

                }).Start();
            }
            if (status == 0)
            {
                sliderlock = false;
                lblSlider.BackColor = Color.White;
                lblbox.Text = "向右拖动滑块填充拼图";
                pb2.Location = new Point(0, 0);
                lblSlider.Location = new Point(-1, -1);
                lblArea.Width = 0;
            }
        }


        public void sliderArea(int status)
        {
            lblArea.Tag = status;
            int _width = lblSlider.Location.X;
            lblArea.Width = _width < 0 ? 0 : _width + lblSlider.Width;
            lblArea.Refresh();
        }


        private void lblArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int _Tag = Convert.ToInt32(lblArea.Tag);
            Color _color = sliderColors[_Tag];
            SolidBrush SegBrush = new SolidBrush(_color);
            Pen pen = new Pen(SegBrush, 1);
            lblArea.BorderStyle = BorderStyle.None;
            lblArea.BackColor = BackColors[_Tag];
            pen.Color = Color.White;
            Rectangle myRectangle = new Rectangle(0, 0, lblArea.Width, lblArea.Height);
            ControlPaint.DrawBorder(g, myRectangle, _color, ButtonBorderStyle.Solid);//画个边框 
        }
    }
}
