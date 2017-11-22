using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    
    public partial class Frmxuat : Form
    {
        int[] L = new int[100];
        int[] S = new int[100];
        int n;
        int[,] Dn;
        public Frmxuat()
        {
            InitializeComponent();
        }
        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public int[,] DN
        {
            get { return Dn; }
            set { Dn = value; }
        }

        private void Frmxuat_Load(object sender, EventArgs e)
        {
            int t;
            int temp = 0;
            int temp1 = 0;
            int temp2 = 0;
            //do lech tam
            string[] arr = new string[1000];
            string[] arr1 = new string[1000];
            string[] arr2 = new string[1000];
            for (int i = 0; i < n; i++)
            {
                t = 0;
                for (int j = 0; j < n; j++)
                    if (t < Dn[i, j]) t = Dn[i, j];
                L[i] = t;
            }
            //min lech tam
            int minl = L[0];
            
            for(int i=1;i<n;i++)
            {
                if (minl > L[i]) minl=L[i];
            }
            //danh sach lech tam
            int[] dsL = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (L[i]==minl)
                {
                    dsL[temp1] = i+1;
                    temp1++;
                }
            }
            //tong
            S = new int[n];
            int s;
            for (int i = 0; i < n; i++)
            {
                s = 0;
                for (int j = 0; j < n; j++)
                    s += Dn[i, j];
                S[i] = s;
            }
            //min tong
            int mins = S[0];
            for (int i = 1; i < n; i++)
            {
                if (mins > S[i]) mins = S[i];
            }
            //danh sach tong
            int[] dsT = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (S[i] == mins)
                {
                    dsT[temp2] = i+1;
                    temp2++;
                }
            }
            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    listView1.Columns.Add("Đỉnh", 60);
                }
                else
                {
                    listView1.Columns.Add(i.ToString(), 40);
                }
                for (int j = 0; j <= n; j++)
                {
                    if (i == n)
                    {
                        arr[j] = "";
                    }
                    else if (i < n && j == 0)
                    {
                        arr[j] = (i + 1).ToString();
                        temp = 0;
                    }
                    else if (i < n && j != 0)
                    {
                        arr[j] = Dn[i, temp].ToString();
                        temp++;
                    }
                }
                ListViewItem item = new ListViewItem(arr);
                listView1.Items.Add(item);
            }
            for (int i = 0; i <= n+1; i++)
            {
                if (i == 0)
                {
                    listView2.Columns.Add("Đỉnh", 60);
                }
                else if (i > 0 && i < n + 1)
                {
                    listView2.Columns.Add(i.ToString(), 40);
                }
                else if (i == n + 1)
                {
                    listView2.Columns.Add("Min", 60);
                }
                for (int j = 0; j <= n+1; j++)
                {
                    if (i > 0)
                    {
                        arr1[j] = "";
                    }
                    else if (i == 0 && j == 0)
                    {
                        arr1[j] = "Độ lệch";
                    }
                    else if (i == 0 && j > 0 && j < n + 1)
                    {
                        arr1[j] = L[j - 1].ToString();
                    }
                    else if (i == 0 && j == n + 1)
                    {
                        arr1[j] = minl.ToString();
                    }

                }
                ListViewItem item1 = new ListViewItem(arr1);
                listView2.Items.Add(item1);
            }
            for (int i = 0; i <= n + 1; i++)
            {
                if (i == 0)
                {
                    listView3.Columns.Add("Đỉnh", 60);
                }
                else if (i > 0 && i < n + 1)
                {
                    listView3.Columns.Add(i.ToString(), 40);
                }
                else if (i == n + 1)
                {
                    listView3.Columns.Add("Min", 60);
                }
                for (int j = 0; j <= n + 1; j++)
                {
                    if (i > 0)
                    {
                        arr2[j] = "";
                    }
                    else if (i == 0 && j == 0)
                    {
                        arr2[j] = "Tổng";
                    }
                    else if (i == 0 && j > 0 && j < n + 1)
                    {
                        arr2[j] = S[j - 1].ToString();
                    }
                    else if (i == 0 && j == n + 1)
                    {
                        arr2[j] = mins.ToString();
                    }

                }
                ListViewItem item2 = new ListViewItem(arr2);
                listView3.Items.Add(item2);
            }
            lbctieu.Text ="   "+ minl.ToString()+"   ";
            lbctong.Text ="   "+ mins.ToString()+"   ";
            for(int i=0;i<temp1;i++)
            {
                    lbdctieu.Text +=" "+ dsL[i].ToString() + " ";
            }
            for (int i = 0; i < temp2; i++)
            {
                lbdctong.Text += " " + dsT[i].ToString() + " ";
            }
        }
    }
}
