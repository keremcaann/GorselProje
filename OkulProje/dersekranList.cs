using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OkulProje
{
    public partial class dersekranList : Form
    {
        public dersekranList()
        {
            InitializeComponent();
        }
        keremdb1Entities31 db = new keremdb1Entities31();





        void listele()
        {
            dataGridView1.DataSource = (from x in db.derstablo
                                        select new
                                        {
                                            x.dersid,
                                            x.dersadi,
                                            x.derskredisi,
                                            x.okulyonetimtablo.yonetimadsoyad

                                        }).ToList();



            //dataGridView1.Columns[4].Visible = false;

            var derslist = db.derstablo.ToList();


        }
        private void dersekranList_Load(object sender, EventArgs e)
        {
            listele();
            var ogretmenler = (from x in db.okulyonetimtablo
                               where x.yonetimtipi == "12"
                               select new
                               {
                                   x.yonetimid,
                                   x.yonetimadsoyad
                               }).ToList();

        }
    }
}