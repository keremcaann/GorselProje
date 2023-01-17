using OkulProje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keremodev
{
    public partial class dersekran : Form
    {
        public dersekran()
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

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtdersad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtkredi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {

            derstablo ekle = new derstablo();
            ekle.dersadi = txtdersad.Text;
            ekle.derskredisi = txtkredi.Text;
            ekle.dersokulyonetimid = Convert.ToInt16(comboBox1.SelectedValue);
            db.derstablo.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Ders Kaydedilmiştir.", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        

        

        

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var ogretmenler = (from x in db.okulyonetimtablo
                                   where x.yonetimtipi == "12"
                                   select new
                                   {
                                       x.yonetimid,
                                       x.yonetimadsoyad

                                   }).ToList();
                foreach (var item in ogretmenler)
                {
                    e.Value = item.yonetimadsoyad;
                }




            }
        }

        private void DersPaneli_Load(object sender, EventArgs e)
        {
            listele();
            var ogretmenler = (from x in db.okulyonetimtablo
                               where x.yonetimtipi == "12"
                               select new
                               {
                                   x.yonetimid,
                                   x.yonetimadsoyad

                               }).ToList();

            comboBox1.ValueMember = "yonetimid";
            comboBox1.DisplayMember = "yonetimadsoyad";
            comboBox1.DataSource = ogretmenler;
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int DersID = Convert.ToInt32(txtid.Text);

            var guncelle = db.derstablo.Find(DersID);
            guncelle.dersadi = txtdersad.Text;
            guncelle.derskredisi = txtkredi.Text;
            guncelle.dersokulyonetimid = Convert.ToInt16(comboBox1.SelectedValue);
            db.SaveChanges();
            MessageBox.Show("Ders Kayıdı Güncellenmiştir.", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
