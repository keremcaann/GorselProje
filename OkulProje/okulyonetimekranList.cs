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
    public partial class okulyonetimekranList : Form
    {
        public okulyonetimekranList()
        {
            InitializeComponent();
        }
        keremdb1Entities31 db = new keremdb1Entities31();

        public string deger;

        void listele()
        {
            dataGridView1.DataSource = db.okulyonetimtablo.ToList();
            dataGridView1.Columns[4].Visible = false;

            var yonetimlist = db.okulyonetimtablo.ToList();


        }
        private void okulyonetimekranList_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
