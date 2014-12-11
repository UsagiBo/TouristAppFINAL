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
    }
}
