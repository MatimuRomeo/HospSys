using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HospSys
{
    public partial class Form1 : Form
    {
        StreamReader inputStream;
        string[] a = new string[7];
        List<ClassUsers> array = new List<ClassUsers>();

        ClassUsers user;
        string selecteduser = "";
        string password = "";
        string answer = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.FontAwesome_f011_0__2561;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.FontAwesome_f011_0__256;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you realy want exit the system?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string user = comboBoxHomeUserNames.SelectedItem.ToString();
                string arrayUser;

                for (int i = 0; i < array.Count; i++)
                {
                    if ((arrayUser = array[i].getUserName()).Equals(user))
                    {
                        if (textBoxHomePassword.Text == array[i].getPassword())
                        {
                            PanelWindow.PopDISP(i, array[i].getName(), array[i].getLastName(), array[i].getUserName(), array[i].getTypeUser());

                            PanelWindow child1 = new PanelWindow();
                            ActiveForm.Hide();
                            child1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxHomePassword.Text = "";
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a user to proceed", "Request", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlForgotPass.Visible = true;
            pnlPic.Visible = false;

            comboBoxHomeHavingTroubleUserName.SelectedItem = null;
            labelHomeHavingTroubleQuestion.Text = "Select a user to retrieve password.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlForgotPass.Visible = false;
            pnlPic.Visible = true;

            inputStream = File.OpenText("C:\\Protech\\Files\\Users.txt");

            string line;
            int count = 0;

            line = inputStream.ReadLine();

            while (line != null)
            {
                a = line.Split(',');

                string typeUser = a[0];
                string name = a[1];
                string lastName = a[2];
                string userName = a[3];
                string password = a[4];
                string question = a[5];
                string answer = a[6];

                array.Add(user = new ClassUsers(typeUser, name, lastName, userName, password, question, answer));

                line = inputStream.ReadLine();
                count++;
            }
            inputStream.Close();

            for (int i = 0; i < array.Count; i++)
            {
                comboBoxHomeUserNames.Items.Add(array[i].getUserName());
                comboBoxHomeHavingTroubleUserName.Items.Add(array[i].getUserName());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selecteduser = comboBoxHomeHavingTroubleUserName.SelectedIndex.ToString();

            if (!(textBoxHomeHavingTroubleAnswer.Text == ""))
            {
                password = array[Convert.ToInt32(selecteduser)].getPassword();
                answer = array[Convert.ToInt32(selecteduser)].getAnswer();

                if (answer.Equals(textBoxHomeHavingTroubleAnswer.Text))
                {
                    MessageBox.Show("Your password is: " + password, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxHomeHavingTroubleAnswer.Clear();

                    pnlForgotPass.Visible = false;
                    pnlPic.Visible = true;
                }
                else
                {
                    MessageBox.Show("Your answer is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxHomeHavingTroubleAnswer.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter an answer.", "Request", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBoxHomeHavingTroubleUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string user;

            for (int i = 0; i < array.Count; i++)
            {
                user = array[i].getUserName();
                try
                {
                    if (user.Equals(comboBoxHomeHavingTroubleUserName.SelectedItem.ToString()))
                    {
                        labelHomeHavingTroubleQuestion.Text = array[i].getQuestion() + "? (Note answer is case sensitive)";
                    }
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
