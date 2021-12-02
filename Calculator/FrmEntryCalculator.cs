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
    public partial class FrmEntryCalculator : Form
    {
        public delegate void ProsesEventHandler(Calculator cal);
        public event ProsesEventHandler OnProses;
        private bool isNewData = true;
        private Calculator cal;

        public FrmEntryCalculator()
        {
            InitializeComponent();
        }

        public FrmEntryCalculator(string hasil)
            : this()
        {
            this.Text = hasil;
        }

        public FrmEntryCalculator(string hasil, Calculator obj)
            : this()
        {
            this.Text = hasil;

            isNewData = false;
            cal = obj;

            txtNilaiA.Text = cal.NilaiA;
            txtNilaiB.Text = cal.NilaiB;
            cmbOperasi.SelectedIndex = cal.Pilihan;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (isNewData) cal = new Calculator();
            cal.NilaiA = txtNilaiA.Text;
            cal.NilaiB = txtNilaiB.Text;
            cal.Pilihan = cmbOperasi.SelectedIndex;

            OnProses(cal);
        }
    }
}
