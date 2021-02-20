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
    public partial class frmMarka : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();

        private void Clear()
        {
            txtBrand.Clear();
            txtBrandId.Clear();
        }

        public frmMarka()
        {
            InitializeComponent();
        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
            MarkaListele();
        }

        private void MarkaListele()
        {
            listView1.Items.Clear();
            var brandList = db.CarBrands.OrderBy(i => i.CreatedDate).ToList();

            for (int i = 0; i < brandList.Count; i++)
            {
                ListViewItem ekle = new ListViewItem(brandList[i].Id.ToString());
                ekle.SubItems.Add(brandList[i].Name);
                listView1.Items.Add(ekle);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count > 0)
            {
                txtBrandId.Text = secilen.SubItems[0].Text;
                txtBrand.Text = secilen.SubItems[1].Text;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var brandAdd = new CarBrand();
            brandAdd.Name = txtBrand.Text;

            db.CarBrands.Add(brandAdd);
            db.SaveChanges();
            Clear();
            MessageBox.Show("Araç Markası Eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListViewItem choisedId = listView1.SelectedItems[0];
            var deleteBrand = db.CarBrands.FirstOrDefault(i => i.Id == int.Parse(choisedId.SubItems[0].Text));

            db.CarBrands.Remove(deleteBrand);
            db.SaveChanges();
            Clear();
            MessageBox.Show("Araç Markası Silindi", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBrandId.Text);
            var updateBrand = db.CarBrands.FirstOrDefault(i => i.Id == id);
            updateBrand.Name = txtBrand.Text;
            db.SaveChanges();

            Clear();
            MessageBox.Show("Araç Markası Gücenllendi", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
        }
    }
}
