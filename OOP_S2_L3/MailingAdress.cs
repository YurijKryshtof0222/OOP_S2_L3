using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace OOP_S2_L3
{
    public class MailingAdress
    {
        private readonly int id;
        private string country;
        private int postalCode;
        private string area;
        private string city;
        private string streetName;
        private int streetNumber;
        private string companyName;

        private static int idCount;

        public static int GetNumberOfCount() 
        {
            return idCount; 
        }

        public MailingAdress()
        {
            country = "Ukraine";
            postalCode = 79068;
            area = "Lvivskya";
            city = "Lviv";
            streetName = "S. Bandera";
            streetNumber = 28;
            companyName = "Noname Inc.";
            id = ++idCount;
        }

        public MailingAdress(string country,
                       int postalCode,
                       string area,
                       string city,
                       string streetName,
                       int streetNumber,
                       string companyName)
        {
            this.Country = country;
            this.PostalCode = postalCode;
            this.Area = area;
            this.City = city;
            this.StreetName = streetName;
            this.StreetNumber = streetNumber;
            this.CompanyName = companyName;
            id = ++idCount;
        }

        public MailingAdress(string country,
                     int postalCode) : this()
        {
            this.Country = country;
            this.PostalCode = postalCode;
        }

        public int GetId()
        {
            return id;
        }

        public override string ToString()
        {
            return $"{Country} {PostalCode} {Area} {City} {StreetName} {StreetNumber} {CompanyName}";
        }

        public string Country
        {
            get { return country; }
            set 
            {
                CheckOnArgumentNullExc(value);
                country = value;
            }
        }

        public int PostalCode
        {
            get {return postalCode;}
            set 
            {
                CheckOnOutOfRangeExc(value);
                postalCode = value;
            }
        }

        public string Area
        {
            get { return area; }
            set
            {
                CheckOnArgumentNullExc(value);
                area = value;
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                CheckOnArgumentNullExc(value);
                city = value;
            }
        }

        public string StreetName
        {
            get { return streetName; }
            set
            {
                CheckOnArgumentNullExc(value);
                streetName = value;
            }
        }

        public int StreetNumber
        {
            get { return streetNumber;}
            set
            {
                CheckOnOutOfRangeExc(value);
                streetNumber = value;
            }
        }

        public string CompanyName
        {
            get { return companyName; }
            set
            {
                CheckOnArgumentNullExc(value);
                companyName = value;
            }
        }

        private static void CheckOnArgumentNullExc(String value)
        {
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException();
        }

        private static void CheckOnOutOfRangeExc(int value) 
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException();
        }

    }

}   