using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shariki
{
    public partial class Form1 : Form
    {

        int w1, h1;
        int w2, h2;
        int w3, h3;
        int stepX, stepY;
        int step2X, step2Y;
        int step = 5;
        int dirX = 1, dirY = 1;
        int dir2X = 1, dir2Y = 1;

        Bitmap bit = new Bitmap("planka1.png");
        int x0, y0; // Координаты начала перетаскивания
        bool drag = false; //Разрешение перетаскивания

        public Form1()
        {
            InitializeComponent();
            timerShar1.Enabled = false;            
            timerShar2.Enabled = false;                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            w1 = panelDvigenie.Width - pictureBoxShar1.Width;
            h1 = panelDvigenie.Height - pictureBoxShar1.Height;
            w2 = panelDvigenie.Width - pictureBoxShar2.Width;
            h2 = panelDvigenie.Height - pictureBoxShar2.Height;
            w3 = panelDvigenie.Width - pictureBoxPlanka.Width;
            h3 = panelDvigenie.Height - pictureBoxPlanka.Height;
            pictureBoxShar1.Top = h1 / 2 - 100;
            pictureBoxShar1.Left = w1 / 2 - 100;
            pictureBoxShar2.Top = h2 / 2 - 100;
            pictureBoxShar2.Left = w2 / 2;
            pictureBoxPlanka.Top = h3 / 2 + 100;
            pictureBoxPlanka.Left = w3 / w3 + 350;
            pictureBoxPlanka.MouseMove += Pb_MouseMove;
            pictureBoxPlanka.MouseDown += Pb_MouseDown;
            pictureBoxPlanka.MouseUp += Pb_MouseUp;
        }

        private void bStart1_Click(object sender, EventArgs e)
        {
            if (checkBShar1.Checked == false || bStart1.Text == "Стоп")
            {
                timerShar1.Enabled = false;
                bStart1.Text = "Пуск шара 1";
            }
            else
            {
                timerShar1.Enabled = true;
                bStart1.Text = "Стоп";
                w1 = panelDvigenie.Width - pictureBoxShar1.Width;
                h1 = panelDvigenie.Height - pictureBoxShar1.Width;
                pictureBoxShar1.Top = panelDvigenie.Top / panelDvigenie.Top - 1;
                pictureBoxShar1.Left = w1 -1;
            }   
        }

        private void bStart2_Click(object sender, EventArgs e)
        {
            if (checkBShar2.Checked == false || bStart2.Text == "Стоп")
            {
                timerShar2.Enabled = false;
                bStart2.Text = "Пуск шара 2";
            }
            else
            {
                timerShar2.Enabled = true;
                bStart2.Text = "Стоп";
                w2 = panelDvigenie.Width - pictureBoxShar1.Width;
                h2 = panelDvigenie.Height - pictureBoxShar1.Width;
                pictureBoxShar2.Top = h2 / h2 +1;
                pictureBoxShar2.Left = panelDvigenie.Left +1;
            }
        }        

        private void Form1_Resize(object sender, EventArgs e)
        {
            w1 = panelDvigenie.Width - pictureBoxShar1.Width;
            h1 = panelDvigenie.Height - pictureBoxShar1.Height;
            
            w2 = panelDvigenie.Width - pictureBoxShar2.Width;
            h2 = panelDvigenie.Height - pictureBoxShar2.Height;

            w3 = panelDvigenie.Width - pictureBoxPlanka.Width;
            h3 = panelDvigenie.Height - pictureBoxPlanka.Height;
        }

        private void trackBarShar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                timerShar1.Interval = 10 * trackBarShar1.Value;
            }
            catch
            {
                trackBarShar1.Value = 1;
                return;
            }  
        }

        private void trackBarShar2_Scroll(object sender, EventArgs e)
        {
            try
            {
                timerShar2.Interval = 10 * trackBarShar2.Value;
            }
            catch
            {
                trackBarShar2.Value = 1;
                return;
            }
        }       

        private void panelDvigenie_DoubleClick(object sender, EventArgs e)
        {
            if (panelUpravlenie.Visible == false)            
                panelUpravlenie.Visible = true;
            else
                panelUpravlenie.Visible = false;
        }

        private void checkBShar1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBShar1.Checked)
            {
                pictureBoxShar1.Visible = true;
                gBSpeed1.Visible = true;
                trackBarShar1.Visible = true;
                gBNapravlenie1.Visible = true;
            }
            else
            {
                pictureBoxShar1.Visible = false;
                gBSpeed1.Visible = false;
                trackBarShar1.Visible = false;
                gBNapravlenie1.Visible = false;
                timerShar1.Enabled = false;
                bStart1.Text = "Пуск шара 1";
            }
        }

        private void checkBShar2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBShar2.Checked)
            {
                pictureBoxShar2.Visible = true;
                gBSpeed2.Visible = true;
                trackBarShar2.Visible = true;
                gBNapravlenie2.Visible = true;
            }
            else
            {
                pictureBoxShar2.Visible = false;
                gBSpeed2.Visible = false;
                trackBarShar2.Visible = false;
                gBNapravlenie2.Visible = false;
                timerShar2.Enabled = false;
                bStart2.Text = "Пуск шара 2";
            }
        }

        private void Pb_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = pictureBoxPlanka;       //Сама картинка
            bit = new Bitmap(pb.Image);
            pb.Image = bit;
            if (e.Button == MouseButtons.Left)           //ЛКМ – тащить
            {
                drag = true; //Разрешить перетаскивание
                x0 = e.X; //Зафиксировать позицию начала перетаскивания
                y0 = e.Y;
            }           
        }

        private void Pb_MouseMove(object sender, MouseEventArgs e)
        {
            //связь с перетаскиваемым компонентом
            PictureBox pb = pictureBoxPlanka; // Можно sender as PictureBox            
            if (drag) //Разрешено перетаскивание
            {
                Point tmp = new Point(pb.Location.X, pb.Location.Y);
                tmp.X += e.X - x0;                
                pb.Location = tmp;                             
            }
            if (pb.Bounds.Left < panelDvigenie.Left)
            {
                pb.Left = 0;
                return;
            }
            if (pb.Bounds.Right > panelDvigenie.Width)
            {
                pb.Left = panelDvigenie.Width - pb.Width;
                return;
            }            
        }

        private void Pb_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false; //Запретить перетаскивание
        }
        

        private void checkBPlanka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBPlanka.Checked)
            {
                pictureBoxPlanka.Visible = true;               
            }
            else
            {
                pictureBoxPlanka.Visible = false;               
            }
        }               

        private void timerShar1_Tick(object sender, EventArgs e)
        {           
                if (radioBVertical1.Checked)
                {
                    stepX = 0;
                    stepY = step;
                }
                else
                if (radioBGorizontal1.Checked)
                {
                    stepX = step;
                    stepY = 0;
                }
                else
                {
                    stepX = step;
                    stepY = step;
                }
                
                if (pictureBoxShar1.Left <= 0 || pictureBoxShar1.Left > w1)
                    dirX = -dirX;
                if (pictureBoxShar1.Top < 0 || pictureBoxShar1.Top > h1)
                    dirY = -dirY;

                pictureBoxShar1.Left += dirX * stepX;
                pictureBoxShar1.Top += dirY * stepY;

                if (pictureBoxShar2.Visible)
                {
                    if (pictureBoxShar1.Bounds.IntersectsWith(pictureBoxShar2.Bounds))
                    {
                        dirX = -dirX;
                        dirY = -dirY;
                        dir2X = -dir2X;
                        dir2Y = -dir2Y;
                    }
                }

                if (pictureBoxPlanka.Visible)
                    if (pictureBoxShar1.Bounds.IntersectsWith(pictureBoxPlanka.Bounds))
                        dirY = -dirY;                                
        }

        private void timerShar2_Tick(object sender, EventArgs e)
        {
            if (radioBVertical2.Checked)
            {
                step2X = 0;
                step2Y = step;
            }
            else
                if (radioBGorizontal2.Checked)
            {
                step2X = step;
                step2Y = 0;
            }
            else
            {
                step2X = step;
                step2Y = step;
            }

            if (pictureBoxShar2.Left <= 0 || pictureBoxShar2.Left > w2)
                dir2X = -dir2X;
            if (pictureBoxShar2.Top < 0 || pictureBoxShar2.Top > h2)
                dir2Y = -dir2Y;

            pictureBoxShar2.Left += dir2X * step2X;
            pictureBoxShar2.Top += dir2Y * step2Y;

            if (pictureBoxPlanka.Visible)
                if (pictureBoxShar2.Bounds.IntersectsWith(pictureBoxPlanka.Bounds))
                    dir2Y = -dir2Y;
            if (pictureBoxShar1.Visible)
            {
                if (pictureBoxShar2.Bounds.IntersectsWith(pictureBoxShar1.Bounds))
                {
                    dirX = -dirX;
                    dirY = -dirY;
                    dir2X = -dir2X;
                    dir2Y = -dir2Y;
                }
            }
        }
        
        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
