using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoAn
{
    public partial class frmMain : Form
    {
        
        int n = 0;
        int dd = 0;
        int dc = 0;
        int ts = 0;
        int reset=0;
        int show = 0;
        int temp = 0;
        int temp1 = 0;
        int dem = 0;
        int dem1 = 0;
        int vt = 1;
        int vtm = 0;
        int vtm1 = 0;
        int temp2 = 0;
        int dieukien = 0;
        int temp3 = 0;
        int lienthong = 0;
        int max = 2147483647;
        int[,] D = new int[100,100];
        int[,] Dn = new int[100, 100];
        int[,] Dd = new int[100, 100];
        Rectangle[] rect = new Rectangle[100];
        int[] dayso = new int[1000];
        int[] trongso = new int[1000];
        int[] mang = new int[1000];
        string[] arr = new string[1000];
        public frmMain()
        {
            InitializeComponent();
        }
        SaveFileDialog save;
        OpenFileDialog open;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            Font drFont = new Font("Arial", 12);
            Font drFont2 = new Font("Arial",13,FontStyle.Bold);
            SolidBrush drBrush = new SolidBrush(Color.Lime);
            SolidBrush drBrush1 = new SolidBrush(Color.White);
            SolidBrush drBrush2 = new SolidBrush(Color.Red);
            Pen pen = new Pen(Color.Black, 2);
            Pen pen1 = new Pen(Color.DeepSkyBlue, 4);
            int x=100, y=250;
            
            Point drpoint1 = new Point(x + 6, y + 4);
                for (int i = 0; i < n; i++)
                {
                    if(n==1)
                    {
                        x = 100;
                        y = 250;
                    }
                    else if (n == 2)
                    {
                        x += 120;
                        if (i == 0)
                        {
                            x = 100;
                            y = 250;
                        }
                    }
                    else if (n > 2)
                    {
                        if (i % 2 != 0)
                        {
                            x += 120;
                            y = 350;
                            if (i == n - 1)
                            {
                                y = 250;
                            }
                        }
                        else if (i % 2 == 0)
                        {
                            y = 150;
                            if (i == 0)
                            {
                                x = 100;
                                y = 250;
                            }
                        }
                    }
                    rect[i] = new Rectangle(x, y, 26, 26);
                }
            
            if (show != 0)
            {
                
                
                for (int j = 1; j < (vt -1); j+=2)
                { 
                    if (j == 1)
                    {
                        vtm1 = 2;
                    }
                    else if(j>1)
                    {
                        vtm1 += 3;
                        for (int k = j-2; k >=0; k -= 2)
                        {
                            if (dayso[j] == dayso[k - 1] && dayso[j - 1] == dayso[k])
                            {

                                temp2 = 1;
                                break;
                            }
                            else temp2 = 0;
                        }
                    }
                    
                    if (rbvh.Checked == true)
                    {
                        int tamx2 = rect[dayso[j] - 1].X;
                        int tamy2 = rect[dayso[j] - 1].Y + 13;
                        int tamx = rect[dayso[j - 1] - 1].X;
                        int tamy = rect[dayso[j - 1] - 1].Y + 13;
                        if (tamx < tamx2)
                        {
                            tamx += 30;
                            tamx2 -= 4;
                            if (tamy2 < tamy)
                            {
                                tamy -= 7;
                                tamy2 += 8;
                            }
                            else if (tamy2 > tamy)
                            {
                                tamy2 -= 8;
                                tamy += 7;
                            }
                            else if (tamy == tamy2)
                            {
                                for (int i = tamx; i < tamx2; i++)
                                {
                                    for (int k = dayso[j - 1] - 1; k < dayso[j] - 1; k++)
                                    {
                                        if (i == rect[k].X && rect[dayso[j - 1] - 1].Y == rect[k].Y)
                                        {
                                            if (tamy < 200)
                                            {
                                                temp = 1;
                                                dem++;
                                            }
                                            else if (tamy > 200)
                                            {
                                                temp1 = 1;
                                                dem1++;
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        else if (tamx > tamx2)
                        {
                            tamx2 += 30;
                            tamx -= 4;
                            if (tamy < tamy2)
                            {
                                tamy2 -= 8;
                                tamy += 7;
                            }
                            else if (tamy > tamy2)
                            {
                                tamy2 += 8;
                                tamy -= 7;
                            }
                            else if(tamy==tamy2)
                            { for (int i = tamx2; i < tamx; i++)
                                {
                                    for (int k = dayso[j] - 1; k < dayso[j - 1] - 1; k++)
                                    {
                                        if (i == rect[k].X && rect[dayso[j] - 1].Y == rect[k].Y)
                                        {
                                            if (tamy < 200)
                                            {
                                                temp = 1;
                                                dem++;
                                                if (dem == 1)
                                                {
                                                    tamx2 -= 34;
                                                    tamx += 34;
                                                }
                                            }
                                            else if (tamy > 200)
                                            {
                                                temp1 = 1;
                                                dem1++;
                                                if (dem1 == 1)
                                                {
                                                    tamx2 -= 34;
                                                    tamx += 34;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (tamx == tamx2)
                        {
                            tamx += 13;
                            tamx2 += 13;
                            if (tamy > tamy2)
                            {
                                tamy -= 13;
                                tamy2 += 13;
                            }
                            if (tamy < tamy2)
                            {
                                tamy += 13;
                                tamy2 -= 13;
                            }
                        }
                        if (temp == 1)
                        {
                            if (dem == 1) dem = 0;
                            Point drpoint2 = new Point(tamx - 17, tamy - 17);
                            if (dem == 2) tamy -= 40;
                            Point drpoint3 = new Point(tamx - 17, tamy - 67);
                            Point drpoint4 = new Point(tamx2 + 17, tamy - 67);
                            if (dem == 2) tamy += 40;
                            Point drpoint5 = new Point(tamx2 + 17, tamy - 17);
                            e.Graphics.DrawLine(pen1, drpoint2, drpoint3);
                            e.Graphics.DrawLine(pen1, drpoint3, drpoint4);
                            e.Graphics.DrawLine(pen1, drpoint4, drpoint5);
                            if (dem == 2) tamy -= 70;
                            Point drpoint6 = new Point(((tamx + tamx2) / 2) - 10, ((tamy + tamy2) / 2) - 88);
                                e.Graphics.DrawString((mang[vtm1]).ToString(), drFont2, drBrush2, drpoint6);
                            temp = 0;
                            if (dem == 2)
                            {
                                tamy += 70;
                                dem = 0;
                            }
                        }
                        else if (temp1 == 1)
                        {
                            if (dem1 == 1) dem1 = 0;
                            Point drpoint2 = new Point(tamx - 17, tamy + 17);
                            if (dem1 == 2) tamy += 40;
                            Point drpoint3 = new Point(tamx - 17, tamy + 87);
                            Point drpoint4 = new Point(tamx2 + 17, tamy + 87);
                            if (dem1 == 2) tamy -= 40;
                            Point drpoint5 = new Point(tamx2 + 17, tamy + 17);
                            e.Graphics.DrawLine(pen1, drpoint2, drpoint3);
                            e.Graphics.DrawLine(pen1, drpoint3, drpoint4);
                            e.Graphics.DrawLine(pen1, drpoint4, drpoint5);
                            if (dem1 == 2) tamy += 70;
                            Point drpoint6 = new Point(((tamx + tamx2) / 2) - 10, ((tamy + tamy2) / 2) + 88);
                                e.Graphics.DrawString((mang[vtm1]).ToString(), drFont2, drBrush2, drpoint6);
                            temp1 = 0;
                            if(dem1==2)
                            {
                                tamy -= 70;
                                dem1 = 0;
                            }
                        }
                        else
                        {
                            Point drpoint2 = new Point(tamx, tamy);
                            Point drpoint3 = new Point(tamx2, tamy2);
                            e.Graphics.DrawLine(pen1, drpoint2, drpoint3);
                            if (tamy == tamy2)
                            {
                                Point drpoint6 = new Point(((tamx + tamx2) / 2) - 10, ((tamy + tamy2) / 2) - 10);
                                e.Graphics.DrawString((mang[vtm1]).ToString(), drFont2, drBrush2, drpoint6);
                            }
                            else if (tamy != tamy2)
                            {
                                    if((dayso[j]==2 && dayso[j-1]==5) || (dayso[j] == 5 && dayso[j - 1] == 2))
                                    {
                                        Point drpoint6 = new Point(((tamx + tamx2) / 2) + 10, ((tamy + tamy2) / 2) - 20);
                                        e.Graphics.DrawString((mang[vtm1]).ToString(), drFont2, drBrush2, drpoint6);
                                    }
                                    else if ((dayso[j] == 4 && dayso[j - 1] == 7) || (dayso[j] == 7 && dayso[j - 1] == 4))
                                {
                                    Point drpoint6 = new Point(((tamx + tamx2) / 2) + 10, ((tamy + tamy2) / 2) - 20);
                                    e.Graphics.DrawString((mang[vtm1]).ToString(), drFont2, drBrush2, drpoint6);
                                }
                                else if ((dayso[j] == 2 && dayso[j - 1] == 7) || (dayso[j] == 7 && dayso[j - 1] == 2))
                                {
                                    Point drpoint6 = new Point(((tamx + tamx2) / 2) + 10, ((tamy + tamy2) / 2) - 20);
                                    e.Graphics.DrawString((mang[vtm1]).ToString(), drFont2, drBrush2, drpoint6);
                                }
                                else if ((dayso[j] == 2 && dayso[j - 1] == 9) || (dayso[j] == 9 && dayso[j - 1] == 2))
                                {
                                    Point drpoint6 = new Point(((tamx + tamx2) / 2) + 10, ((tamy + tamy2) / 2) - 20);
                                    e.Graphics.DrawString((mang[vtm1]).ToString(), drFont2, drBrush2, drpoint6);
                                }
                                else
                                    {
                                        Point drpoint6 = new Point(((tamx + tamx2) / 2) - 20, ((tamy + tamy2) / 2) - 20);
                                        e.Graphics.DrawString((mang[vtm1]).ToString(), drFont2, drBrush2, drpoint6);
                                    }
                                
                            }
                            temp1 = 0; temp = 0;
                        }

                    }
                    else
                    {
                        int tamx2 = rect[dayso[j] - 1].X;
                        int tamy2 = rect[dayso[j] - 1].Y + 13;
                        int tamx = rect[dayso[j - 1] - 1].X;
                        int tamy = rect[dayso[j - 1] - 1].Y + 13;
                        if(tamx==tamx2 && tamy==tamy2)
                        {
                            temp3 = 1;
                        }
                        else if (tamx < tamx2)
                        {
                            tamx += 30;
                            tamx2 -= 4;
                            if (tamy2 < tamy)
                            {
                                tamy -= 7;
                                tamy2 += 8;
                            }
                            else if (tamy2 > tamy)
                            {
                                tamy2 -= 8;
                                tamy += 7;
                            }
                            else if(tamy==tamy2)
                            { for (int i = tamx; i < tamx2; i++)
                                {
                                    for (int k = dayso[j - 1] - 1; k < dayso[j] - 1; k++)
                                    {
                                        if (i == rect[k].X && rect[dayso[j - 1] - 1].Y == rect[k].Y)
                                        {
                                            if (tamy < 200)
                                            {
                                                temp = 1;
                                                dem++;
                                            }
                                            else if (tamy > 200)
                                            {
                                                temp1 = 1;
                                                dem1++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (tamx > tamx2)
                        {
                            tamx2 += 30;
                            tamx -= 4;
                            if (tamy < tamy2)
                            {
                                tamy2 -= 8;
                                tamy += 7;
                            }
                            else if (tamy > tamy2)
                            {
                                tamy2 += 8;
                                tamy -= 7;
                            }
                            else if(tamy==tamy2)
                            { for (int i = tamx2; i < tamx; i++)
                                {
                                    for (int k = dayso[j] - 1; k < dayso[j - 1] - 1; k++)
                                    {
                                        if (i == rect[k].X && rect[dayso[j] - 1].Y == rect[k].Y)
                                        {
                                            if (tamy < 200)
                                            {
                                                temp = 1;
                                                dem++;
                                                if (dem == 1)
                                                {
                                                    tamx2 -= 34;
                                                    tamx += 34;
                                                }
                                            }
                                            else if (tamy > 200)
                                            {
                                                temp1 = 1;
                                                dem1++;
                                                if (dem1 == 1)
                                                {
                                                    tamx2 -= 34;
                                                    tamx += 34;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (tamx == tamx2)
                        {
                            tamx += 13;
                            tamx2 += 13;
                            if (tamy > tamy2)
                            {
                                tamy -= 13;
                                tamy2 += 13;
                            }
                            if (tamy < tamy2)
                            {
                                tamy += 13;
                                tamy2 -= 13;
                            }
                        }
                        if(temp3==1)
                        {
                            pen1.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            e.Graphics.DrawArc(pen1,tamx-13,tamy-13,26,26,-70,-220);
                            Point drpoint6 = new Point(((tamx + tamx2) / 2) - 50, ((tamy + tamy2) / 2)-20);
                            e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);
                            temp3 = 0;
                        }
                        else if (temp == 1)
                        {
                            if (dem == 1) dem = 0;
                            Point drpoint2 = new Point(tamx - 17, tamy - 17);
                            if (dem == 2)
                            {
                                tamy -= 40;
                            }
                            Point drpoint3 = new Point(tamx - 17, tamy - 67);
                            Point drpoint4 = new Point(tamx2 + 17, tamy - 67);
                            if (dem == 2)
                            {
                                tamy += 40;
                            }
                            Point drpoint5 = new Point(tamx2 + 17, tamy - 17);
                            e.Graphics.DrawLine(pen1, drpoint2, drpoint3);
                            e.Graphics.DrawLine(pen1, drpoint3, drpoint4);
                            if(temp2==1)
                            {
                                if (dem == 2)
                                {
                                    tamy -= 70;
                                }
                                Point drpoint6 = new Point(((tamx + tamx2) / 2) - 30, ((tamy + tamy2) / 2) -70);
                                e.Graphics.DrawString((mang[vtm1]).ToString()+" {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);
                                temp2 = 0;
                                if (dem == 2)
                                {
                                    tamy += 70;
                                    dem = 0;
                                }
                            }
                            else if (temp2 == 0)
                            {
                                if (dem == 2)
                                {
                                    tamy -= 70;
                                }
                                Point drpoint6 = new Point(((tamx + tamx2) / 2) - 30, ((tamy + tamy2) / 2) - 88);
                                e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);
                                if (dem == 2)
                                {
                                    tamy += 70;
                                    dem = 0;
                                }
                            }          
                            pen1.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            e.Graphics.DrawLine(pen1, drpoint4, drpoint5);
                            pen1.EndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
                            temp = 0;
                        }
                        else if (temp1 == 1)
                        {
                            if (dem1 == 1) dem1 = 0;
                            Point drpoint2 = new Point(tamx - 17, tamy + 17);
                            if (dem1 == 2)
                            {
                                tamy += 40;
                            }
                            Point drpoint3 = new Point(tamx - 17, tamy + 87);
                            Point drpoint4 = new Point(tamx2 + 17, tamy + 87);
                            if (dem1 == 2)
                            {
                                tamy -= 40;
                            }
                            Point drpoint5 = new Point(tamx2 + 17, tamy + 17);
                            e.Graphics.DrawLine(pen1, drpoint2, drpoint3);
                            e.Graphics.DrawLine(pen1, drpoint3, drpoint4);
                            if (temp2 == 1)
                            {
                                if (dem1 == 2)
                                {
                                    tamy += 70;
                                }
                                Point drpoint6 = new Point(((tamx + tamx2) / 2) - 30, ((tamy + tamy2) / 2) +66);
                                e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);
                                temp2 = 0;
                                if (dem1 == 2)
                                {
                                    tamy -= 70;
                                    dem1 = 0;
                                }
                            }
                            else if(temp2==0)
                            {
                                if (dem1 == 2)
                                {
                                    tamy += 70;
                                }
                                Point drpoint6 = new Point(((tamx + tamx2) / 2) - 30, ((tamy + tamy2) / 2) + 88);
                                e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);
                                if (dem1 == 2)
                                {
                                    tamy -= 70;
                                    dem1 = 0;
                                }
                            }
                            pen1.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            e.Graphics.DrawLine(pen1, drpoint4, drpoint5);
                            pen1.EndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
                            temp1 = 0;
                        }
                        else
                        {
                            Point drpoint2 = new Point(tamx, tamy);
                            Point drpoint3 = new Point(tamx2, tamy2);
                            pen1.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            e.Graphics.DrawLine(pen1, drpoint2, drpoint3);
                            if (tamy == tamy2)
                            {
                                if (temp2 == 1)
                                {
                                    Point drpoint6 = new Point(((tamx + tamx2) / 2) - 30, ((tamy + tamy2) / 2) + 2);
                                    e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);
                                    temp2 = 0;
                                }
                                else if (temp2 == 0)
                                {
                                    Point drpoint6 = new Point(((tamx + tamx2) / 2) - 30, ((tamy + tamy2) / 2) - 20);
                                    e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);
                                }
                            }
                            else if (tamy != tamy2)
                            {
                                if (temp2 == 1)
                                {
                                    if ((dayso[j] == 2 && dayso[j - 1] == 5) || (dayso[j] == 5 && dayso[j - 1] == 2))
                                    {
                                        Point drpoint6 = new Point(((tamx + tamx2) / 2) - 45, ((tamy + tamy2) / 2) +25);
                                        e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);
                                        temp2 = 0;
                                    }
                                    else if ((dayso[j] == 4 && dayso[j - 1] == 7) || (dayso[j] == 7 && dayso[j - 1] == 4))
                                    {
                                        Point drpoint6 = new Point(((tamx + tamx2) / 2) -45, ((tamy + tamy2) / 2) + 25);
                                        e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);
                                        temp2 = 0;
                                    }
                                    else if ((dayso[j] == 2 && dayso[j - 1] == 7) || (dayso[j] == 7 && dayso[j - 1] == 2))
                                    {
                                        Point drpoint6 = new Point(((tamx + tamx2) / 2) - 45, ((tamy + tamy2) / 2) + 25);
                                        e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);
                                        temp2 = 0;
                                    }
                                    else if ((dayso[j] == 2 && dayso[j - 1] == 9) || (dayso[j] == 9 && dayso[j - 1] == 2))
                                    {
                                        Point drpoint6 = new Point(((tamx + tamx2) / 2) - 45, ((tamy + tamy2) / 2) + 25);
                                        e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);
                                        temp2 = 0;
                                    }
                                    else
                                    {
                                        Point drpoint6 = new Point(((tamx + tamx2) / 2)-5, ((tamy + tamy2) / 2) +5);
                                        e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);
                                        temp2 = 0;
                                    }
                                }
                                else if (temp2 == 0)
                                {
                                    if ((dayso[j] == 2 && dayso[j - 1] == 5) || (dayso[j] == 5 && dayso[j - 1] == 2))
                                    {
                                        Point drpoint6 = new Point(((tamx + tamx2) / 2) + 20, ((tamy + tamy2) / 2) -50);
                                        e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);
                                    }
                                    else if ((dayso[j] == 4 && dayso[j - 1] == 7) || (dayso[j] == 7 && dayso[j - 1] == 4))
                                    {
                                        Point drpoint6 = new Point(((tamx + tamx2) / 2) + 20, ((tamy + tamy2) / 2) - 50);
                                        e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);

                                    }
                                    else if ((dayso[j] == 2 && dayso[j - 1] == 7) || (dayso[j] == 7 && dayso[j - 1] == 2))
                                    {
                                        Point drpoint6 = new Point(((tamx + tamx2) / 2) + 20, ((tamy + tamy2) / 2) - 50);
                                        e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);

                                    }
                                    else if ((dayso[j] == 2 && dayso[j - 1] == 9) || (dayso[j] == 9 && dayso[j - 1] == 2))
                                    {
                                        Point drpoint6 = new Point(((tamx + tamx2) / 2) + 20, ((tamy + tamy2) / 2) - 50);
                                        e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);

                                    }
                                    else
                                    {
                                        Point drpoint6 = new Point(((tamx + tamx2) / 2) - 35, ((tamy + tamy2) / 2) - 30);
                                        e.Graphics.DrawString((mang[vtm1]).ToString() + " {" + mang[vtm1 - 2].ToString() + "," + mang[vtm1 - 1].ToString() + "}", drFont2, drBrush2, drpoint6);

                                    }
                                }
                            }
                            pen1.EndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
                            temp1 = 0; temp = 0;
                        }
                        
                    }
                    
                    x = 100;
                    for (int i = 0; i < n; i++)
                    {
                        if (n == 1)
                        {
                            x = 100;
                            y = 250;
                        }
                        else if (n == 2)
                        {
                            x += 120;
                            if (i == 0)
                            {
                                x = 100;
                                y = 250;
                            }
                        }
                        else if (n > 2)
                        {
                            if (i % 2 != 0)
                            {
                                x += 120;
                                y = 350;
                                if (i == n - 1)
                                {
                                    y = 250;
                                }
                            }
                            else if (i % 2 == 0)
                            {
                                y = 150;
                                if (i == 0)
                                {
                                    x = 100;
                                    y = 250;
                                }
                            }
                        }
                        rect[i] = new Rectangle(x, y, 26, 26);
                        drpoint1 = new Point(x + 6, y + 4);
                        e.Graphics.DrawEllipse(pen, rect[i]);
                        e.Graphics.FillEllipse(drBrush, rect[i]);
                        e.Graphics.DrawString((i + 1).ToString(), drFont, drBrush1, drpoint1);
                    }
                    

                }
                
            }

            if (reset == 1) { e.Graphics.Clear(Color.LemonChiffon); reset = 0; }

            
            
        }

        private void txtdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtdc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnsd_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(nmrsd.Value);
            rect = new Rectangle[n];
            btop.Enabled = false;
            btnsd.Enabled = false;
            nmrsd.Enabled = false;
            if(rbch.Checked==true)
            {
                rbvh.Enabled = false;
            }
            else
            {
                rbch.Enabled = false;
            }
            txtdd.Enabled = true;
            txtdc.Enabled = true;
            txtts.Enabled = true;
            btnc.Enabled = true;
            btxoa.Enabled = true;
            pictureBox1.Invalidate();
            txtdd.Focus();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            dieukien = 0;
            if (txtdd.Text == "")
            {
                MessageBox.Show("Cần nhập đỉnh đầu");
                txtdd.Focus();
            }
            else if (txtdc.Text == "")
            {
                MessageBox.Show("Cần nhập đỉnh cuối");
                txtdc.Focus();
            }
            else if (txtts.Text == "")
            {
                MessageBox.Show("Cần nhập trọng số");
                txtts.Focus();
            }
            else
            {
                dd = Convert.ToInt32(txtdd.Text);
                dc = Convert.ToInt32(txtdc.Text);
                ts = Convert.ToInt32(txtts.Text);
                n = Convert.ToInt32(nmrsd.Value);
            if(dd >n || dd<=0)
            {
                MessageBox.Show("Không có đỉnh " + dd);
                txtdd.Text = "";
                    txtdd.Focus();
            }
            else if (dc > n || dc<=0)
            {
                MessageBox.Show("Không có đỉnh " + dc);
                txtdc.Text = "";
                    txtdc.Focus();
            }
            else if(ts<0)
                {
                    MessageBox.Show("Trọng số không âm ");
                    txtts.Text = "";
                    txtts.Focus();
                }
            else
                {

                if (vt == 1)
                {
                        if (rbvh.Checked == true)
                        {
                            if (dd == dc)
                            {
                                MessageBox.Show("Đồ thị vô hướng không có đỉnh trùng");
                                txtdd.Text = "";
                                txtdc.Text = "";
                                txtts.Text = "";
                                txtdd.Focus();
                                dieukien = 1;
                            }
                        }
                        if (dieukien == 0)
                        {
                            dayso[vt - 1] = dd;
                            dayso[vt] = dc;
                            trongso[vt - 1] = ts;
                            mang[vtm] = dd;
                            vtm++;
                            mang[vtm] = dc;
                            vtm++;
                            mang[vtm] = ts;
                            vtm++;
                            txtdd.Text = "";
                            txtdc.Text = "";
                            txtts.Text = "";
                            vt += 2;
                            for (int j = vtm - 3; j < vtm; j++)
                            {
                                if (j == vtm - 3)
                                    arr[0] = mang[j].ToString();
                                if (j == vtm - 2)
                                    arr[1] = mang[j].ToString();
                                if (j == vtm - 1)
                                    arr[2] = mang[j].ToString();
                            }
                            ListViewItem item = new ListViewItem(arr);
                            lsds.Items.Add(item);
                        }
                }
                else
                {
                        if (rbvh.Checked == true)
                        {
                            if (dd == dc)
                            {
                                MessageBox.Show("Đồ thị vô hướng không có đỉnh trùng");
                                txtdd.Text = "";
                                txtdc.Text = "";
                                txtts.Text = "";
                                txtdd.Focus();
                                dieukien = 1;
                            }
                            else
                            {
                                for (int i = vt - 2; i >= 0; i -= 2)
                                {
                                    if ((dd == dayso[i] && dc == dayso[i - 1]) || (dd == dayso[i - 1] && dc == dayso[i]))
                                    {
                                        MessageBox.Show("Đồ thị đã có cạnh đỉnh " + dd + ", " + dc);
                                        txtdd.Text = "";
                                        txtdc.Text = "";
                                        txtts.Text = "";
                                        txtdd.Focus();
                                        dieukien = 1;
                                    }

                                }
                            }
                                if(dieukien==0)
                                {
                                    dayso[vt - 1] = dd;
                                    dayso[vt] = dc;
                                    trongso[vt - 1] = ts;
                                    mang[vtm] = dd;
                                    vtm++;
                                    mang[vtm] = dc;
                                    vtm++;
                                    mang[vtm] = ts;
                                    vtm++;
                                    txtdd.Text = "";
                                    txtdc.Text = "";
                                    txtts.Text = "";
                                    vt += 2;
                                    for (int j = vtm - 3; j < vtm; j++)
                                    {
                                        if (j == vtm - 3)
                                            arr[0] = mang[j].ToString();
                                        if (j == vtm - 2)
                                            arr[1] = mang[j].ToString();
                                        if (j == vtm - 1)
                                            arr[2] = mang[j].ToString();
                                    }
                                    ListViewItem item = new ListViewItem(arr);
                                    lsds.Items.Add(item);
                                    txtdd.Focus();
                                }
                            }
                   
                        else
                        {
                            for (int i = vt - 2; i >= 0; i -= 2)
                            {
                                if (dd == dayso[i-1] && dc == dayso[i])
                                {
                                    MessageBox.Show("Đồ thị đã có cạnh đỉnh " + dd + ", " + dc);
                                    txtdd.Text = "";
                                    txtdc.Text = "";
                                    txtts.Text = "";
                                    txtdd.Focus();
                                    dieukien = 1;
                                }
                            }
                            if(dieukien==0)
                            {
                                dayso[vt - 1] = dd;
                                dayso[vt] = dc;
                                trongso[vt - 1] = ts;
                                mang[vtm] = dd;
                                vtm++;
                                mang[vtm] = dc;
                                vtm++;
                                mang[vtm] = ts;
                                vtm++;
                                txtdd.Text = "";
                                txtdc.Text = "";
                                txtts.Text = "";
                                vt += 2;
                                for (int j = vtm - 3; j < vtm; j++)
                                {
                                    if (j == vtm - 3)
                                        arr[0] = mang[j].ToString();
                                    if (j == vtm - 2)
                                        arr[1] = mang[j].ToString();
                                    if (j == vtm - 1)
                                        arr[2] = mang[j].ToString();
                                }
                                ListViewItem item = new ListViewItem(arr);
                                lsds.Items.Add(item);
                                txtdd.Focus();
                            }
                        }
                }
                }
                bttim.Enabled = true;
            }
            show = 1;
            pictureBox1.Invalidate();
        }
        

        private void btrs_Click(object sender, EventArgs e)
        {
            n = 0;
            reset = 1;
            btnsd.Enabled = true;
            nmrsd.Enabled = true;
            rbch.Checked = true;
            rbch.Enabled = true;
            rbvh.Enabled = true;
            txtdd.Text = "";
            txtdc.Text = "";
            txtts.Text = "";
            nmrsd.Value = 1;
            txtdd.Enabled = false;
            txtdc.Enabled = false;
            txtts.Enabled = false;
            btnc.Enabled = false;
            bttim.Enabled = false;
            btxoa.Enabled = false;
            btop.Enabled = true;
            arr= new string[1000];
            mang = new int[1000];
            trongso = new int[1000];
            dayso = new int[1000];
            temp3 = 0;
            vtm = 0;
            vtm1 = 0;
            temp = 0;
            temp1 = 0;
            dem = 0;
            dem1 = 0;
            dieukien = 0;
            temp2 = 0;
            lienthong = 0;
            D = new int[100, 100];
            Dn = new int[100, 100];
            Dd = new int[100, 100];
            for (int i=0; i<lsds.Items.Count;i++)
            {
                    lsds.Items[i].Remove();
                    i--;
            }
            vt = 1;
            show = 0;
            pictureBox1.Invalidate();
            nmrsd.Focus();
        }

        private void rbvh_CheckedChanged(object sender, EventArgs e)
        {
            show = 1;
            pictureBox1.Invalidate();
        }

        private void rbch_CheckedChanged(object sender, EventArgs e)
        {
            show = 1;
            pictureBox1.Invalidate();
        }
        
        private void bttim_Click(object sender, EventArgs e)
        {
            Frmxuat frx = new Frmxuat();
            lienthong = 0;
            //tao ma tran trong so
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i == j) D[i, j] = 0;
                    else D[i, j] = max;
                }
            for (int i = 2; i < vtm; i += 3)
            {
                if (rbvh.Checked == true)
                {
                    D[mang[i - 2] - 1, mang[i - 1] - 1] = mang[i];
                    D[mang[i - 1] - 1, mang[i - 2] - 1] = mang[i];
                }
                else
                {
                    D[mang[i - 2] - 1, mang[i - 1] - 1] = mang[i];
                }
            }
            //floyd

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Dn[i, j] = D[i, j];
                    Dd[i, j] = j + 1;
                }
            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if ((Dn[i, k] != max) && (Dn[k, j] != max) && (Dn[i, j] > Dn[i, k] + Dn[k, j]))
                        {
                            Dn[i, j] = Dn[i, k] + Dn[k, j];
                            Dd[i, j] = Dd[i, k];
                        }
                    }
            }

            //tinh lien thong

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if(Dn[i,j]==max||Dn[j,i]==max)
                    {
                        lienthong = 1;
                        break;
                    }
                }
            if (lienthong == 0)
            {
                frx.N = n;
                frx.DN = Dn;
                frx.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đồ thị chưa liên thông");
                txtdd.Focus();
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (txtdd.Text == "")
            {
                MessageBox.Show("Cần nhập đỉnh đầu");
                txtdd.Focus();
            }
            else if (txtdc.Text == "")
            {
                MessageBox.Show("Cần nhập đỉnh cuối");
                txtdc.Focus();
            }
            else
            {
                dd = Convert.ToInt32(txtdd.Text);
                dc = Convert.ToInt32(txtdc.Text);
                if (dd > n || dd <= 0)
                {
                    MessageBox.Show("Không có đỉnh " + dd);
                    txtdd.Text = "";
                    txtdd.Focus();
                }
                else if (dc > n || dc <= 0)
                {
                    MessageBox.Show("Không có đỉnh " + dc);
                    txtdc.Text = "";
                    txtdc.Focus();
                }
                else
                {
                    int t1=0, t2=0;
                    if(rbch.Checked==true)
                    {
                        for (int i = 1; i < vt - 1; i+=2)
                        {
                            if (dd == dayso[i - 1] && dc == dayso[i])
                            {
                                t1 = i;
                                break;
                            }
                        }
                        if (t1 > 0)
                        {
                            while (t1 < vt - 1)
                            {
                                dayso[t1 - 1] = dayso[t1 + 1];
                                dayso[t1] = dayso[t1 + 2];
                                t1 += 2;
                            }
                            vt -= 2;
                        }
                        for (int j = 2; j < vtm; j += 3)
                        {
                            if (dd == mang[j - 2] && dc == mang[j - 1])
                            {
                                t2 = j;
                                break;
                            }
                        }
                        if (t2 > 0)
                        {
                            while (t2 < vtm)
                            {
                                mang[t2 - 2] = mang[t2 + 1];
                                mang[t2 - 1] = mang[t2 + 2];
                                mang[t2] = mang[t2 + 3];
                                t2 += 3;
                            }
                            vtm -= 3;
                        }
                        if (t1 == 0 && t2 == 0)
                        {
                            MessageBox.Show("Không có cạnh cần xóa");
                            txtdd.Text = "";
                            txtdc.Text = "";
                            txtts.Text = "";
                            txtdd.Focus();
                        }
                    }
                    else
                    {
                        for (int i = 1; i < vt - 1; i += 2)
                        {
                            if ((dd == dayso[i - 1] && dc == dayso[i])|| (dd == dayso[i] && dc == dayso[i-1]))
                            {
                                t1 = i;
                                break;
                            }
                        }
                        if (t1 > 0)
                        {
                            while (t1 < vt - 1)
                            {
                                dayso[t1 - 1] = dayso[t1 + 1];
                                dayso[t1] = dayso[t1 + 2];
                                t1 += 2;
                            }
                            vt -= 2;
                        }
                        for (int j = 2; j < vtm; j += 3)
                        {
                            if ((dd == mang[j - 2] && dc == mang[j - 1])|| (dd == mang[j - 1] && dc == mang[j - 2]))
                            {
                                t2 = j;
                                break;
                            }
                        }
                        if (t2 > 0)
                        {
                            while (t2 < vtm)
                            {
                                mang[t2 - 2] = mang[t2 + 1];
                                mang[t2 - 1] = mang[t2 + 2];
                                mang[t2] = mang[t2 + 3];
                                t2 += 3;
                            }
                            vtm -= 3;
                        }
                        if (t1 == 0 && t2 == 0)
                        {
                            MessageBox.Show("Không có cạnh cần xóa");
                            txtdd.Text = "";
                            txtdc.Text = "";
                            txtts.Text = "";
                            txtdd.Focus();
                        }
                    }
                }
            }

                //IN LẠI
                for (int i = 0; i < lsds.Items.Count; i++)
            {
                lsds.Items[i].Remove();
                i--;
            }
            for (int i = 0; i < vtm; i += 3)
            {
                int j = i;
                string[] a = new string[3];
                a[0] = mang[j].ToString();
                j++;
                a[1] = mang[j].ToString();
                j++;
                a[2] = mang[j].ToString();
                ListViewItem item = new ListViewItem(a);
                lsds.Items.Add(item);
            }
            show = 1;
            pictureBox1.Invalidate();
        }
        //save
        public void setfile()
        {
            int t1 = 0;
            if (rbch.Checked == true) t1 = 1;
            string t = "";
            t = t1.ToString() + " " + n.ToString() + " " + vt.ToString() + " " + vtm.ToString() + " ";
            for (int i = 0; i < vt - 1; i++)
            {
                if (i == vt - 2)
                {
                    t += dayso[i].ToString() + " ";
                }
                else
                    t += dayso[i].ToString() + ",";
            }
            for (int i = 0; i < vtm; i++)
            {
                if (i == vtm - 1)
                {
                    t += mang[i].ToString();
                }
                else
                    t += mang[i].ToString() + ",";
            }
            save = new SaveFileDialog();
            save.FileName = "*BTDT.txt";
            save.RestoreDirectory = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(save.FileName);
                write.WriteLine(t);
                write.Close();
            }
        }

        private void btsv_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadSetFile = new System.Threading.Thread(new System.Threading.ThreadStart(setfile));
            threadSetFile.ApartmentState = System.Threading.ApartmentState.STA;
            threadSetFile.Start();

        }
        int rdbt=0 ;
        int loifile=0;
        //open
        public void getfile()
        {
            Invoke((MethodInvoker)delegate
            {
                n = 0;
                rect = new Rectangle[100];
                vt = 1;
                vtm = 0;
                dayso = new int[1000];
                mang = new int[1000];
                loifile = 0;
                for (int i = 0; i < lsds.Items.Count; i++)
                {
                    lsds.Items[i].Remove();
                    i--;
                }
                btnsd.Enabled = true;
                nmrsd.Enabled = true;
                rbch.Checked = true;
                rbch.Enabled = true;
                rbvh.Enabled = true;
                txtdd.Text = "";
                txtdc.Text = "";
                txtts.Text = "";
                nmrsd.Value = 1;
                txtdd.Enabled = false;
                txtdc.Enabled = false;
                txtts.Enabled = false;
                btnc.Enabled = false;
                bttim.Enabled = false;
                btxoa.Enabled = false;
                btop.Enabled = true;
                show = 1;
                pictureBox1.Invalidate();
            });
            open = new OpenFileDialog();
            open.FileName = "*BTDT.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(open.FileName);
                string[] str=new string[6];
                str = read.ReadToEnd().ToString().Split(' ');
                int loi10 = 0;
                loi10 = str.Length;
                if (loi10 != 6)
                {
                    loifile = 1;
                    read.Close();
                    str = new string[6];
                    for(int i=0;i<6;i++)
                    {
                        str[i] = " ";
                    }
                }
                try
                {
                    rdbt = Convert.ToInt32(str[0]);
                    n = Convert.ToInt32(str[1]);
                    vt = Convert.ToInt32(str[2]);
                    vtm = Convert.ToInt32(str[3]);

                }
                catch (Exception)
                {
                    loifile = 1;
                    read.Close();
                }
                
                string[] str1;
                str1 = str[4].Split(',');
                string[] str2;
                str2 = str[5].Split(',');
                int loi11 = 0;
                loi11 = str2.Length;
                if (loi11 == 0)
                {
                    loifile = 1;
                    read.Close();
                }
                int loi7 = 0,loi8 = 0;
                for (int i = 0; i < str1.Length; i++)
                {
                    try
                    {
                        dayso[i] = Convert.ToInt32(str1[i]);
                        if(dayso[i]>n)
                        {
                            loifile = 1;
                            read.Close();
                            break;
                        }
                        loi7++;
                    }
                    catch (Exception)
                    {
                        loifile = 1;
                        read.Close();
                        break;
                    }
                }
                
                for (int i = 0; i < str2.Length; i++)
                {
                    try
                    {
                        mang[i] = Convert.ToInt32(str2[i]);
                        loi8++;
                    }
                    catch (Exception)
                    {

                        loifile = 1;
                        read.Close();
                        break;
                    }
                }
                if ((rdbt != 0 && rdbt != 1) || n < 1 || n > 10 || vt !=(loi7+1) || vtm !=loi8)
                {
                    loifile = 1;
                    read.Close();
                }
                int[] loi = new int[100];
                int loi1 = 2;
                for (int i = 0; i < str2.Length; i++)
                {
                    if (i==loi1)
                    {
                        loi[i] = 0;
                        loi1 += 3;
                    }
                    else
                    {
                        loi[i] = mang[i];
                    }
                }
                string[] loi3;
                string loi4="";
                for(int i=0;i<str2.Length;i++)
                {
                    if(loi[i]!=0)
                    {
                        loi4 += loi[i].ToString() + ",";
                    }
                    else
                    {
                        loi4 += loi[i].ToString();
                    }
                    
                }
                
                loi3 = loi4.Split('0');
                string loi5="";
                for (int i = 0; i < loi3.Length; i++)
                {
                    loi5 += loi3[i].ToString();
                }
                
                string[] loi6;
                int []loi9=new int[1000];
                loi6 = loi5.Split(',');
                for(int i=0;i<str1.Length;i++)
                {
                    try
                    {
                        loi9[i] = Convert.ToInt32(loi6[i]);
                    }
                    catch (Exception)
                    {
                        loifile = 1;
                        read.Close();
                        break;
                    }
                    
                }
                for(int i=0;i<str1.Length;i++)
                {
                    if (dayso[i] != loi9[i])
                    {
                        loifile = 1;
                        read.Close();
                        break;
                    }
                }
                read.Close();
                Invoke((MethodInvoker)delegate
                {
                    if (loifile == 1)
                    {
                        MessageBox.Show("sai file");
                        n = 0;
                        vt = 1;
                        vtm = 0;
                        dayso = new int[1000];
                        mang = new int[1000];
                        reset = 1;

                        loifile = 0;
                    }
                    else
                    {
                        if (rdbt == 1) { rbch.Checked = true; rbvh.Enabled = false; }
                        else { rbvh.Checked = true; rbch.Enabled = false; }
                        nmrsd.Value = n;
                        nmrsd.Enabled = false;
                        btnsd.Enabled = false;
                        txtdd.Enabled = true;
                        txtdc.Enabled = true;
                        txtts.Enabled = true;
                        btnc.Enabled = true;
                        btxoa.Enabled = true;
                        bttim.Enabled = true;
                        txtdd.Focus();
                        for (int i = 0; i < vtm; i += 3)
                        {
                            int j = i;
                            string[] a = new string[3];
                            a[0] = mang[j].ToString();
                            j++;
                            a[1] = mang[j].ToString();
                            j++;
                            a[2] = mang[j].ToString();
                            ListViewItem item = new ListViewItem(a);
                            lsds.Items.Add(item);
                        }
                        show = 1;
                        pictureBox1.Invalidate();
                    }
                });
            
            }
        }


        private void btop_Click(object sender, EventArgs e)
        {
                System.Threading.Thread threadGetFile = new System.Threading.Thread(new System.Threading.ThreadStart(getfile));
                threadGetFile.ApartmentState = System.Threading.ApartmentState.STA;
                threadGetFile.Start();
        }
    }
}
