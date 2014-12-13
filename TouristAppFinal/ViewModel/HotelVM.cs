using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Data.Xml.Dom;
using Windows.UI.Popups;
using TouristAppFinal.Annotations;
using TouristAppFinal.Model;

namespace TouristAppFinal.ViewModel
{
    class HotelVM : INotifyPropertyChanged
    {
        #region Properties
        private Weather _weather;
        private Hotel _h1;
        private Hotel _h2;
        private Hotel _h3;
        private Hotel _h4;
        private Hotel _h5;
        private Hotel _h6;
        private Hotel _h7;
        private Hotel _h8;
        public Hotel h1
        {
            get { return _h1; }
            set { _h1 = value; }
        }
        public Hotel h2
        {
            get { return _h2; }
            set { _h2 = value; }
        }
        public Hotel h3
        {
            get { return _h3; }
            set { _h3 = value; }
        }
        public Hotel h4
        {
            get { return _h4; }
            set { _h4 = value; }
        }
        public Hotel h5
        {
            get { return _h5; }
            set { _h5 = value; }
        }
        public Hotel h6
        {
            get { return _h6; }
            set { _h6 = value; }
        }
        public Hotel h7
        {
            get { return _h7; }
            set { _h7 = value; }
        }
        public Hotel h8
        {
            get { return _h8; }
            set { _h8 = value; }
        }
        public Weather Weather
        {
            get { return _weather; }
        }
        public static Hotel ActualHotel { get; set; }
#endregion
        public HotelVM()
        {
            #region Hotels
            _h1 = new Hotel();
            {
            _h1.Name = "Hotel Prindsen";
            _h1.Address = "Algade 13, Roskilde";
            _h1.Phone = "+45 46 30 91 00";
            _h1.StarClassification = 4;
            _h1.Fax = "+45 46309150";
            _h1.Email = "info@prindsen.dk";
            _h1.Web = "www.prindsen.dk";
            _h1.Capacity = "number of beds (140),number of double rooms (56), number of single rooms (17), number of suites (3), total number of rooms (76)";
            _h1.CityArea = "Roskilde Sealand, Møn, Lolland-Falster";
            _h1.ConferenceFacilities = "Meeting Facilities";
            _h1.CreditCards = "Access, American Express, Dankort, Diners Club, Eurocard, Maestro, MasterCard, Visa";
            _h1.GeneralFacilities = "bar, dogs allowed, elevator, internet, parking, restaurant";
            _h1.MemberOf = "Classic Hotels, Danish Conference Centre, Horesta, Small Danish Hotels";
            _h1.RoomFacilities = "minibar, TV";
            _h1.Season = "All";
            _h1.Description ="Hotel Prindsen is situated in the centre of Roskilde, in the heart of Zealand. With 300 years behind it, Hotel Prindsen is one of the oldest hotels in operation in Denmark, although is is really only the foundations and hospitality that go that far back. Here in its third centenary, the hotel stands as a beautiful building refurbished with proper respect for its past but containing all the facilities a modern hotel must offer. The city of Roskilde itself, with its imposing cathedral and beautiful surroundings, is an historical goldmine. Denmark's old royal city and former archdiocese brings centuries of history to life. The city is also well endowed with shops and there is an open-air market at the cosy old square every Saturday. Roskilde Fjord offers sailing, other water sports and safe bathing, and there are meny pleasant walks along its shores. Nearby there are both golf courses and tennis courts. We wish you welcome to an exciting stay at Hotel Prindsen.";
            _h1.Image = @"/Asset/TouristAppFinal/resim6jpg";


            };
            _h2 = new Hotel()
            {
                Name = "SCANDIC ROSKILDE",
                Address = "Søndre Ringvej 33 4000 Roskilde",
                Phone = "+45 46324632",
                StarClassification = 3,
                Fax = "+45 46320232",
                Email = "roskilde@scandichotels.com",
                Web = "www.scandichotels.dk",
                Capacity = "number of beds (220), number of double rooms (82), number of single rooms (8), number of suites (8), total number of rooms (98)",
                CityArea = "Lejre,Roskilde Sealand, Møn, Lolland-Falster",
                ConferenceFacilities = "capacity restaurant (150), meeting facilities",
                CreditCards = "American Express, Dankort, Diners Club, Eurocard, Maestro, MasterCard, Visa",
                GeneralFacilities = "bar, dogs allowed, elevator, internet, parking, restaurant",
                MemberOf = "Scandic Hotels",
                RoomFacilities = "TV",
                Season = "All",
                Description = "Welcome to Scandic Roskilde. The ideal choice for business or pleasure. Enjoy our unique location close to the historic centre of Roskilde, with view over the park and pond. Holiday and conference guests alike find the hotels proximity to the motorway and train station ideal along with the free car park. And Scandic Roskilde creates a good impression as soon as you arrive thanks to the adjoining park. The spacious rooms are comfortable and functional, ensuring our guests a pleasant stay. This is the ideal venue for meetings and conferences too, with excellent facilities and good service.",
            };

            _h3 = new Hotel()
            {
                Name = "COMWELL ROSKILDE",
                Address = "Vestre Kirkevej 12 4000 Roskilde",
                Phone = "+45 46323131",
                StarClassification = 3,
                Fax = "+45 46350835",
                Email = "hotel.roskilde@comwell.com",
                Web = "www.comwellroskilde.dk",
                Capacity = "number of beds (108), number of double rooms (6), number of family rooms (2), number of single rooms (96), total number of rooms (104)",
                CityArea = "Lejre, Roskilde Sealand, Møn, Lolland-Falster",
                ConferenceFacilities = "meeting facilities",
                CreditCards = "Access, American Express, Carte Bleu, Dankort, Diners Club, Electron, Eurocard, JCB, Maestro, MasterCard, Visa",
                GeneralFacilities = "bar, dogs allowed, elevator, internet, parking, restaurant",
                MemberOf = "ComwellDanish Conference Centre",
                RoomFacilities = "TV",
                Season = "All",
                Description = "Comwell Roskilde is situated close to Roskilde Fjord with a fantastic view of the water and with the beautiful nature just outside the main entrance. This makes it the perfect place for a relaxing weekend or a longer vacation. Being situated close to the forest and the beach, makes it possible for many different outdoor activities. The hotel is located only a short distance from the main tourist attractions, such as the Viking Ship Museum, Roskilde Cathedral and the city centre, with its many shops and cafes. If you arrive by car, we have a free parking area, if not, local transportation is close to the hotel. Inside the hotel, we offer many different activities as well, whether you want to use the fitness center, the pool table, relax in the bar area, or perhaps enjoy the wonderful sunset at the terrace, with a view of Roskilde Fjord. The restaurant is open daily and serves food based on the season prepared in cooperation with our head chef Rasmus Rasmussen, who won the competition of best Conference Chef in the world, held in Chicago. We look forward to welcoming you to our beautiful hotel!"

            };
            _h4 = new Hotel()
            {
                Name = "HOTEL SØFRYD",
                Address = "Søfrydvej 8 4040 Jyllinge",
                Phone = "+45 46788011",
                StarClassification = 3,
                Fax = "+45 46788091",
                Email = "info@hotel-sofryd.dk",
                Web = "www.hotel-sofryd.dk",
                Capacity ="number of beds (52), number of double rooms (26),total number of rooms (26)",
                CityArea = "Roskilde Sealand, Møn, Lolland-Falster",
                ConferenceFacilities = "meeting facilities",
                CreditCards ="American Express, Dankort, Diners Club, Eurocard, JCB, MasterCard, Visa",
                GeneralFacilities = "internet, parking, restaurant",
                MemberOf = "Dansk Kroferie, Horesta, Small Danish Hotels",
                RoomFacilities = "TV",
                Season = "All",
                Description ="Hotel Soefryd is situated 38 km from Copenhagen and 12 km from Roskilde direct access to Roskilde fjord and the old fishing hamlet in Jyllinge. The garden overlooking the inlet. Cosy Restaurant,party- rooms, conference rooms. New rooms with a fjord view, bath, toilet. and radio. Hot dishes available from 11 am till 10 pm.",
            };
            _h5 = new Hotel()
            {
                Name = "VIBY KRO",
                Address = "Skolevej 1 4130 Viby Sjælland",
                Phone = "+45 46193021",
                StarClassification = 3,
                Fax = "+45 46194921",
                Email = "vibykro@post9.tele.dk",
                Web = "www.vibykro.dk",
                CityArea = "Lejre, Ramsø, RoskildeSealand, Møn, Lolland-Falster",
                ConferenceFacilities = "meeting facilities",
                CreditCards = "Dankort, Diners Club, Electron, Eurocard, JCB, MasterCard, Visa",
                GeneralFacilities = "bar, dogs allowed, garage, parking, restaurant",
                MemberOf = "Marguerit Hoteller",
                RoomFacilities = "TV",
                Season = "All",
                Description = "The restaurant of the Hotel Viby Kro serves traditional Danish food. At the hotel which is located right by Viby Sjælland railway station you can experience the time spirit of King Frederik VII. The restaurant seats approx. 70 persons and includes meeting facilities. Viby Sjælland is located 12 km from Roskilde and 35 minutes drive by train from Copenhagen.",
            };
            _h6 = new Hotel()
            {
                Name = "OSTED KRO & HOTEL",
                Address = "Hovedvejen 151 B 4320 Lejrev",
                Phone = "+45 46497041",
                StarClassification = 3,
                Fax = "+45 46497046",
                Email = "ostedkrohotel@gmail.com",
                Web = "www.ostedkro.dk",
                Capacity = "number of beds (32), number of double rooms (16), total number of rooms (16)",
                CityArea = "Lejre, Roskilde Sealand, Møn, Lolland-Falster",
                ConferenceFacilities = "meeting facilities",
                CreditCards = "American Express, Dankort, Diners Club, Eurocard, MasterCard, Visa",
                GeneralFacilities = "internet, parking, restaurant",
                MemberOf = "Horesta",
                RoomFacilities = "TV",
                Season = "All",
                Description = "Osted Inn is one the oldest of Zealand’s Royal Privileged Inns with a long and very interesting history.It is beautifully situated about 10 km. south of Roskilde on the road to Ringsted. The inn has continuously been modernist and enlarged and appears today with friendly and bright private party rooms as well as 16 well-appointed double rooms, all with toilet, shower, TV and free internet.The inn is also known for its well-prepared food from its Danish/French rustic kitchen. A large menu for parties with many suggestions for compositions and for buffets. Parties from 10 to 225 persons in the same room.The kitchen is open every day from 11.30 am to 9.30 pm. Closed on some holidays, but call and ask. Meetings and courses for up to 120 persons. Receptions at the inn or as catering."
            };
            _h7 = new Hotel()
            {
                Name = "SVOGERSLEV KRO - HOTEL",
                Address = "Svogerslev Hovedgade 45 4000 Roskilde",
                Phone = "+45 46383005",
                StarClassification = 3,
                Fax = "+45 46383014",
                Email = "kontakt@svogerslevkro.dk",
                Web = "www.svogerslevkro.dk",
                Capacity = "number of beds (37), number of double rooms (17), number of single rooms (1), total number of rooms (18)",
                CityArea = "Roskilde Sealand, Møn, Lolland-Falster",
                ConferenceFacilities = "meeting facilities",
                CreditCards = "Access, American Express, Carte Bleu, Dankort, Diners Club, Eurocard, JCB, Maestro, MasterCard, Visa",
                GeneralFacilities = "dogs allowed, internet, parking, restaurant, wireless Internet",
                MemberOf = "Horesta",
                RoomFacilities = "TV",
                Season = "All",
                Description = "Welcome to Svogerslev Inn. Svogerslev Inn is situated only a few kilometres from the city of Roskilde in quiet and peaceful surroundings. With only 30 km to Copenhagen the inn is the ideal starting point for tours and excursions. The inn has its own special charm, with thatched roof on the wings and a cosy atmosphere inside with beamed ceiling and rustic style furnishing. All together, this forms the perfect surroundings for any kind of social occasion. The inn has 18 double rooms at its disposal, all with private shower. The inn is known throughout the country for its large selection of Danish as well as international specialities."
            };
            _h8 = new Hotel()
            {
                Name = "WITTRUP MOTEL, ACCOMMODATION",
                Address = "Roskildevej 251 2620 Albertslund",
                Phone = "+45 43649551",
                StarClassification = 3,
                Fax = "+45 43648890",
                Email = "mail@wittrupmotel.dk",
                Web = "www.wittrupmotel.dk",
                CityArea = "Albertslund, Lejre, Roskilde Sealand, Møn, Lolland-Falster, Vestegnen",
                ConferenceFacilities = "meeting facilities",
                CreditCards = "Dankort, Diners Club, Eurocard, Maestro, MasterCard, Visa",
                GeneralFacilities = "dogs allowed, internet, parking, parking for motor coaches, restaurant",
                MemberOf = "Larsen Hotel og Kroferie",
                RoomFacilities = "TV",
                Season = "All",
                Description = "The Wittrup Motel is built as a traditional American one-storey motel with parking in front of the rooms. The motel is situated centrally between Roskilde and Copenhagen and close to green areas and leisure activities. Direct access to green areas and small river, 2 km to forest, 1 km to outdoor swiming facilities. Easy access to sports facilities. The motel has a restaurant and meeting facilities.The motel also offers Bed & Breakfast with 7 new rooms in separate building close to a small village and green areas. All rooms are non-smoking rooms with TV, access to bathroom and big garden with 2 terraces. Breakfast is included in the price and served in the restaurant at the motel. Bookings and pick-up of keys at the motel. Be aware that the reception closes at 11 pm, sundag at 9.30 pm."
            };
#endregion
            _weather = new Weather();
            loadXML();
        }
       

        //Extract weather from XML
        public async void loadXML()
        {
            try
            {
                Uri weatherUrl =
                    new Uri("http://api.openweathermap.org/data/2.5/weather?q=Roskilde,DK&mode=xml&units=metric");

                XmlDocument doc = await XmlDocument.LoadFromUriAsync(weatherUrl);
                _weather.City = doc.GetElementsByTagName("city")[0].Attributes[1].NodeValue.ToString();
                _weather.Temperature = doc.GetElementsByTagName("temperature")[0].Attributes[0].NodeValue.ToString();
                _weather.Cloudiness = doc.GetElementsByTagName("clouds")[0].Attributes[1].NodeValue.ToString();
                OnPropertyChanged("Weather");
            }
            catch (Exception)
            {
                new MessageDialog("Can't show weather.").ShowAsync();
            }
        }

        # region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
