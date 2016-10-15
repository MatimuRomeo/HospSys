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
    public partial class PanelWindow : Form
    {
        private static int position;
        private static string name;
        private static string surname;
        private static string empNum;
        private static string typeUser;
        public PanelWindow()
        {
            InitializeComponent();
        }

        private void PanelWindow_Load(object sender, EventArgs e)
        {

        }

        public static void PopDISP(int Position, string Name, string Surname, string EmpNum, string TypeUser)
        {
            name = Name;
            position = Position;
            surname = Surname;
            empNum = EmpNum;
            typeUser = TypeUser;
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
            if (MessageBox.Show("Would you like to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 child = new Form1();
                ActiveForm.Hide();
                child.Show();
            }
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            //lblEmployees.ForeColor = Color.FromArgb(229, 146, 49);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            //lblEmployees.ForeColor = Color.White;
        }

        private void lblEmployees_MouseMove(object sender, MouseEventArgs e)
        {
            lblEmployees.ForeColor = Color.FromArgb(229, 146, 49);

            pBInfo.BackgroundImage = Properties.Resources.P2;
            pBIco.BackgroundImage = Properties.Resources.Iconic_e062_2__5121;
        }

        private void lblEmployees_MouseLeave(object sender, EventArgs e)
        {
            lblEmployees.ForeColor = Color.White;

            pBInfo.BackgroundImage = Properties.Resources.P11;
            pBIco.BackgroundImage = Properties.Resources.ptech;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            //lblPatients.ForeColor = Color.FromArgb(229, 146, 49);
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            //lblPatients.ForeColor = Color.White;
        }

        private void lblPatients_MouseMove(object sender, MouseEventArgs e)
        {
            lblPatients.ForeColor = Color.FromArgb(229, 146, 49);

            pBInfo.BackgroundImage = Properties.Resources.P3;
            pBIco.BackgroundImage = Properties.Resources.octicons_f037_0__5121;
        }

        private void lblPatients_MouseLeave(object sender, EventArgs e)
        {
            lblPatients.ForeColor = Color.White;

            pBInfo.BackgroundImage = Properties.Resources.P11;
            pBIco.BackgroundImage = Properties.Resources.ptech;
        }

        private void lblAppointments_MouseMove(object sender, MouseEventArgs e)
        {
            lblAppointments.ForeColor = Color.FromArgb(229, 146, 49);

            pBInfo.BackgroundImage = Properties.Resources.P4;
            pBIco.BackgroundImage = Properties.Resources.Iconic_e06c_1__5121;
        }

        private void lblAppointments_MouseLeave(object sender, EventArgs e)
        {
            lblAppointments.ForeColor = Color.White;

            pBInfo.BackgroundImage = Properties.Resources.P11;
            pBIco.BackgroundImage = Properties.Resources.ptech;
        }

        private void lblExaminations_MouseMove(object sender, MouseEventArgs e)
        {
            lblExaminations.ForeColor = Color.FromArgb(229, 146, 49);

            pBInfo.BackgroundImage = Properties.Resources.P5;
            pBIco.BackgroundImage = Properties.Resources.icomoon_e636_2__256;
        }

        private void lblExaminations_MouseLeave(object sender, EventArgs e)
        {
            lblExaminations.ForeColor = Color.White;

            pBInfo.BackgroundImage = Properties.Resources.P11;
            pBIco.BackgroundImage = Properties.Resources.ptech;
        }

        private void lblTreatments_MouseMove(object sender, MouseEventArgs e)
        {
            lblTreatments.ForeColor = Color.FromArgb(229, 146, 49);

            pBInfo.BackgroundImage = Properties.Resources.P6;
            pBIco.BackgroundImage = Properties.Resources.icomoon_e663_3__256;
        }

        private void lblTreatments_MouseLeave(object sender, EventArgs e)
        {
            lblTreatments.ForeColor = Color.White;

            pBInfo.BackgroundImage = Properties.Resources.P11;
            pBIco.BackgroundImage = Properties.Resources.ptech;
        }

        private void lblHospitals_MouseMove(object sender, MouseEventArgs e)
        {
            lblHospitals.ForeColor = Color.FromArgb(229, 146, 49);

            pBInfo.BackgroundImage = Properties.Resources.P7;
            pBIco.BackgroundImage = Properties.Resources.FontAwesome_f0f8_1__256;
        }

        private void lblHospitals_MouseLeave(object sender, EventArgs e)
        {
            lblHospitals.ForeColor = Color.White;

            pBInfo.BackgroundImage = Properties.Resources.P11;
            pBIco.BackgroundImage = Properties.Resources.ptech;
        }

        private void lblInvoices_MouseMove(object sender, MouseEventArgs e)
        {
            lblInvoices.ForeColor = Color.FromArgb(229, 146, 49);

            pBInfo.BackgroundImage = Properties.Resources.P8;
            pBIco.BackgroundImage = Properties.Resources.Iconic_e066_0__256;
        }

        private void lblInvoices_MouseLeave(object sender, EventArgs e)
        {
            lblInvoices.ForeColor = Color.White;

            pBInfo.BackgroundImage = Properties.Resources.P11;
            pBIco.BackgroundImage = Properties.Resources.ptech;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.Size = new Size(40, 33);           
            pictureBox5.Location = new Point(53, 615);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(38, 31);
            pictureBox5.Location = new Point(54, 617);
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.Size = new Size(40, 33);
            pictureBox6.Location = new Point(97, 615);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(38, 31);
            pictureBox6.Location = new Point(98, 617);
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.Size = new Size(40, 33);
            pictureBox7.Location = new Point(141, 615);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(38, 31);
            pictureBox7.Location = new Point(142, 617);
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox8.Size = new Size(40, 33);
            pictureBox8.Location = new Point(185, 615);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(38, 31);
            pictureBox8.Location = new Point(186, 617);
        }

        private void lblEmployees_Click(object sender, EventArgs e)
        {
            Employees child = new Employees();              
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Size = new Size(70, 54);
            pictureBox3.Location = new Point(32, 10);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(66, 50);
            pictureBox3.Location = new Point(33, 12);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Size = new Size(70, 54);
            pictureBox2.Location = new Point(122, 10);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(66, 50);
            pictureBox2.Location = new Point(123, 12);
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Size = new Size(70, 54);
            pictureBox4.Location = new Point(213, 10);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(66, 50);
            pictureBox4.Location = new Point(214, 12);
        }

        private void lblPatients_Click(object sender, EventArgs e)
        {
            Patients child = new Patients();
            ActiveForm.Hide();
            child.Show();
        }

        private void lblAppointments_Click(object sender, EventArgs e)
        {
            Appointments child = new Appointments();
            ActiveForm.Hide();
            child.Show();
        }

        private void lblExaminations_Click(object sender, EventArgs e)
        {
            Examinations child = new Examinations();
            ActiveForm.Hide();
            child.Show();
        }

        private void lblTreatments_Click(object sender, EventArgs e)
        {
            Treatments child = new Treatments();
            ActiveForm.Hide();
            child.Show();
        }

        private void lblHospitals_Click(object sender, EventArgs e)
        {
            Hospitals child = new Hospitals();
            ActiveForm.Hide();
            child.Show();
        }

        private void lblInvoices_Click(object sender, EventArgs e)
        {
            Invoices child = new Invoices();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Information child = new Information();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Phonebook child = new Phonebook();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Technology child = new Technology();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            QuickSearch child = new QuickSearch();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SystemSettings child = new SystemSettings();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Browser child = new Browser();
            ActiveForm.Hide();
            child.Show();
        }
    }
}
