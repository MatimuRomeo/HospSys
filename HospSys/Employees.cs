using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospSys
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.FontAwesome_f060_0__256;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.FontAwesome_f060_0__2561;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PanelWindow child = new PanelWindow();
            ActiveForm.Hide();
            child.Show();            
        }

        private void pBInsert_MouseMove(object sender, MouseEventArgs e)
        {
            //pBInsert.Size = new Size(290, 138);
        }

        private void pBInsert_MouseLeave(object sender, EventArgs e)
        {
            //pBInsert.Size = new Size(286, 134);
        }

        private void pBSalary_MouseMove(object sender, MouseEventArgs e)
        {
            pBSalary.Size = new Size(135, 115);
            pBSalary.Location = new Point(73, 4);
        }

        private void pBSalary_MouseLeave(object sender, EventArgs e)
        {
            pBSalary.Size = new Size(127, 107);
            pBSalary.Location = new Point(75, 6);
        }

        private void pBManagers_MouseMove(object sender, MouseEventArgs e)
        {
            pBManagers.Size = new Size(135, 115);
            pBManagers.Location = new Point(73, 4);
        }

        private void pBManagers_MouseLeave(object sender, EventArgs e)
        {
            pBManagers.Size = new Size(127, 107);
            pBManagers.Location = new Point(75, 6);
        }

        private void pBDocNurse_MouseMove(object sender, MouseEventArgs e)
        {
            pBDocNurse.Size = new Size(135, 115);
            pBDocNurse.Location = new Point(73, 4);
        }

        private void pBDocNurse_MouseLeave(object sender, EventArgs e)
        {
            pBDocNurse.Size = new Size(127, 107);
            pBDocNurse.Location = new Point(75, 6);
        }

        private void pBInsert_MouseMove_1(object sender, MouseEventArgs e)
        {
            pBInsert.Size = new Size(135, 115);
            pBInsert.Location = new Point(73, 4);
        }

        private void pBInsert_MouseLeave_1(object sender, EventArgs e)
        {
            pBInsert.Size = new Size(127, 107);
            pBInsert.Location = new Point(75, 6);
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'd24819387DataSet.total_monthly_salary_for_staff' table. You can move, or remove it, as needed.
            //this.total_monthly_salary_for_staffTableAdapter.Fill(this.d24819387DataSet.total_monthly_salary_for_staff);

        }
    }
}
