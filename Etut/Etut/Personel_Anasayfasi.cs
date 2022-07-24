﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etut
{
    public partial class Personel_Anasayfasi : Form
    {
        public Personel_Anasayfasi()
        {
            InitializeComponent();
        }

        private void buttonOgrenciCikis1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkmak istiyor musunuz?",
                "Çıkış", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                this.Hide();
            }
        }

        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            Ogrenci_Ekleme_Sayfasi ekle = new Ogrenci_Ekleme_Sayfasi();
            ekle.Show();
        }

        private void buttonOgretmenEkle_Click(object sender, EventArgs e)
        {
            Ogretmen_Ekleme_Sayfasi syf = new Ogretmen_Ekleme_Sayfasi();
            syf.Show();
        }

        private void buttonEtutTakvimi1_Click(object sender, EventArgs e)
        {

        }
    }
}
