using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DoAn
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        void showfrom()
        {
            frmMain frmm = new frmMain();
            frmm.ShowDialog();
            this.Close();
        }

        private void btstar_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(showfrom));
            th.Start();
            this.Close();
            
        }
    }
}
