using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAppFinal.Model
{
    class Hotel
    {
        private string _name;
        private string _address;
        private string _web;
        private string _email;
        private string _phone;
        private string _fax;
        private string _capacity;
        private string _cityArea;
        private int _starClassification;
        private string _conferenceFacilities;
        private string _creditCards;
        private string _generalFacilities;
        private string _memberOf;
        private string _roomFacilities;
        private string _season;
        private string _description;
        private string _image;
        private string _image1;
        private string _image2;
        private string _image3;
        private string _image4;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Web
        {
            get { return _web; }
            set { _web = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        public string Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public string CityArea
        {
            get { return _cityArea; }
            set { _cityArea = value; }
        }

        public int StarClassification
        {
            get { return _starClassification; }
            set { _starClassification = value; }
        }

        public string ConferenceFacilities
        {
            get { return _conferenceFacilities; }
            set { _conferenceFacilities = value; }
        }

        public string CreditCards
        {
            get { return _creditCards; }
            set { _creditCards = value; }
        }

        public string GeneralFacilities
        {
            get { return _generalFacilities; }
            set { _generalFacilities = value; }
        }

        public string MemberOf
        {
            get { return _memberOf; }
            set { _memberOf = value; }
        }

        public string RoomFacilities
        {
            get { return _roomFacilities; }
            set { _roomFacilities = value; }
        }

        public string Season
        {
            get { return _season; }
            set { _season = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public string Image1
        {
            get { return _image1; }
            set { _image1 = value; }
        }

        public string Image2
        {
            get { return _image2; }
            set { _image2 = value; }
        }

        public string Image3
        {
            get { return _image3; }
            set { _image3 = value; }
        }

        public string Image4
        {
            get { return _image4; }
            set { _image4 = value; }
        }
        public Hotel(string Name, string Address, string Web, string Email, string Phone, string Fax,
            string Capacity, string CityArea, int StarClassification, string ConferenceFacilities,
            string CreditCards, string GeneralFacilities, string MemberOf, string RoomFacilities, string Season,
            string Description)
            //, string Image, string Image1, string Image2, string Image3, string Image4
        {
            _name = Name;
            _address = Address;
            _web = Web;
            _email = Email;
            _phone = Phone;
            _fax = Fax;
            _capacity = Capacity;
            _cityArea = CityArea;
            _starClassification = StarClassification;
            _conferenceFacilities = ConferenceFacilities;
            _creditCards = CreditCards;
            _generalFacilities = GeneralFacilities;
            _memberOf = MemberOf;
            _roomFacilities = RoomFacilities;
            _season = Season;
            _description = Description;
            _image = Image;
            _image1 = Image1;
            _image2 = Image2;
            _image3 = Image3;
            _image4 = Image4;
        }
        public override string ToString()
        {
            return string.Format("{0}", _name);
        }
    }
}
