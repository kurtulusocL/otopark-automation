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
    public partial class frmOtoparkEnter : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();

        private void Clear()
        {
            txtColor.Clear();
            txtNameSurname.Clear();
            txtPhone.Clear();
            txtPlaka.Clear();
            rTextDesc.Clear();
            txtId.Clear();
            txtYear.Clear();
            cmbBrand.SelectedItem = "";
            cmbParkArea.SelectedItem = "";
            cmbSerie.SelectedItem = "";
        }

        public frmOtoparkEnter()
        {
            InitializeComponent();
        }

        private void frmOtoparkEnter_Load(object sender, EventArgs e)
        {
            var getBrand = db.CarBrands.ToList();
            cmbBrand.DataSource = getBrand;
            cmbBrand.DisplayMember = "Name";
            cmbBrand.ValueMember = "Id";

            GetParkArea();
        }

        private void GetParkArea()
        {
            var getparkArea = db.CarParks.Where(i => i.State == "Boş").OrderBy(i => i.CreatedDate).ToList();
            cmbParkArea.DataSource = getparkArea;
            cmbParkArea.DisplayMember = "ParkArea";
            cmbParkArea.ValueMember = "Id";
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var getSerie = db.Serials.Where(i => i.CarBrandId == (int)cmbBrand.SelectedValue).ToList();
                cmbSerie.DataSource = getSerie;
                cmbSerie.DisplayMember = "Seri";
                cmbSerie.ValueMember = "Id";
            }
            catch (Exception)
            {
            }
        }

        private void cmbBrand_ValueMemberChanged(object sender, EventArgs e)
        {
            var getSerie = db.Serials.Where(i => i.CarBrandId == (int)cmbBrand.SelectedValue).ToList();
            cmbSerie.DataSource = getSerie;
            cmbSerie.DisplayMember = "Seri";
            cmbSerie.ValueMember = "Id";
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var getCustomer = db.Customers.Where(i => i.Id.ToString() == txtId.Text).ToList();
                foreach (var item in getCustomer)
                {
                    txtNameSurname.Text = item.NameSurname;
                    txtPhone.Text = item.PhoneNumber;
                    if (txtId.Text == "")
                    {
                        txtNameSurname.Text = "";
                        txtPhone.Text = "";
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addCar = new CarParkInfo();
            addCar.CustomerId = int.Parse(txtId.Text);
            addCar.NameSurname = txtNameSurname.Text;
            addCar.PhoneNumber = txtPhone.Text;
            addCar.Plaka = txtPlaka.Text;
            addCar.CarBrandId = (int)cmbBrand.SelectedValue;
            addCar.CarParkId = (int)cmbParkArea.SelectedValue;
            addCar.SerialId = (int)cmbSerie.SelectedValue;
            addCar.Year = txtYear.Text;
            addCar.Color = txtColor.Text;
            addCar.Description = rTextDesc.Text;
            addCar.CreatedDate = DateTime.Now.ToLocalTime();

            db.CarParkInfoes.Add(addCar);
            db.SaveChanges();
            Clear();

            var parkYeriDoldur = db.CarParks.FirstOrDefault(i => i.Id == (int)cmbParkArea.SelectedValue);
            parkYeriDoldur.State = "Dolu";
            db.SaveChanges();
            GetParkArea();
            MessageBox.Show("Kayıt İşlemi Başarılıdır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
