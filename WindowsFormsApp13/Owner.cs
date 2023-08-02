using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    class Owner
    {
        private string owner_name;
        private string owner_surname;
        private string owner_email;
        private int owner_phone;
        private string owner_adress;
        private string owner_birthday;

        public string ownerdataPrint()
        {
            string t = "";
            t += $"Owner Name: {owner_name}\n";
            t += $"Owner Last Name: {owner_surname}\n";
            t += $"Owner Email: {owner_email}\n";
            t += $"Owner Phone: {owner_phone}\n";
            t += $"Owner Address: {owner_adress}\n";
            t += $"Owner Birthday: {owner_birthday}\n";
            return t;
        }
       //public Owner(string owner_name, string owner_surname, string owner_email, int owner_phone, string owner_adress, string owner_birthday)
        //{
        //    Owner_name = owner_name;
        //    Owner_surname = owner_surname;
        //    Owner_email = owner_email;
        //    Owner_phone = owner_phone;
        //    Owner_adress = owner_adress;
        //    Owner_birthday = owner_birthday;
        //}
        public string Owner_name
        {
            get
            {
                return owner_name;
            }
            set
            {
                owner_name = value;
            }
        }
        public string Owner_surname
        {
            get
            {
                return owner_surname;
            }
            set
            {
                owner_surname = value;
            }
        }
        public string Owner_email
        {
            get
            {
                return owner_email;
            }
            set
            {
                owner_email = value;
            }
        }
        public int Owner_phone
        {
            get
            {
                return owner_phone;
            }
            set
            {
                owner_phone = value;
            }
        }
        public string Owner_adress
        {
            get
            {
                return owner_adress;
            }
            set
            {
                owner_adress = value;
            }
        }
        public string Owner_birthday
        {
            get
            {
                return owner_birthday;
            }
            set
            {
                owner_birthday = value;
            }
        }
    }
}
