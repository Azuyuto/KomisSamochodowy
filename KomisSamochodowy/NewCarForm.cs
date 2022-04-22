using KomisSamochodowy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomisSamochodowy
{
    public partial class NewCarForm : Form
    {
        public NewCarForm()
        {
            InitializeComponent();
            FillBrands();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.png;)|*.jpg;*.jpeg;*.gif;*.png;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                carPictureBox.Image = new Bitmap(opnfd.FileName);
                carPictureBox.Name = Path.GetExtension(opnfd.FileName);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var fileName = String.Format(@"{0}-{1}{2}", brandSelect.Text, carModelSelect.Text, carPictureBox.Name);
            var enviroment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(enviroment).Parent.FullName;
            var path = String.Format(@"{0}\Images\Cars\{1}", projectDirectory, fileName);
            carPictureBox.Image.Save(path);

            var engines = new List<string>();
            for (int i = 0; i < engineListBox.Items.Count; i++)
            {
                if (engineListBox.GetItemChecked(i))
                {
                    engines.Add(engineListBox.GetItemText(engineListBox.Items[i]));
                }
            }

            var colors = new List<string>();
            for (int i = 0; i < colorListBox.Items.Count; i++)
            {
                if (colorListBox.GetItemChecked(i))
                {
                    colors.Add(colorListBox.GetItemText(colorListBox.Items[i]));
                }
            }

            var additionals = new List<string>();
            for (int i = 0; i < additionalListBox.Items.Count; i++)
            {
                if (additionalListBox.GetItemChecked(i))
                {
                    additionals.Add(additionalListBox.GetItemText(additionalListBox.Items[i]));
                }
            }

            CarUtils.AddCar(new Car()
            {
                Brand = brandSelect.Text,
                CarModel = carModelSelect.Text,
                Engines = engines,
                Colors = colors,
                Additionals = additionals,
                ImageCarPath = fileName
            });

            using (SuccessForm form = new SuccessForm())
            {
                form.ShowDialog(this);
                Reset();
            }
        }

        private void FillBrands()
        {
            foreach(var item in CarUtils.GetBrands())
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
            engineListBox.Items.Clear();
            foreach (var item in CarUtils.GetEngines(brandSelect.Text))
            {
                engineListBox.Items.Add(item);
            }
        }

        private void FillColors()
        {
            colorListBox.Items.Clear();
            foreach (var item in CarUtils.GetColors(brandSelect.Text))
            {
                colorListBox.Items.Add(item);
            }
        }

        private void FillAdditionals()
        {
            additionalListBox.Items.Clear();
            foreach (var item in CarUtils.GetAdditionals(brandSelect.Text))
            {
                additionalListBox.Items.Add(item);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            brandSelect.Text = null;
            carModelSelect.Text = null;
            carModelSelect.Items.Clear();
            engineListBox.Items.Clear();
            engineTextBox.Text = null;
            colorListBox.Items.Clear();
            colorTextBox.Text = null;
            additionalListBox.Items.Clear();
            additionalTextBox = null;
            carPictureBox.Image = null;
            carPictureBox.Name = null;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            LayoutForm.Instance.OpenSplashArt();
        }

        private void carModelSelect_Changed(object sender, EventArgs e)
        {
            FillEngines();
            FillColors();
            FillAdditionals();
        }

        private void brandSelect_Changed(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(brandSelect.Text))
            {
                FillCarModels();
            }
        }

        private void eningeBtn_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(engineTextBox.Text))
            {
                engineListBox.Items.Add(engineTextBox.Text);
            }
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(colorTextBox.Text))
            {
                colorListBox.Items.Add(colorTextBox.Text);
            }
        }

        private void additionalBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(additionalTextBox.Text))
            {
                additionalListBox.Items.Add(additionalTextBox.Text);
            }
        }
    }
}
