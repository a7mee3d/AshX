using System;
using System.Drawing;
using System.Windows.Forms;

namespace AshX
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            ApplyModernTheme();
        }

        private void ApplyModernTheme()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.Font = new Font("Segoe UI", 10F);
            this.ForeColor = Color.White;

            lblTitle.ForeColor = Color.FromArgb(0, 229, 255);
            lblVersion.ForeColor = Color.White;
            lblDeveloper.ForeColor = Color.White;
            txtDescription.BackColor = Color.FromArgb(37, 37, 38);
            txtDescription.ForeColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
