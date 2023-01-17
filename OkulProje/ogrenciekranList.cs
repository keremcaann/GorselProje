using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProje
{
    public partial class ogrenciekranList : Form
    {
        public ogrenciekranList()
        {
            InitializeComponent();
        }
        keremdb1Entities31 db = new keremdb1Entities31();


        void listele()
        {

            dataGridView1.DataSource = db.ogrencilertablo.ToList();

            dataGridView1.Columns[6].Visible = false;
        }
        private void ogrenciekranList_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
