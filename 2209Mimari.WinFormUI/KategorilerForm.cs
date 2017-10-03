using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2209Mimari.ORM;
namespace _2209Mimari.WinFormUI
{
    public partial class KategorilerForm : Form
    {
        public KategorilerForm()
        {
            InitializeComponent();
        }

        private void KategorilerForm_Load(object sender, EventArgs e)
        {
            KategoriORM kt = new KategoriORM();
            dataGridView1.DataSource = kt.Listele();
        }
    }
}
