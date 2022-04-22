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
    public partial class LayoutForm : Form
    {
        private static LayoutForm instance;
        private Form activeForm = null;

        public static LayoutForm Instance
        {
            get
            {
                if (instance == null)
                    return new LayoutForm();

                return instance;
            }
        }

        public LayoutForm()
        {
            InitializeComponent();
            instance = this;
            OpenSplashArt();
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void OpenSplashArt()
        {
            openChildForm(new SplashArtForm());
        }

        public void OpenTestDrive()
        {
            openChildForm(new TestDriveForm());
        }

        private void configurationBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ConfigurationForm());
        }

        private void newCarBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new NewCarForm());
        }

        private void testDriveBtn_Click(object sender, EventArgs e)
        {
            OpenTestDrive();
        }
    }
}
