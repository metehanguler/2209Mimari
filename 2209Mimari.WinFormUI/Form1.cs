using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2209Mimari.WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UrunlerForm uf = new UrunlerForm();
        KategorilerForm kt = new KategorilerForm();
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uf.IsDisposed)
            {
                uf = new UrunlerForm();
            }
            uf.MdiParent = this;
            uf.Show();
        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kt.IsDisposed)
            {
                kt = new KategorilerForm();
            }
            kt.MdiParent = this;
            kt.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
