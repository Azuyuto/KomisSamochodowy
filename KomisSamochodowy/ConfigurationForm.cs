using KomisSamochodowy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomisSamochodowy
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
            FillBrands();
        }

        private void FillBrands()
        {
            foreach (var item in CarUtils.GetBrands())
            {
                brandSelect.Items.Add(item);
            }
        }

        private void FillCarModels()
        {
            carModelSelect.Items.Clear();
            foreach (var item in CarUtils.GetCarModels(brandSelect.Text))
            {
                carModelSelect.Items.Add(item);
            }
        }

        private void FillEngines()
        {
            engineSelect.Items.Clear();
            foreach (var item in CarUtils.GetEngines(brandSelect.Text, carModelSelect.Text))
            {
                engineSelect.Items.Add(item);
            }
        }

        private void FillColors()
        {
            colorSelect.Items.Clear();
            foreach (var item in CarUtils.GetColors(brandSelect.Text, carModelSelect.Text))
            {
                colorSelect.Items.Add(item);
            }
        }

        private void FillAdditionals()
        {
            additionalListBox.Items.Clear();
            foreach (var item in CarUtils.GetAdditionals(brandSelect.Text, carModelSelect.Text))
            {
                additionalListBox.Items.Add(item);
            }
        }

        private void brandSelect_Changed(object sender, EventArgs e)
        {
            FillCarModels();
        }

        private void carModelSelect_Changed(object sender, EventArgs e)
        {
            FillEngines();
            FillColors();
            FillAdditionals();

            var fileName = CarUtils.GetCars().Where(a => a.Brand == brandSelect.Text && a.CarModel == carModelSelect.Text).FirstOrDefault().ImageCarPath;
            var enviroment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(enviroment).Parent.FullName;
            var path = String.Format(@"{0}\Images\Cars\{1}", projectDirectory, fileName);
            carPictureBox.Image = Image.FromFile(path);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            brandSelect.Text = null;
            carModelSelect.Text = null;
            carModelSelect.Items.Clear();
            engineSelect.Items.Clear();
            colorSelect.Items.Clear();
            additionalListBox.Items.Clear();
            carPictureBox.Image = null;
            carPictureBox.Name = null;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var additionals = new List<string>();
            for (int i = 0; i < additionalListBox.Items.Count; i++)
            {
                if (additionalListBox.GetItemChecked(i))
                {
                    additionals.Add(additionalListBox.GetItemText(additionalListBox.Items[i]));
                }
            }

            SavedCarUtils.AddCar(new SavedCar()
            {
                Brand = brandSelect.Text,
                CarModel = carModelSelect.Text,
                Engine = engineSelect.Text,
                Color = colorSelect.Text,
                Additionals = additionals
            });

            using (SuccessForm form = new SuccessForm())
            {
                form.ShowDialog(this);
                Reset();
            }
        }
    }
}
