using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HISTORY
{
    public partial class History_harian : Form
    {
        public History_harian()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Box1.Text = "-------";
            Box2.Text = "-------";
            Box3.Text = "-------";
            Box4.Text = "Pergi Pratikum";
            ts1.Text = "-------";
            ts2.Text = "-------";
            ts3.Text = "-------";
            ts4.Text = "Terselesaikan";
            jam1.Text = "-------";
            jam2.Text = "-------";
            jam3.Text = "-------";
            jam4.Text = "10.00";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void History_harian_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
        
        }

        private void Senin_Click(object sender, EventArgs e)
        {
            Box1.Text = "Main Gensin Impek";
            Box2.Text = "Main Futsal";
            Box3.Text = "Main PANJIE";
            Box4.Text = "Main PEBEH";
            ts1.Text = "Terselesaikan";
            ts2.Text = "Terselesaikan";
            ts3.Text = "Terselesaikan";
            ts4.Text = "Terselesaikan";
            jam1.Text = "12.00";
            jam2.Text = "17.00";
            jam3.Text = "18.00";
            jam4.Text = "20.00";
           
        }

        private void Selasa_Click(object sender, EventArgs e)
        {
            Box1.Text = "Belajar Algoritma";
            Box2.Text = "Pergi Pengajian";
            Box3.Text = "Baca Al-Quran";
            Box4.Text = "Belajar KPL";
            ts1.Text = "Terselesaikan";
            ts2.Text = "Terselesaikan";
            ts3.Text = "Terselesaikan";
            ts4.Text = "Tidak Terselesaikan";
            jam1.Text = "12.00";
            jam2.Text = "05.00";
            jam3.Text = "16.45";
            jam4.Text = "14.00";

        }

        private void Kamis_Click(object sender, EventArgs e)
        {
            Box1.Text = "-------";
            Box2.Text = "-------";
            Box3.Text = "Olahraga Tinju";
            Box4.Text = "Belajar KPL";
            ts1.Text = "-------";
            ts2.Text = "-------";
            ts3.Text = "Terselesaikan";
            ts4.Text = "Terselesaikan";
            jam1.Text = "-------";
            jam2.Text = "-------";
            jam3.Text = "14.00";
            jam4.Text = "16.45";

        }

        private void Jumaat_Click(object sender, EventArgs e)
        {
            Box1.Text = "Bantu Orangtua";
            Box2.Text = "Belajar Hadis";
            Box3.Text = "Belajar Algoritma";
            Box4.Text = "Belajar KPL";
            ts1.Text = "Terselesaikan";
            ts2.Text = "Terselesaikan";
            ts3.Text = "Terselesaikan";
            ts4.Text = "Terselesaikan";
            jam1.Text = "10.00";
            jam2.Text = "12.00";
            jam3.Text = "14.00";
            jam4.Text = "16.45";

        }

        private void Sabtu_Click(object sender, EventArgs e)
        {
            Box1.Text = "Bantu Orangtua";
            Box2.Text = "Belajar Agama";
            Box3.Text = "Belajar Golang";
            Box4.Text = "Tournamen Pebeh";
            ts1.Text = "Terselesaikan";
            ts2.Text = "Terselesaikan";
            ts3.Text = "Terselesaikan";
            ts4.Text = "Terselesaikan";
            jam1.Text = "12.00";
            jam2.Text = "13.00";
            jam3.Text = "16.00";
            jam4.Text = "18.25";

        }
    }
}
