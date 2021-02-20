using OtoparkOtomasyon.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void markaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.Show();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.Show();
        }

        private void btnSeri_Click(object sender, EventArgs e)
        {
            frmSeri seri = new frmSeri();
            seri.Show();
        }

        private void seriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeri seri = new frmSeri();
            seri.Show();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            frmCustomerList customer = new frmCustomerList();
            customer.Show();
        }

        private void btnOtoparkYer_Click(object sender, EventArgs e)
        {
            frmOtoparkArea otoparkArea = new frmOtoparkArea();
            otoparkArea.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatToolStripMenuItem.Text = DateTime.Now.ToString();
        }

        private void otoparkGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOtoparkEnter otoparkEnter = new frmOtoparkEnter();
            otoparkEnter.Show();
        }

        private void btnCarEnter_Click(object sender, EventArgs e)
        {
            frmOtoparkEnter otoparkEnter = new frmOtoparkEnter();
            otoparkEnter.Show();
        }

        private void btnCarLeave_Click(object sender, EventArgs e)
        {
            frmOtoparkLeave otoparkLeave = new frmOtoparkLeave();
            otoparkLeave.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void otoparkÇıkışıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOtoparkLeave otoparkLeave = new frmOtoparkLeave();
            otoparkLeave.Show();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            frmCustomerList customer = new frmCustomerList();
            customer.Show();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerList customer = new frmCustomerList();
            customer.Show();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSell satis = new frmSell();
            satis.Show();
        }
    }
}
