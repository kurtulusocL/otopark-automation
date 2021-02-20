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
    public partial class frmOtoparkArea : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public frmOtoparkArea()
        {
            InitializeComponent();
        }

        private void frmOtoparkArea_Load(object sender, EventArgs e)
        {
            ParkAreas();
            SaveParkAreas();

            var showPlaka = from x in db.CarParkInfoes
                        select new
                        {
                            x.Plaka,
                            x.CarParkId
                        };

            foreach (var item in showPlaka)
            {
                foreach (Control lbl in panel1.Controls)
                {
                    if (lbl.Name==item.CarParkId.ToString()&&lbl.BackColor==Color.Red)
                    {
                        lbl.Text = item.Plaka;
                    }
                }
                foreach (Control lbl in panel2.Controls)
                {
                    if (lbl.Name == item.CarParkId.ToString() && lbl.BackColor == Color.Red)
                    {
                        lbl.Text = item.Plaka;
                    }
                }
            }
        }

        private void SaveParkAreas()
        {
            var parkArea = from i in db.CarParks
                           select new
                           {
                               i.State,
                               i.Id,
                               i.ParkArea
                           };

            foreach (var item in parkArea)
            {
                foreach (Control lbl in panel1.Controls)
                {
                    if (item.State == "Boş" && item.ParkArea == lbl.Text)
                    {
                        lbl.BackColor = Color.Green;
                    }
                    else if (item.State == "Dolu" && item.ParkArea == lbl.Text)
                    {
                        lbl.BackColor = Color.Red;
                    }
                }

                foreach (Control lbl in panel2.Controls)
                {
                    if (item.State == "Boş" && item.ParkArea == lbl.Text)
                    {
                        lbl.BackColor = Color.Green;
                    }
                    else if (item.State == "Dolu" && item.ParkArea == lbl.Text)
                    {
                        lbl.BackColor = Color.Red;
                    }
                }
            }
        }

        private void ParkAreas()
        {
            int x = 1;
            int y = 1;
            int z = 11;

            foreach (Control item in panel1.Controls)
            {
                if (item is Label)
                {
                    item.Text = "A-" + x;
                    item.Name = x.ToString();
                    x++;
                }
            }
            foreach (Control item in panel2.Controls)
            {
                if (item is Label)
                {
                    item.Text = "B-" + y;
                    item.Name = z.ToString();
                    y++;
                    z++;
                }
            }
        }
    }
}
