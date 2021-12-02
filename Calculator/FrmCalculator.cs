//Nama : Ema Devani Putri
//NIM : 20.11.3663
//Kelas : 20-S1IF-06

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void FrmEntry_OnProses (Calculator cal)
        {
            var a = int.Parse(cal.NilaiA);
            var b = Convert.ToInt32(cal.NilaiB);
            if(cal.Pilihan == 0)
            {
                lstHasil.Items.Add(string.Format("Hasil Penambahan: {0} + {1} = {2}", a, b, cal.Penambahan(a, b)));
            }
            else if(cal.Pilihan == 1)
            {
                lstHasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2}", a, b, cal.Pengurangan(a, b)));
            }
            else if(cal.Pilihan == 2)
            {
                lstHasil.Items.Add(string.Format("Hasil Perkalian: {0} x {1} = {2}", a, b, cal.Perkalian(a, b)));
            }
            else if(cal.Pilihan == 3)
            {
                lstHasil.Items.Add(string.Format("Hasil Pembagian: {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b)));
            }
        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmEntryCalculator frmEntry = new FrmEntryCalculator();
            frmEntry.OnProses += FrmEntry_OnProses;
            frmEntry.ShowDialog();
        }
    }
}
