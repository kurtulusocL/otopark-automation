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
    public partial class frmOtoparkLeave : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();

        void AccountPrice()
        {
            try
            {
                lblLeaveTime.Text = DateTime.Now.ToString();
                TimeSpan fark;
                fark = (DateTime.Parse(lblLeaveTime.Text) - DateTime.Parse(lblEntre.Text));

                decimal price = 0;
                decimal time = 0;
                decimal totalPrice = 0;

                price = decimal.Parse(cmbPerHourPrice.Text);
                lblTime.Text = fark.TotalHours.ToString("0.00");
                time = decimal.Parse(lblTime.Text);
                totalPrice = price * time;
                lblTotalPrice.Text = totalPrice.ToString("0.00");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public frmOtoparkLeave()
        {
            InitializeComponent();
        }

        private void frmOtoparkLeave_Load(object sender, EventArgs e)
        {
            cmbPerHourPrice.SelectedIndex = 0;
            
            FullorEmptyParkAreas();

            var getBrand = db.CarBrands.OrderBy(i => i.CreatedDate).ToList();
            cmbBrand.DataSource = getBrand;
            cmbBrand.DisplayMember = "Name";
            cmbBrand.ValueMember = "Id";
        }

        private void FullorEmptyParkAreas()
        {
            cmbPlakaSearch.Text = "";
            cmbPlakaSearch.Items.Clear();
            var getPlaka = db.CarParkInfoes.OrderBy(i => i.CreatedDate).ToList();
            foreach (var item in getPlaka)
            {
                cmbPlakaSearch.Items.Add(item.Plaka);
            }

            var emptyParkArea = db.CarParks.Where(i => i.State == "Boş").OrderBy(i => i.CreatedDate).ToList();
            cmbParkArea.DataSource = emptyParkArea;
            cmbParkArea.DisplayMember = "ParkArea";
            cmbParkArea.ValueMember = "Id";

            var fullParkArea = db.CarParks.Where(i => i.State == "Dolu").OrderBy(i => i.CreatedDate).ToList();
            cmbParkAreaSearch.DataSource = fullParkArea;
            cmbParkAreaSearch.DisplayMember = "ParkArea";
            cmbParkAreaSearch.ValueMember = "Id";
            cmbParkAreaSearch.Text = "";
            cmbParkArea.Text = "";
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var getSeri = db.Serials.Where(i => i.CarBrandId == (int)cmbBrand.SelectedValue).ToList();
                cmbSerie.DataSource = getSeri;
                cmbSerie.DisplayMember = "Seri";
                cmbSerie.ValueMember = "Id";
            }
            catch (Exception)
            {
            }
        }

        private void cmbBrand_ValueMemberChanged(object sender, EventArgs e)
        {
            var getSeri = db.Serials.Where(i => i.CarBrandId == (int)cmbBrand.SelectedValue).ToList();
            cmbSerie.DataSource = getSeri;
            cmbSerie.DisplayMember = "Seri";
            cmbSerie.ValueMember = "Id";
        }

        private void txtIDSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtIDSearch.Text == "")
            {
                foreach (Control item in pnlInfo.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            #region IdSearch
            var idSearch = (from x in db.CarParkInfoes
                            join y in db.CarBrands on
                             x.CarBrandId equals y.Id
                            join z in db.Serials on
                            x.SerialId equals z.Id
                            join q in db.CarParks on
                            x.CarParkId equals q.Id
                            select new
                            {
                                x.Id,
                                x.CustomerId,
                                x.NameSurname,
                                x.PhoneNumber,
                                x.Plaka,
                                x.Color,
                                x.Description,
                                x.CreatedDate,
                                y.Name,
                                z.Seri,
                                q.ParkArea
                            }).Where(i => i.Id.ToString() == txtIDSearch.Text).ToList();
            foreach (var item in idSearch)
            {
                txtId.Text = item.Id.ToString();
                txtCustomerId.Text = item.CustomerId.ToString();
                txtNameSurname.Text = item.NameSurname;
                txtPhone.Text = item.PhoneNumber;
                cmbBrand.Text = item.Name;
                cmbSerie.Text = item.Seri;
                txtPlaka.Text = item.Plaka;
                txtColor.Text = item.Color;
                cmbParkArea.Text = item.ParkArea;
                txtDesc.Text = item.Description;
                lblEntre.Text = item.CreatedDate.ToLongDateString();
                AccountPrice();
            }
            #endregion
        }

        private void txtCustomerIDSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerIDSearch.Text == "")
            {
                foreach (Control item in pnlInfo.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            #region CustomerIdSearch
            var customerIdSearch = (from x in db.CarParkInfoes
                                    join y in db.CarBrands on
                                     x.CarBrandId equals y.Id
                                    join z in db.Serials on
                                    x.SerialId equals z.Id
                                    join q in db.CarParks on
                                    x.CarParkId equals q.Id
                                    select new
                                    {
                                        x.Id,
                                        x.CustomerId,
                                        x.NameSurname,
                                        x.PhoneNumber,
                                        x.Plaka,
                                        x.Color,
                                        x.Description,
                                        x.CreatedDate,
                                        y.Name,
                                        z.Seri,
                                        q.ParkArea
                                    }).Where(i => i.CustomerId.ToString() == txtCustomerIDSearch.Text).ToList();
            foreach (var item in customerIdSearch)
            {
                txtId.Text = item.Id.ToString();
                txtCustomerId.Text = item.CustomerId.ToString();
                txtNameSurname.Text = item.NameSurname;
                txtPhone.Text = item.PhoneNumber;
                cmbBrand.Text = item.Name;
                cmbSerie.Text = item.Seri;
                txtPlaka.Text = item.Plaka;
                txtColor.Text = item.Color;
                cmbParkArea.Text = item.ParkArea;
                txtDesc.Text = item.Description;
                lblEntre.Text = item.CreatedDate.ToLongDateString();
                AccountPrice();
            }
            #endregion
        }

        private void txNameSurnameSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtNameSurnameSearch.Text == "")
            {
                foreach (Control item in pnlInfo.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            #region CustomerNameSurnameSearch
            var customerNameSurnameSearch = (from x in db.CarParkInfoes
                                             join y in db.CarBrands on
                                              x.CarBrandId equals y.Id
                                             join z in db.Serials on
                                             x.SerialId equals z.Id
                                             join q in db.CarParks on
                                             x.CarParkId equals q.Id
                                             select new
                                             {
                                                 x.Id,
                                                 x.CustomerId,
                                                 x.NameSurname,
                                                 x.PhoneNumber,
                                                 x.Plaka,
                                                 x.Color,
                                                 x.Description,
                                                 x.CreatedDate,
                                                 y.Name,
                                                 z.Seri,
                                                 q.ParkArea
                                             }).Where(i => i.NameSurname.ToString() == txtNameSurnameSearch.Text).ToList();
            foreach (var item in customerNameSurnameSearch)
            {
                txtId.Text = item.Id.ToString();
                txtCustomerId.Text = item.CustomerId.ToString();
                txtNameSurname.Text = item.NameSurname;
                txtPhone.Text = item.PhoneNumber;
                cmbBrand.Text = item.Name;
                cmbSerie.Text = item.Seri;
                txtPlaka.Text = item.Plaka;
                txtColor.Text = item.Color;
                cmbParkArea.Text = item.ParkArea;
                txtDesc.Text = item.Description;
                lblEntre.Text = item.CreatedDate.ToLongDateString();
                AccountPrice();
            }
            #endregion
        }

        private void cmbPlakaSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region PlakaSearch
            var plakaSearch = (from x in db.CarParkInfoes
                               join y in db.CarBrands on
                                x.CarBrandId equals y.Id
                               join z in db.Serials on
                               x.SerialId equals z.Id
                               join q in db.CarParks on
                               x.CarParkId equals q.Id
                               select new
                               {
                                   x.Id,
                                   x.CustomerId,
                                   x.NameSurname,
                                   x.PhoneNumber,
                                   x.Plaka,
                                   x.Color,
                                   x.Description,
                                   x.CreatedDate,
                                   y.Name,
                                   z.Seri,
                                   q.ParkArea
                               }).Where(i => i.Plaka.ToString() == cmbPlakaSearch.Text).ToList();
            foreach (var item in plakaSearch)
            {
                txtId.Text = item.Id.ToString();
                txtCustomerId.Text = item.CustomerId.ToString();
                txtNameSurname.Text = item.NameSurname;
                txtPhone.Text = item.PhoneNumber;
                cmbBrand.Text = item.Name;
                cmbSerie.Text = item.Seri;
                txtPlaka.Text = item.Plaka;
                txtColor.Text = item.Color;
                cmbParkArea.Text = item.ParkArea;
                txtDesc.Text = item.Description;
                lblEntre.Text = item.CreatedDate.ToLongDateString();
                AccountPrice();
            }
            #endregion
        }

        private void cmbParkAreaSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region ParkAreaSearch
            var parkAreaSearch = (from x in db.CarParkInfoes
                                  join y in db.CarBrands on
                                   x.CarBrandId equals y.Id
                                  join z in db.Serials on
                                  x.SerialId equals z.Id
                                  join q in db.CarParks on
                                  x.CarParkId equals q.Id
                                  select new
                                  {
                                      x.Id,
                                      x.CustomerId,
                                      x.NameSurname,
                                      x.PhoneNumber,
                                      x.Plaka,
                                      x.Color,
                                      x.Description,
                                      x.CreatedDate,
                                      y.Name,
                                      z.Seri,
                                      q.ParkArea
                                  }).Where(i => i.ParkArea.ToString() == cmbParkAreaSearch.Text).ToList();
            foreach (var item in parkAreaSearch)
            {
                txtId.Text = item.Id.ToString();
                txtCustomerId.Text = item.CustomerId.ToString();
                txtNameSurname.Text = item.NameSurname;
                txtPhone.Text = item.PhoneNumber;
                cmbBrand.Text = item.Name;
                cmbSerie.Text = item.Seri;
                txtPlaka.Text = item.Plaka;
                txtColor.Text = item.Color;
                cmbParkArea.Text = item.ParkArea;
                txtDesc.Text = item.Description;
                lblEntre.Text = item.CreatedDate.ToLongDateString();
                AccountPrice();
            }
            #endregion
        }

        private void cmbPlakaSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbPlakaSearch.Text == "")
            {
                foreach (Control item in pnlInfo.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void cmbParkAreaSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbParkAreaSearch.Text == "")
            {
                foreach (Control item in pnlInfo.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnParkAreaUpdate_Click(object sender, EventArgs e)
        {
            var fullPArkAreaChange = db.CarParks.FirstOrDefault(i => i.ParkArea == cmbParkAreaSearch.Text);
            fullPArkAreaChange.State = "Boş";
            db.SaveChanges();

            var emptyPArkAreaChange = db.CarParks.FirstOrDefault(i => i.ParkArea == cmbParkArea.Text);
            emptyPArkAreaChange.State = "Dolu";
            db.SaveChanges();

            var carParkAreaChange = db.CarParkInfoes.FirstOrDefault(i => i.Plaka == txtPlaka.Text);
            carParkAreaChange.CarParkId = (int)cmbParkArea.SelectedValue;
            db.SaveChanges();
            MessageBox.Show("Park Yeri Durumu Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbParkAreaSearch.Items.Clear();
            FullorEmptyParkAreas();
            btnClear.PerformClick();
            lblTime.Text = "0.00";
            lblTotalPrice.Text = "0.00";
            lblEntre.Text = DateTime.Now.ToString();
            lblLeaveTime.Text = DateTime.Now.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control item in pnlSearch.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in pnlIslem.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in pnlInfo.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    if (item != cmbPerHourPrice)
                    {
                        item.Text = "";
                    }
                }
            }
            lblTime.Text = "0.00";
            lblTotalPrice.Text = "0.00";
            lblEntre.Text = DateTime.Now.ToString();
            lblLeaveTime.Text = DateTime.Now.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CarOtoparkDelete();

            MessageBox.Show("Araç Park Yeri Kaydı Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbParkAreaSearch.Items.Clear();
            FullorEmptyParkAreas();
            btnClear.PerformClick();
            lblTime.Text = "0.00";
            lblTotalPrice.Text = "0.00";
            lblEntre.Text = DateTime.Now.ToString();
            lblLeaveTime.Text = DateTime.Now.ToString();
        }

        private void CarOtoparkDelete()
        {
            var deleteParkInfo = db.CarParkInfoes.FirstOrDefault(i => i.Plaka == txtPlaka.Text);
            db.CarParkInfoes.Remove(deleteParkInfo);
            db.SaveChanges();

            var carParkEmpty = db.CarParks.FirstOrDefault(i => i.ParkArea == cmbParkArea.Text);
            carParkEmpty.State = "Boş";
            db.SaveChanges();
        }

        private void btnCarLeave_Click(object sender, EventArgs e)
        {
            if (cmbParkAreaSearch.Text != "")
            {
                var addCar = new Sell();
                addCar.Id = int.Parse(txtId.Text);
                addCar.CustomerId = int.Parse(txtCustomerId.Text);
                addCar.NameSurname = txtNameSurname.Text;
                addCar.PhoneNumber = txtPhone.Text;
                addCar.CarBrandId = (int)cmbBrand.SelectedValue;
                addCar.SerialId = (int)cmbSerie.SelectedValue;
                addCar.Plaka = txtPlaka.Text;
                addCar.Year = "Belirtilmedi";
                addCar.Color = txtColor.Text;
                addCar.CarParkId = (int)cmbParkAreaSearch.SelectedValue;
                addCar.TimePrice = decimal.Parse(cmbPerHourPrice.Text);
                addCar.Time = decimal.Parse(lblTime.Text);
                addCar.TotalPrice = decimal.Parse(lblTotalPrice.Text);
                addCar.Description = txtDesc.Text;
                addCar.CreatedDate = DateTime.Parse(lblEntre.Text);
                addCar.LeaveTime = DateTime.Parse(lblLeaveTime.Text);

                db.Sells.Add(addCar);
                db.SaveChanges();

                MessageBox.Show("Araç Çıkışı Yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarOtoparkDelete();
                FullorEmptyParkAreas();
                btnClear.PerformClick();

                lblTime.Text = "0.00";
                lblTotalPrice.Text = "0.00";
                lblEntre.Text = addCar.CreatedDate.ToShortDateString();
                lblLeaveTime.Text = DateTime.Now.ToString();
            }
            else
            {
                MessageBox.Show("Boş park yerlerinin seçilmesi gerekir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbPerHourPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccountPrice();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateOtopark = db.CarParkInfoes.FirstOrDefault(i => i.Id.ToString() == txtId.Text);
            updateOtopark.CarBrandId = (int)cmbBrand.SelectedValue;
            updateOtopark.SerialId = (int)cmbSerie.SelectedValue;
            updateOtopark.Plaka = txtPlaka.Text;
            updateOtopark.Color = txtColor.Text;
            updateOtopark.Description = txtDesc.Text;
            db.SaveChanges();

            MessageBox.Show("Otopark Güncelleme İşlemi Yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarOtoparkDelete();
            FullorEmptyParkAreas();
            btnClear.PerformClick();

            lblTime.Text = "0.00";
            lblTotalPrice.Text = "0.00";
            lblEntre.Text = updateOtopark.CreatedDate.ToShortDateString();
            lblLeaveTime.Text = DateTime.Now.ToString();
        }
    }
}