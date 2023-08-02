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
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<string> idlist = new List<string>();
        string randomid = "";
        string a = "";
        string images = "";
        private void label16_Click(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckbox = sender as CheckBox;
            if (clickedCheckbox.Checked)
            {
                a += $"{clickedCheckbox.Text}, ";

            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               // File.Copy(images, Path.Combine(@"C:\Users\Egor\source\repos\WindowsFormsApp13\WindowsFormsApp13\bin\Debug\img",Path.GetFileName(images)), true);
                string id = label7.Text;
                string adress = textBox4.Text;
                int floor = Convert.ToInt32(textBox2.Text);
                int age = Convert.ToInt32(textBox3.Text);
                double size = Convert.ToDouble(textBox1.Text);
                int rooms = Convert.ToInt32(textBox5.Text);
                int bathrooms = Convert.ToInt32(textBox6.Text);
                string contract_type = comboBox1.Text;
                int price = Convert.ToInt32(textBox7.Text);
                string options = a;               
                string owner_name = textBox8.Text;
                string owner_surname = textBox9.Text;
                string owner_email = textBox12.Text;
                int owner_phone = Convert.ToInt32(textBox13.Text);
                string owner_adress = textBox11.Text;
                string owner_birthday = textBox10.Text;
                //File.Copy(images, Path.Combine(@"C:\Users\Egor\source\repos\WindowsFormsApp13\WindowsFormsApp13\bin\Debug\img", Path.GetFileName(images)), true);
                if (images!="")
                {
                    //string id = "your_id_here"; // Replace "your_id_here" with the actual value of your 'id' variable
                    string destinationPath = Path.Combine(Application.StartupPath, $"img/{id}.jpeg");
                    File.Copy(images, destinationPath);

                }
                // File.Copy(images, $@"C:\Users\Egor\source\repos\WindowsFormsApp13\WindowsFormsApp13\bin\Debug\img\{id}.jpeg");
                Property p = new Property(id, adress, floor, age, size, rooms, bathrooms, contract_type, price, options);
                p.Owner_name = owner_name;
                p.Owner_surname = owner_surname;
                p.Owner_email = owner_email;
                p.Owner_phone = owner_phone;
                p.Owner_adress = owner_adress;
                p.Owner_birthday = owner_birthday;
                string allData = p.printFeatures();
                Allproperties.addProperty(p, allData);
                MessageBox.Show("Product Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";                
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                randomid = "";
                makeMEid();
                while (idlist.Contains(randomid))
                {
                    randomid = "";
                    makeMEid();
                }
                label7.Text = randomid;
                string imageName = "ImageNa.png";
                pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "img", imageName));




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("Data.txt") == false)
                {

                    makeMEid();
                    label7.Text = randomid;
                }
                
                
                    FileStream fst = new FileStream("Data.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fst);
                    while (!sr.EndOfStream)
                    {
                        string temp = sr.ReadLine();
                        string id = handleInput(sr.ReadLine());
                        temp += sr.ReadLine();
                        temp += sr.ReadLine();
                        temp += sr.ReadLine();
                        temp += sr.ReadLine();
                        temp += sr.ReadLine();
                        temp += sr.ReadLine();
                        temp += sr.ReadLine();
                        temp += sr.ReadLine();
                        temp += sr.ReadLine();
                        temp += sr.ReadLine();
                        temp += sr.ReadLine();
                        temp += sr.ReadLine();
                        temp += sr.ReadLine();
                        temp += sr.ReadLine();
                        temp += sr.ReadLine();
                        idlist.Add(id);

                        //MessageBox.Show(id);
                    }
                    sr.Close();
                    fst.Close();
                    makeMEid();
                    while (idlist.Contains(randomid))
                    {
                        randomid = "";
                        makeMEid();
                    }
                    //string[] randomletters = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "j" };
                    //Random r = new Random();
                    //string randomid= "";           
                    //randomid += randomletters[r.Next(0, 9)];          
                    //randomid += $"-{r.Next(1000, 9999)}";
                    label7.Text = randomid;
                
            }
            catch (Exception )
            {
                

            }            
        }
        public void makeMEid()
        {
            string[] randomletters = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "j" };
            Random r = new Random();
            //string randomid = "";
            randomid += randomletters[r.Next(0, 9)];
            randomid += $"-{r.Next(1000, 9999)}";
        }
        private string handleInput(string s)
        {
            int lastIndexofDoubledot = s.LastIndexOf(':');
            string result = s.Substring(lastIndexofDoubledot + 1).Trim();
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             // string images = "";
            try
            {
                OpenFileDialog open =new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp;)|*.jpg; *.jpeg; *.bmp";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    images = open.FileName;
                    pictureBox1.Image = new Bitmap(open.FileName);      
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
