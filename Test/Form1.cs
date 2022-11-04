using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            
                int ay = 0;

                if (cmbMonth.Text == "Yanvar") ay = 1;
                if (cmbMonth.Text == "Fevral") ay = 2;
                if (cmbMonth.Text == "Mart") ay = 3;
                if (cmbMonth.Text == "Aprel") ay = 4;
                if (cmbMonth.Text == "May") ay = 5;
                if (cmbMonth.Text == "Iyun") ay = 6;
                if (cmbMonth.Text == "Iyul") ay = 7;
                if (cmbMonth.Text == "Avgust") ay = 8;
                if (cmbMonth.Text == "Sentaybr") ay = 9;
                if (cmbMonth.Text == "Oktyabr") ay = 10;
                if (cmbMonth.Text == "Noyabr") ay = 11;
                if (cmbMonth.Text == "Dekabr") ay = 12;

                int gunler = DateTime.DaysInMonth(Int32.Parse(txtYear.Text), ay);

                int ildeGun = 0;
            
                for (int i = 1; i <= 12; i++)
                {
                    int gun = DateTime.DaysInMonth(Int32.Parse(txtYear.Text), i);
                    ildeGun = ildeGun + gun;

                }

                lblDate.Text = txtYear.Text + "- ci il " + cmbMonth.Text + " ayında " + gunler.ToString() + " gün var";
                lblDayInYear.Text = txtYear.Text + "- ci ildə " + ildeGun + " gün var";

        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
