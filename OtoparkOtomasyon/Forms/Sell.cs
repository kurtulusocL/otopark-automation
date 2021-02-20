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
    public partial class frmSell : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public frmSell()
        {
            InitializeComponent();
        }

        private void frmSell_Load(object sender, EventArgs e)
        {
            FullDataGridView();
        }

        private void FullDataGridView()
        {
            var getList = (from x in db.Sells
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
                               y.Name,
                               z.Seri,
                               q.ParkArea,
                               x.Plaka,
                               x.Year,
                               x.Color,
                               x.Description,
                               x.TimePrice,
                               x.Time,
                               x.TotalPrice,
                               x.CreatedDate,
                               x.LeaveTime
                           }).ToList();
            dtGridView.DataSource = getList;
            lblTutar.Text = "Toplam Tutar" + ":" + db.Sells.Sum(i => i.TotalPrice);
            lblKayit.Text = "Toplam kayıt" + ":" + db.Sells.Count();
            lblOrtalama.Text = "Ortalama Tutar" + ":" + db.Sells.Average(i => i.TotalPrice);
            lblMax.Text = "En Yüksek Tutar" + ":" + db.Sells.Max(i => i.TotalPrice);
            lblMin.Text = "En Düşük Tutar" + ":" + db.Sells.Min(i => i.TotalPrice);
        }

        private void txtIDSearch_TextChanged(object sender, EventArgs e)
        {
            var getList = (from x in db.Sells
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
                               y.Name,
                               z.Seri,
                               q.ParkArea,
                               x.Plaka,
                               x.Year,
                               x.Color,
                               x.Description,
                               x.TimePrice,
                               x.Time,
                               x.TotalPrice,
                               x.CreatedDate,
                               x.LeaveTime
                           }).Where(i => i.Id.ToString() == txtIDSearch.Text).ToList();
            dtGridView.DataSource = getList;

            lblTutar.Text = "Toplam Tutar" + ":" + db.Sells.Sum(i => i.TotalPrice);
            lblKayit.Text = "Toplam kayıt" + ":" + db.Sells.Count();
            lblOrtalama.Text = "Ortalama Tutar" + ":" + db.Sells.Average(i => i.TotalPrice);
            lblMax.Text = "En Yüksek Tutar" + ":" + db.Sells.Max(i => i.TotalPrice);
            lblMin.Text = "En Düşük Tutar" + ":" + db.Sells.Min(i => i.TotalPrice);

            if (txtIDSearch.Text == "")
            {
                FullDataGridView();
            }
        }

        private void txtCustomerIDSearch_TextChanged(object sender, EventArgs e)
        {
            var getList = (from x in db.Sells
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
                               y.Name,
                               z.Seri,
                               q.ParkArea,
                               x.Plaka,
                               x.Year,
                               x.Color,
                               x.Description,
                               x.TimePrice,
                               x.Time,
                               x.TotalPrice,
                               x.CreatedDate,
                               x.LeaveTime
                           }).Where(i => i.CustomerId.ToString() == txtCustomerIDSearch.Text).ToList();
            dtGridView.DataSource = getList;

            if (txtCustomerIDSearch.Text == "")
            {
                FullDataGridView();
            }
        }

        private void txtNameSurnameSearch_TextChanged(object sender, EventArgs e)
        {
            var getList = (from x in db.Sells
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
                               y.Name,
                               z.Seri,
                               q.ParkArea,
                               x.Plaka,
                               x.Year,
                               x.Color,
                               x.Description,
                               x.TimePrice,
                               x.Time,
                               x.TotalPrice,
                               x.CreatedDate,
                               x.LeaveTime
                           }).Where(i => i.NameSurname.Contains(txtNameSurnameSearch.Text)).ToList();
            dtGridView.DataSource = getList;

            lblTutar.Text = "Toplam Tutar" + ":" + db.Sells.Sum(i => i.TotalPrice);
            lblKayit.Text = "Toplam kayıt" + ":" + db.Sells.Count();
            lblOrtalama.Text = "Ortalama Tutar" + ":" + db.Sells.Average(i => i.TotalPrice);
            lblMax.Text = "En Yüksek Tutar" + ":" + db.Sells.Max(i => i.TotalPrice);
            lblMin.Text = "En Düşük Tutar" + ":" + db.Sells.Min(i => i.TotalPrice);

            if (txtNameSurnameSearch.Text == "")
            {
                FullDataGridView();
            }
        }

        private void txtPlakaSearch_TextChanged(object sender, EventArgs e)
        {
            var getList = (from x in db.Sells
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
                               y.Name,
                               z.Seri,
                               q.ParkArea,
                               x.Plaka,
                               x.Year,
                               x.Color,
                               x.Description,
                               x.TimePrice,
                               x.Time,
                               x.TotalPrice,
                               x.CreatedDate,
                               x.LeaveTime
                           }).Where(i => i.Plaka.Contains(txtPlakaSearch.Text)).ToList();
            dtGridView.DataSource = getList;

            lblTutar.Text = "Toplam Tutar" + ":" + db.Sells.Sum(i => i.TotalPrice);
            lblKayit.Text = "Toplam kayıt" + ":" + db.Sells.Count();
            lblOrtalama.Text = "Ortalama Tutar" + ":" + db.Sells.Average(i => i.TotalPrice);
            lblMax.Text = "En Yüksek Tutar" + ":" + db.Sells.Max(i => i.TotalPrice);
            lblMin.Text = "En Düşük Tutar" + ":" + db.Sells.Min(i => i.TotalPrice);

            if (txtPlakaSearch.Text == "")
            {
                FullDataGridView();
            }
        }

        private void txtParkAreaSearch_TextChanged(object sender, EventArgs e)
        {
            var getList = (from x in db.Sells
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
                               y.Name,
                               z.Seri,
                               q.ParkArea,
                               x.Plaka,
                               x.Year,
                               x.Color,
                               x.Description,
                               x.TimePrice,
                               x.Time,
                               x.TotalPrice,
                               x.CreatedDate,
                               x.LeaveTime
                           }).Where(i => i.ParkArea.Contains(txtParkAreaSearch.Text)).ToList();
            dtGridView.DataSource = getList;

            lblTutar.Text = "Toplam Tutar" + ":" + db.Sells.Sum(i => i.TotalPrice);
            lblKayit.Text = "Toplam kayıt" + ":" + db.Sells.Count();
            lblOrtalama.Text = "Ortalama Tutar" + ":" + db.Sells.Average(i => i.TotalPrice);
            lblMax.Text = "En Yüksek Tutar" + ":" + db.Sells.Max(i => i.TotalPrice);
            lblMin.Text = "En Düşük Tutar" + ":" + db.Sells.Min(i => i.TotalPrice);

            if (txtParkAreaSearch.Text == "")
            {
                FullDataGridView();
            }
        }
    }
}
