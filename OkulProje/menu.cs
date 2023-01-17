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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciekran ogrpanel = new ogrenciekran();
            ogrpanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            okulyönetimekran oklyonetim = new okulyönetimekran();
            oklyonetim.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dersekran derspanel = new dersekran();
            derspanel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ogrencidersekran derspanel = new ogrencidersekran();
            derspanel.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void şToolStripMenuItem_Click(object sender, EventArgs e)
        {
            okulyonetimekranList okulyonetimekranListA = new okulyonetimekranList();
            okulyonetimekranListA.Show();
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dersekran dersekrander = new dersekran();
            dersekrander.Show();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dersekranList dersekranLisTt = new dersekranList();
            dersekranLisTt.Show();
        }

        private void girişToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ogrencidersekran ogrencidersekrander = new ogrencidersekran();
            ogrencidersekrander.Show();
        }

        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ogrencidersekranList ogrencidersekranT = new ogrencidersekranList();
            ogrencidersekranT.Show();
        }

        private void girişToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ogrenciekran ogrenciekrander = new ogrenciekran();
            ogrenciekrander.Show();
        }

        private void listeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ogrenciekranList ogrenciekranA = new ogrenciekranList();
            ogrenciekranA.Show();
        }

        private void girişToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            okulyönetimekran okulyönetimekranA = new okulyönetimekran();
            okulyönetimekranA.Show();
        }
    }
}
