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

namespace Paint
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        bool isDrawing = false;
        Point startPoint, endPoint;
        Pen pen = new Pen(Color.Black, 1);
        Pen eraser = new Pen(Color.White, 10);
        int startX, startY, shapeWidth, shapeHeight;
        ColorDialog colorDialog = new ColorDialog();
        Color newColor;
        Image OpenedFile;

        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            bmp=new Bitmap(pic.Width, pic.Height);
            g=Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pic.Image= bmp;



            
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        //private void pic_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;

        //    if (isDrawing)
        //    {
        //        switch (index)
        //        {
        //            case 3:
        //                g.DrawEllipse(pen, startX, startY, shapeWidth, shapeHeight);
        //                break;
        //            case 4:
        //                g.DrawRectangle(pen, startX, startY, shapeWidth, shapeHeight);
        //                break;
        //            case 5:
        //                g.DrawLine(pen, startX, startY, shapeWidth, shapeHeight);
        //                break;
        //        }
        //    }
        //}

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bmp;
            index = 0;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            newColor = colorDialog.Color;
            pic_color.BackColor = newColor;
            pen.Color = colorDialog.Color;
        }

        static Point SetPoint(PictureBox pictureBox, Point point)
        {
            float pointX = 1f * pictureBox.Image.Width / pictureBox.Width;
            float pointY = 1f * pictureBox.Image.Height / pictureBox.Height;
            return new Point((int)(point.X * pointX), (int)(point.Y * pointY));
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;

            startX = e.X;
            startY = e.Y;

        }
        int index;


        private void colorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = SetPoint(colorPicker, e.Location);
            pic_color.BackColor = ((Bitmap)colorPicker.Image).GetPixel(point.X, point.Y);
            newColor = pic_color.BackColor;
            pen.Color = pic_color.BackColor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing == false) return;

            switch (index)
            {
                case 1:
                    endPoint = e.Location;
                    g.DrawLine(pen, startPoint, endPoint);
                    startPoint = endPoint;
                    break;
                case 2:
                    endPoint = e.Location;
                    g.DrawLine(eraser, startPoint, endPoint);
                    startPoint = endPoint;
                    break;
          
            }

            pic.Refresh();
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if(index == 7)
            {
                Point point = SetPoint(pic, e.Location);
                Fill(bmp, point.X, point.Y, newColor);
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap newBMP = bmp.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bmp.PixelFormat);
                newBMP.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Image saved sucessfully");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog Op = new OpenFileDialog();
            DialogResult dr = Op.ShowDialog();
            if (dr == DialogResult.OK)
            {
                OpenedFile = Image.FromFile(Op.FileName);
                pic.Image = OpenedFile;
            }
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing=false;
            shapeWidth = e.X - startX;
            shapeHeight = e.Y - startY;

            switch (index)
            {
                case 3:
                    g.DrawEllipse(pen, startX, startY, shapeWidth, shapeHeight);
                    break;
                case 4:
                        g.DrawRectangle(pen, 
                            Math.Min(startPoint.X, e.X), 
                            Math.Min(startPoint.Y, e.Y), 
                            Math.Abs(e.X - startPoint.X), 
                            Math.Abs(e.Y - startPoint.Y));
                    break;
                case 5:
                    g.DrawLine(pen, startX, startY, e.X, e.Y);
                    break;
            }

            pic.Refresh();
        }

        private void Validate(Bitmap bitmap, Stack<Point> stack, int x, int y, Color oldColor, Color newColor)
        {
            Color color = bitmap.GetPixel(x, y);
            if(color == oldColor)
            {
                stack.Push(new Point(x, y));
                bitmap.SetPixel(x, y, newColor);
            }
        }

        public void Fill(Bitmap bitmap, int x, int y, Color newColor)
        {
            Color oldColor = bitmap.GetPixel(x, y);
            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(x, y));
            bitmap.SetPixel(x, y, newColor);
            if (oldColor == newColor) return;

            while(stack.Count > 0)
            {
                Point point = (Point) stack.Pop();
                if(point.X > 0 && point.Y > 0 && point.X < bitmap.Width - 1 && point.Y < bitmap.Height - 1 )
                {
                    Validate(bitmap, stack, point.X - 1, point.Y, oldColor, newColor);
                    Validate(bitmap, stack, point.X, point.Y - 1, oldColor, newColor);
                    Validate(bitmap, stack, point.X + 1, point.Y, oldColor, newColor);
                    Validate(bitmap, stack, point.X, point.Y + 1, oldColor, newColor);
                }
            }
        }
    }
}
