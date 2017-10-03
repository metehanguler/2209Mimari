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
    public partial class UrunlerForm : Form
    {
        public UrunlerForm()
        {
            InitializeComponent();
        }

        private void UrunlerForm_Load(object sender, EventArgs e)
        {
            UrunlerORM orm = new UrunlerORM();
            dataGridView1.DataSource = orm.Listele();
        }
    }
}
