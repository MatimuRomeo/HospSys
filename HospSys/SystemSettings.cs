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
    public partial class SystemSettings : Form
    {
        string fileName;
        StreamWriter outputStream;

        StreamReader inputStream;
        string[] a = new string[7];
        List<ClassUsers> array = new List<ClassUsers>();
        List<ClassUsers> array2 = new List<ClassUsers>();

        ClassUsers user;
        string selecteduser = "";
        string password = "";
        string answer = "";

        public SystemSettings()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.FontAwesome_f060_0__256;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.FontAwesome_f060_0__2561;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PanelWindow child = new PanelWindow();
            ActiveForm.Hide();
            child.Show();
        }

        private void pBAdd_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            pnlRemove.Visible = false;
        }

        private void pBRemove_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            pnlRemove.Visible = true;
        }

        private void pBAdd_MouseMove(object sender, MouseEventArgs e)
        {
            pBAdd.Size = new Size(90, 87);
            pBAdd.Location = new Point(447, 52);
        }

        private void pBAdd_MouseLeave(object sender, EventArgs e)
        {
            pBAdd.Size = new Size(80, 77);
            pBAdd.Location = new Point(449, 54);
        }

        private void pBRemove_MouseMove(object sender, MouseEventArgs e)
        {
            pBRemove.Size = new Size(90, 87);
            pBRemove.Location = new Point(575, 52);
        }

        private void pBRemove_MouseLeave(object sender, EventArgs e)
        {
            pBRemove.Size = new Size(80, 77);
            pBRemove.Location = new Point(577, 54);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string userName = "";
            string password = "";
            string typeUser = comboBoxTypeUser.SelectedItem.ToString();
            string question = comboBoxPassRecoveryQuestion.SelectedItem.ToString();
            string answer = textBoxAnswer.Text;

            if (textBoxPassword.Text.Equals(textBoxConfirmPassword.Text))
            {
                password = textBoxPassword.Text;

                try
                {
                    outputStream = File.AppendText(@"C:\\Protech\Files\\Users.txt");

                    if (typeUser.Equals("Regular"))
                    {
                        userName = firstName.Substring(0, 1) + lastName.Substring(0, 1) + "R" + "100";
                    }
                    else if (typeUser.Equals("Administrator"))
                    {
                        userName = firstName.Substring(0, 1) + lastName.Substring(0, 1) + "A" + "200";
                    }

                    outputStream.WriteLine(typeUser + "," + firstName + "," + lastName + "," + userName + "," + password + "," + question + "," + answer);
                    outputStream.Close();
                    MessageBox.Show("The user with user name : " + userName + " has been created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    comboBoxTypeUser.SelectedItem = null;
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxPassword.Text = "";
                    textBoxConfirmPassword.Text = "";
                    comboBoxPassRecoveryQuestion.SelectedItem = null;
                    textBoxAnswer.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("User could not be created, please note every field is required. Please try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBoxTypeUser.SelectedItem = null;
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxPassword.Text = "";
                    textBoxConfirmPassword.Text = "";
                    comboBoxPassRecoveryQuestion.SelectedItem = null;
                    textBoxAnswer.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SelectedUser = comboBoxRemoveUser.SelectedItem.ToString();

            File.WriteAllText("C:\\Protech\\Files\\Users.txt", String.Empty);           

            for (int i = 0; i < array.Count; i++)
            {
                outputStream.WriteLine(array[i].getTypeUser() + "," + array[i].getName() + "," + array[i].getLastName() + "," + array[i].getUserName() + "," + array[i].getPassword() + "," + array[i].getQuestion() + "," + array[i].getAnswer());
                outputStream.Close();                              
            }

            MessageBox.Show("The user with user name : " + comboBoxRemoveUser.SelectedItem.ToString() + " has been deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SystemSettings_Load(object sender, EventArgs e)
        {
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
                comboBoxRemoveUser.Items.Add(array[i].getUserName());
            }
        }       
    }
}
