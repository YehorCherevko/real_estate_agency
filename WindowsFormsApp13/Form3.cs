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

namespace WindowsFormsApp13
{
    public partial class Form3 : Form
    {
        int i = 0;
       List<Property> allproperties = new List<Property>();
        

        public Form3()
        {
            InitializeComponent();
        }
        private void printAll()
        {
            txtId.Text += allproperties[i].Id;
            txtSize.Text += allproperties[i].Size;
            txtFloor.Text += allproperties[i].Floor;
            txtAge.Text += allproperties[i].Age;
            txtAdress.Text += allproperties[i].Adress;
            txtRooms.Text += allproperties[i].Rooms;
            txtBathrooms.Text += allproperties[i].Bathrooms;
            txtContract.Text += allproperties[i].Contract_type;
            txtPrice.Text += allproperties[i].Price;
            txtOptions.Text += allproperties[i].Options;
            txtName.Text += allproperties[i].Owner_name;
            txtSurname.Text += allproperties[i].Owner_surname;
            txt0adress.Text += allproperties[i].Owner_adress;
            txtPhone.Text += allproperties[i].Owner_phone;
            txtEmail.Text += allproperties[i].Owner_email;
            txtBirthday.Text += allproperties[i].Owner_birthday;
            label20.Text = $"{i + 1}\\{ allproperties.Count}";
            try
            {
                string txtIdValue = txtId.Text;
                pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, $"img/{txtIdValue}.jpeg"));

            }
            catch (Exception)
            {

                pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img/ImageNa.png"));

            }

            txtId.Text += "";
            txtSize.Text += "";
            txtFloor.Text += "";
            txtAge.Text += "";
            txtAdress.Text += "";
            txtRooms.Text += "";
            txtBathrooms.Text += "";
            txtContract.Text += "";
            txtPrice.Text += "";
            txtOptions.Text += "";
            txtName.Text += "";
            txtSurname.Text += "";
            txt0adress.Text += "";
            txtPhone.Text += "";
            txtEmail.Text += "";
            txtBirthday.Text += "";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("Data.txt") == false)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
                FileStream fs = new FileStream("Data.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    string temp = sr.ReadLine();
                    string id = handleInput(sr.ReadLine());
                    string adress = handleInput(sr.ReadLine());
                    int floor = Convert.ToInt32(handleInput(sr.ReadLine()));
                    int age = Convert.ToInt32(handleInput(sr.ReadLine()));
                    double size = Convert.ToDouble(handleInput(sr.ReadLine()));
                    int rooms = Convert.ToInt32(handleInput(sr.ReadLine()));
                    int bathrooms = Convert.ToInt32(handleInput(sr.ReadLine()));
                    string contract_type = handleInput(sr.ReadLine());
                    int price = Convert.ToInt32(handleInput(sr.ReadLine()));
                    string options = handleInput(sr.ReadLine());
                    string owner_name = handleInput(sr.ReadLine());
                    string owner_surname = handleInput(sr.ReadLine());
                    string owner_email = handleInput(sr.ReadLine());
                    int owner_phone = Convert.ToInt32(handleInput(sr.ReadLine()));
                    string owner_adress = handleInput(sr.ReadLine());
                    string owner_birthday = handleInput(sr.ReadLine());
                    //Property pr = new Property(id, adress, floor, age, size, rooms, bathrooms, contract_type, price, options);
                    //pr.Owner_name = owner_name;
                    //pr.Owner_surname = owner_surname;
                    //pr.Owner_email = owner_email;
                    //pr.Owner_phone = owner_phone;
                    //pr.Owner_adress = owner_adress;
                    //pr.Owner_birthday = owner_birthday;
                    allproperties.Add(new Property(id, adress, floor, age, size, price, rooms, bathrooms, contract_type, options, owner_name, owner_surname, owner_email, owner_phone, owner_adress, owner_birthday));
                }              
                sr.Close();
                fs.Close();
                printAll();
            }
            catch (Exception)
            {

                MessageBox.Show("There is nothing to display", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private string handleInput(string s)
        {
            int lastIndexofDoubledot = s.LastIndexOf(':');
            string result = s.Substring(lastIndexofDoubledot + 1).Trim();
            return result;
        }
        private void indexRightchecker()
        {
            if (i == allproperties.Count - 1)
            {
                
                i = 0;
            }
            else
            {
                i++;
            }
        }
        private void indexLeftchecker()
        {
            if (i == 0)
            {
                 
                i = allproperties.Count - 1;

            }
            else
            {
                i--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtSize.Text = "";
            txtFloor.Text = "";
            txtAge.Text = "";
            txtAdress.Text = "";
            txtRooms.Text = "";
            txtBathrooms.Text = "";
            txtContract.Text = "";
            txtPrice.Text = "";
            txtOptions.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txt0adress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtBirthday.Text = "";
            indexRightchecker();
            printAll();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtSize.Text = "";
            txtFloor.Text = "";
            txtAge.Text = "";
            txtAdress.Text = "";
            txtRooms.Text = "";
            txtBathrooms.Text = "";
            txtContract.Text = "";
            txtPrice.Text = "";
            txtOptions.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txt0adress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtBirthday.Text = "";
            indexLeftchecker();
            printAll();
             
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
