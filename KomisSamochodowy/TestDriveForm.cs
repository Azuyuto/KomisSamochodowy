using KomisSamochodowy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomisSamochodowy
{
    public partial class TestDriveForm : Form
    {
        public TestDriveForm()
        {
            InitializeComponent();
            carListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            carListBox.MeasureItem += lst_MeasureItem;
            carListBox.DrawItem += lst_DrawItem;
            foreach (var car in SavedCarUtils.GetCars())
            {
                StringBuilder str = new StringBuilder("");
                str.Append(String.Format(@"{0} {1}, {2} {3}", car.Brand, car.CarModel, car.Engine, car.Color));
                foreach(var add in car.Additionals)
                {
                    str.Append(String.Format(@" + {0}", add));
                }
                if(car.StartDate != null && car.EndDate != null)
                {
                    str.Append(String.Format(@" [{0} - {1}]", car.StartDate.Value.ToShortDateString(), car.EndDate.Value.ToShortDateString()));
                }
                carListBox.Items.Add(new ListBoxItem() { Name = str.ToString(), ID = car.ID });
            }
        }

        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(carListBox.Items[e.Index].ToString(), carListBox.Font, carListBox.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(carListBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        private void carListBox_Select(object sender, EventArgs e)
        {
            var car = SavedCarUtils.GetByID(((ListBoxItem)carListBox.SelectedItem).ID);
            if(car.StartDate != null)
            {
                carCalendar.SelectionStart = car.StartDate.Value;
            }
            if (car.EndDate != null)
            {
                carCalendar.SelectionEnd = car.EndDate.Value;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var car = SavedCarUtils.GetByID(((ListBoxItem)carListBox.SelectedItem).ID);
            car.StartDate = carCalendar.SelectionStart;
            car.EndDate = carCalendar.SelectionEnd;
            SavedCarUtils.UpdateSavedCar(car);
            using (SuccessForm form = new SuccessForm())
            {
                form.ShowDialog(this);
                LayoutForm.Instance.OpenTestDrive();
            }
        }
    }
}
