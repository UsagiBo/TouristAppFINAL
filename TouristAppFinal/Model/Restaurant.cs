using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAppFinal.Model
{
    class Restaurant
    {
        private string _name;
        private string _address;
        private string _web;
        private string _email;
        private string _phone;
        private string _cityArea;
        private string _conferenceFacilities;
        private string _generalFacilities;
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

        public string CityArea
        {
            get { return _cityArea; }
            set { _cityArea = value; }
        }

        public string ConferenceFacilities
        {
            get { return _conferenceFacilities; }
            set { _conferenceFacilities = value; }
        }

        public string GeneralFacilities
        {
            get { return _generalFacilities; }
            set { _generalFacilities = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
