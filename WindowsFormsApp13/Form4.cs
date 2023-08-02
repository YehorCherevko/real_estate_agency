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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        List<Property> allproperties = new List<Property>();
        List<Property> loadproperty = new List<Property>();
        int i = 0;


        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                loadproperty.Clear();
               //groupBox4.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                txtID.Text = "";
                txtSize.Text = "";
                txtFloor.Text = "";
                txtAge.Text = "";
                txtAddress.Text = "";
                txtRooms.Text = "";
                txtBathrooms.Text = "";
                txtContract.Text = "";
                txtPrice.Text = "";
                label22.Text = "";
                txtName.Text = "";
                txtSurname.Text = "";
                txtOadress.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                txtBirthday.Text = "";

                if (radioButton1.Checked)
                {
                    textBox3.Text = "";

                    for (int index = 0; index < allproperties.Count; index++)
                    {
                       
                        if (allproperties[index].Price>Convert.ToInt32(textBox1.Text)&&allproperties[index].Price < Convert.ToInt32(textBox2.Text))
                        {
                            loadproperty.Add(allproperties[index]);
                            
                            
                        }
                        
                    }
                    i =0;
                    printAll();
                }
                if (radioButton2.Checked)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    loadproperty.Clear();
                    button3.Enabled = false;
                    button4.Enabled = false;
                    for (int index = 0; index < allproperties.Count; index++)
                    {
                        if (allproperties[index].Id==textBox3.Text)
                        {
                            loadproperty.Add(allproperties[index]);
                            //if (index==allproperties.Count)
                            //{
                            //    break;
                            printAll();
                           
                        }
                        if (loadproperty.Count<1)
                        {
                            label2.Text = "0/0";
                        }
                    }
                     
                }

            }
            catch (Exception)
            {

                
            }
        }
        private void printAll()
        {
            try
            {
                txtID.Text += loadproperty[i].Id;
                txtSize.Text += loadproperty[i].Size;
                txtFloor.Text += loadproperty[i].Floor;
                txtAge.Text += loadproperty[i].Age;
                txtAddress.Text += loadproperty[i].Adress;
                txtRooms.Text += loadproperty[i].Rooms;
                txtBathrooms.Text += loadproperty[i].Bathrooms;
                txtContract.Text += loadproperty[i].Contract_type;
                txtPrice.Text += loadproperty[i].Price;
                label22.Text += loadproperty[i].Options;
                txtName.Text += loadproperty[i].Owner_name;
                txtSurname.Text += loadproperty[i].Owner_surname;
                txtOadress.Text += loadproperty[i].Owner_adress;
                txtPhone.Text += loadproperty[i].Owner_phone;
                txtEmail.Text += loadproperty[i].Owner_email;
                txtBirthday.Text += loadproperty[i].Owner_birthday;
                label2.Text = $"{i + 1}\\{ loadproperty.Count}";
                try
                {
                    pictureBox1.Image = Image.FromFile($"C:/Users/Egor/source/repos/WindowsFormsApp13/WindowsFormsApp13/bin/Debug/img/{txtID.Text}.jpeg");
                }
                catch (Exception)
                {

                    pictureBox1.Image = Image.FromFile("C:/Users/Egor/source/repos/WindowsFormsApp13/WindowsFormsApp13/bin/Debug/img/ImageNa.png");
                }
                txtID.Text += "";
                txtSize.Text += "";
                txtFloor.Text += "";
                txtAge.Text += "";
                txtAddress.Text += "";
                txtRooms.Text += "";
                txtBathrooms.Text += "";
                txtContract.Text += "";
                txtPrice.Text += "";
                label22.Text += "";
                txtName.Text += "";
                txtSurname.Text += "";
                txtAddress.Text += "";
                txtPhone.Text += "";
                txtEmail.Text += "";
                txtBirthday.Text += "";
            }
            catch (Exception)
            {

                
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
            if (i == loadproperty.Count - 1)
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

                i = loadproperty.Count - 1;

            }
            else
            {
                i--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("Data.txt") == false)
                {
                    
                    groupBox1.Enabled = false;
                }
                //groupBox4.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
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
                    allproperties.Add(new Property(id, adress, floor, age, size, price, rooms, bathrooms, contract_type, options, owner_name, owner_surname, owner_email, owner_phone, owner_adress, owner_birthday));
                }
                sr.Close();
                fs.Close();
                
            }
            catch (Exception ex)
            {


                MessageBox.Show("There is nothing to display", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtSize.Text = "";
            txtFloor.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            txtRooms.Text = "";
            txtBathrooms.Text = "";
            txtContract.Text = "";
            txtPrice.Text = "";
            label22.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtOadress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtBirthday.Text = "";
            indexRightchecker();
            printAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtSize.Text = "";
            txtFloor.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            txtRooms.Text = "";
            txtBathrooms.Text = "";
            txtContract.Text = "";
            txtPrice.Text = "";
            label22.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtOadress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtBirthday.Text = "";
            indexLeftchecker();
            printAll();
        }
    }
}
