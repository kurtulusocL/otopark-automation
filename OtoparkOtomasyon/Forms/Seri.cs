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
    public partial class frmSeri : Form
    {
        public frmSeri()
        {
            InitializeComponent();
        }

        ApplicationDbContext db = new ApplicationDbContext();

        private void Clear()
        {
            txtId.Clear();
            txtSerie.Clear();
            cmbBrand.Text = "";
        }

        private void frmSeri_Load(object sender, EventArgs e)
        {
            BrandList();
            var comboList = db.CarBrands.OrderBy(i=>i.CreatedDate).ToList();
            cmbBrand.DataSource = comboList;
            cmbBrand.DisplayMember = "Name";
            cmbBrand.ValueMember = "Id";
        }

        private void BrandList()
        {
            listView1.Items.Clear();
            var list = from x in db.Serials
                       join y in db.CarBrands on
                        x.CarBrandId equals y.Id
                       select new
                       {
                           x.Id,
                           y.Name,
                           x.Seri
                       };

            foreach (var item in list)
            {
                ListViewItem listView = new ListViewItem(item.Id.ToString());
                listView.SubItems.Add(item.Name);
                listView.SubItems.Add(item.Seri);
                listView1.Items.Add(listView);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count > 0)
            {
                txtId.Text = secilen.SubItems[0].Text;
                cmbBrand.Text = secilen.SubItems[1].Text;
                txtSerie.Text = secilen.SubItems[2].Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int carBrandID = (int)cmbBrand.SelectedValue;
            var addSerie = new Serial();

            addSerie.CarBrandId = carBrandID;
            addSerie.Seri = txtSerie.Text;
            db.Serials.Add(addSerie);
            db.SaveChanges();

            Clear();
            MessageBox.Show("Ekleme İşlemi Başarılıdır.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            BrandList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListViewItem choisedId = listView1.SelectedItems[0];
            var deleteSerie = db.Serials.FirstOrDefault(i => i.Id == int.Parse(choisedId.SubItems[0].Text));

            db.Serials.Remove(deleteSerie);
            db.SaveChanges();

            Clear();
            MessageBox.Show("Silme İşlemi Başarılıdır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            BrandList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateSerie = db.Serials.FirstOrDefault(i => i.Id == id);
            updateSerie.CarBrandId = (int)cmbBrand.SelectedValue;
            updateSerie.Seri = txtSerie.Text;
            db.SaveChanges();

            Clear();
            MessageBox.Show("Araç Markası Güncellendi", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BrandList();
        }

        
    }
}
