using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    class Property:Owner
    {
        private string id;
        private string adress;
        private int floor;
        private int age;
        private double size;
        private int rooms;
        private int bathrooms;
        private string contract_type;
        private int price;
        private string options;
        public string printFeatures()
        {
            string t = "+++++++++++++++++++++++++++\n";
            t += $"ID: {id}\n";
            t += $"Address: {adress}\n";
            t += $"Floor: {floor}\n";
            t += $"Age: {age}\n";
            t += $"Size: {size}\n";
            t += $"Rooms: {rooms}\n";
            t += $"Bathrooms: {bathrooms}\n";
            t += $"Contract Type: {contract_type}\n";
            t += $"Price: {price}\n";
            t += $"Options: {options}\n";
            t += ownerdataPrint(); 
            return t;
        }
        public Property(string id, string adress, int floor, int age, double size, int price, int rooms, int bathrooms, string contract_type, string options, string owner_name, string owner_surname, string owner_email, int owner_phone, string owner_adress, string owner_birthday)
        {
            Id = id;
            Adress = adress;
            Floor = floor;
            Age = age;
            Size = size;
            Rooms = rooms;
            Bathrooms = bathrooms;
            Contract_type = contract_type;
            Price = price;
            Options = options;
            Owner_name = owner_name;
            Owner_surname = owner_surname;
            Owner_email = owner_email;
            Owner_phone = owner_phone;
            Owner_adress = owner_adress;
            Owner_birthday = owner_birthday;


        }
        public Property(string id, string adress, int floor, int age, double size, int rooms, int bathrooms, string contract_type, int price , string options)
        {
            Id = id;
            Adress = adress;
            Floor = floor;
            Age = age;
            Size = size;
            Rooms = rooms;
            Bathrooms = bathrooms;
            Contract_type = contract_type;
            Price = price;
            Options = options;
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
            }
        }
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                floor = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public double Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public int Rooms
        {
            get
            {
                return rooms;
            }
            set
            {
                rooms = value;
            }
        }
        public int Bathrooms
        {
            get
            {
                return bathrooms;
            }
            set
            {
                bathrooms = value;
            }
        }
        public string Contract_type
        {
            get
            {
                return contract_type;
            }
            set
            {
                contract_type = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public string Options
        {
            get
            {
                return options;
            }
            set
            {
                options = value;
            }
        }
    }
}
