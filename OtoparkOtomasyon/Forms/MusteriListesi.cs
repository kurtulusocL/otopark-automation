using OtoparkOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon.Forms
{
    public partial class frmCustomerList : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();

        private void Clear()
        {
            txtId.Clear();
            txtMail.Clear();
            txtNameSurname.Clear();
            txtPhone.Clear();
            rTextAddress.Clear();
            pictureBox1.ImageLocation = "";
        }

        public frmCustomerList()
        {
            InitializeComponent();
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customers.OrderBy(i => i.CreatedDate).ToList();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            var search = from x in db.Customers
                         where x.Id.ToString() == txtId.Text
                         select x;

            foreach (var item in search)
            {
                txtNameSurname.Text = item.NameSurname;
                txtPhone.Text = item.PhoneNumber;
                txtMail.Text = item.EMail;
                rTextAddress.Text = item.Adress;
                pictureBox1.ImageLocation = item.Photo;
                item.CreatedDate = Convert.ToDateTime(DateTime.Now.ToLocalTime());
                item.UpdatedTime = Convert.ToDateTime(DateTime.Now.ToLocalTime());
            }
            //if (txtId.Text=="")
            //{
            //    Clear();
            //}
        }

        private void btnChoisePic_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addCustomer = new Customer();

            addCustomer.NameSurname = txtNameSurname.Text;
            addCustomer.EMail = txtMail.Text;
            addCustomer.Adress = rTextAddress.Text;
            addCustomer.PhoneNumber = txtPhone.Text;
            addCustomer.Photo = pictureBox1.ImageLocation;
            addCustomer.CreatedDate= Convert.ToDateTime(DateTime.Now.ToLocalTime());

            db.Customers.Add(addCustomer);
            db.SaveChanges();
            Clear();
            MessageBox.Show("Ekleme İşlemi Başarılıdır.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Customers.OrderBy(i => i.CreatedDate).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var deleteCustomer = db.Customers.FirstOrDefault(i => i.Id == id);

            db.Customers.Remove(deleteCustomer);
            db.SaveChanges();
            Clear();
            MessageBox.Show("Silme İşlemi Başarılıdır.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Customers.OrderBy(i => i.CreatedDate).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer cust = new Customer();
            DataGridViewRow row = dataGridView1.CurrentRow;

            txtNameSurname.Text = row.Cells["NameSurname"].Value.ToString();
            txtNameSurname.Tag = row.Cells["Id"].Value;
            txtMail.Text = row.Cells["EMail"].Value.ToString();
            rTextAddress.Text= row.Cells["Adress"].Value.ToString();
            txtPhone.Text= row.Cells["PhoneNumber"].Value.ToString();            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateCustomer = db.Customers.FirstOrDefault(i => i.Id == id);

            updateCustomer.NameSurname = txtNameSurname.Text;
            updateCustomer.EMail = txtMail.Text;
            updateCustomer.Adress = rTextAddress.Text;
            updateCustomer.PhoneNumber = txtPhone.Text;
            updateCustomer.Photo = pictureBox1.ImageLocation;
            updateCustomer.UpdatedTime = Convert.ToDateTime(DateTime.Now.ToLocalTime());

            db.Customers.Add(updateCustomer);
            db.SaveChanges();
            Clear();
            MessageBox.Show("Güncelleme İşlemi Başarılıdır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = db.Customers.OrderBy(i => i.CreatedDate).ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customers.Where(i => i.NameSurname.Contains(txtSearch.Text)).ToList();
        }

        
    }
}
