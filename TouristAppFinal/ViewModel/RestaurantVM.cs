using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.UI.Core.AnimationMetrics;
using Windows.UI.Popups;
using TouristAppFinal.Annotations;
using TouristAppFinal.Model;

namespace TouristAppFinal.ViewModel
{
    class RestaurantVM : INotifyPropertyChanged
    {
        #region Properties
        private Weather _weather;
        private Restaurant _r1;
        private Restaurant _r2;
        private Restaurant _r3;
        private Restaurant _r4;
        private Restaurant _r5;
        private Restaurant _r6;
        private Restaurant _r7;
        private Restaurant _r8;
        public Restaurant r1
        {
            get { return _r1; }
            set { _r1 = value; }
        }
        public Restaurant r2
        {
            get { return _r2; }
            set { _r2 = value; }
        }
        public Restaurant r3
        {
            get { return _r3; }
            set { _r3 = value; }
        }
        public Restaurant r4
        {
            get { return _r4; }
            set { _r4 = value; }
        }
        public Restaurant r5
        {
            get { return _r5; }
            set { _r5 = value; }
        }
        public Restaurant r6
        {
            get { return _r6; }
            set { _r6 = value; }
        }
        public Restaurant r7
        {
            get { return _r7; }
            set { _r7 = value; }
        }
        public Restaurant r8
        {
            get { return _r8; }
            set { _r8 = value; }
        }
        public Weather Weather
        {
            get { return _weather; }
        }
        public static Restaurant ActualRestaurant{ get; set; }
        #endregion
        public RestaurantVM()
        {
            #region Restaurants
            _r1 = new Restaurant();
            {
                _r1.Name = "Vigen";
                _r1.Address = "Baunehojve 5, 4000 Roskilde, Denmark";
                _r1.Web = "www.vigen.dk";
                _r1.Email = "mail@vigen.dk";
                _r1.Phone = "+45 6475-5008";
                _r1.CityArea = "Lejre, Roskilde, Sealand, Møn, Lolland-Falster";
                _r1.ConferenceFacilities =
                    "Maximum capacity in restaurant (100), Number of restaurants (1),Number of rooms for group activities (1)";
                _r1.GeneralFacilities = "Bar, Coach/truck parking, Internet parking, Restaurant";
                _r1.Description =
                    "At the Restaurant Vigen in Roskilde you can enjoy a delicious meal overlooking the entire town from opposite the fjord. The restaurant takes pride in providing exceptional food from fresh basics prepared by skilled staff. Apart from tradional Danish dishes the menu includes salads, sandwiches and fish.Four times a year the restaurant offers events with live music and dinner and every Sunday of July there is jazz at the terrace.";
                _r1.Image = "../Assets/Restaurants/Vigen 1.jpg";
            }
            _r2 = new Restaurant();
            {
                _r2.Name = "Østens Perle";
                _r2.Address = "Køgevej 56, 4000 Roskilde, Denmark";
                _r2.Web = "www.østens-perle.dk";
                _r2.Email = "info@østens-perle.dk";
                _r2.Phone = "+45 46368236";
                _r2.CityArea = "Lejre, Roskilde, Sealand, Møn, Lolland-Falster";
                _r2.ConferenceFacilities =
                    "Maximum capacity in restaurant (100), Number of restaurants (1),Number of rooms for group activities (1)";
                _r2.GeneralFacilities = "Bar, Coach/truck parking, Internet parking, Restaurant";
                _r2.Description = "The cuisine of Østens Perle in Roskilde is inspired by Asian culinary art. Only fresh raw materials are used and exotic spices such as coriander, lemon grass, coconut milk, chilli and curry.The restaurant is situated in the centre of Roskilde close to the station.";
                _r2.Image = "../Assets/Restaurants/perle 1.jpg";
            }
            _r3 = new Restaurant();
            {
                _r3.Name = "Comwell Roskilde";
                _r3.Address = "Vestre Kirkevej 12, 4000 Roskilde, Denmark";
                _r3.Web = "www.comwellroskilde.dk";
                _r3.Email = "hotel.roskilde@comwell.com";
                _r3.Phone = "+45 46323131";
                _r3.CityArea = "Lejre, Roskilde, Sealand, Møn, Lolland-Falster";
                _r3.ConferenceFacilities =
                    "Maximum banquet seating (300), Maximum classroom seating (150), Maximum theatre seating (285), Number of rooms for group activities (18)";
                _r3.GeneralFacilities = "bar, elevator, internet parking, restaurant";
                _r3.Description = "At Comwell Roskilde you will always experience great food, fantastic wine and good service.We are proud to have a world champion in our kitchen at Comwell Roskilde. Our head chef, Rasmus Rasmussen, won the title as the world’s best conference chef at the World Championship in Chicago in 2010 and he is still strongly passioned about his cooking. Every day he makes sure our guests are served high quality food. We only use the very best produce and the menu varies with the season. We take pride in making food that is delicious to all senses.Our bar has a great view over Roskilde Fjord. When weather allows it, you can enjoy a glass of wine or a cup of coffee at our terrace, with a view as well.At Comwell Roskilde you are always welcomed by smiling and accommodating staff, who will make your experience a special one.We look forward to welcoming you at Comwell Roskilde.";
                _r3.Image = "../Assets/Restaurants/comwell 1.jpg";
            }
            _r4 = new Restaurant();
            {
                _r4.Name = "Upstairs";
                _r4.Address = "Skomagergade 4, 4000 Roskilde, Denmark";
                _r4.Web = "www.upstairs-roskilde.dk";
                _r4.Email = "restaurant@upstairs-roskilde.dk";
                _r4.Phone = "+45 46351900";
                _r4.CityArea = "Roskilde, Sealand, Møn, Lolland-Falster";
                _r4.ConferenceFacilities =
                    "Maximum capacity in restaurant (100), Number of restaurants (1),Number of rooms for group activities (1)";
                _r4.GeneralFacilities = "Bar, Coach/truck parking, Internet parking, Restaurant";
                _r4.Description =
                    "The restaurant is situated at the beginning of the walking street of Roskilde City. The lunch menu offers amongst others: Danish open faced sandwiches, herrings, warm dishes & cheeses. The evening menu consists of 3 starters, 3 main courses, and 3 desserts, which can be combined according to taste. The menus are inspired by the seasons.The restaurant is also open sunday for brunch or lunch, but only if you have made reservations on beforehand and is minimum 20 persons.";
                _r4.Image = "../Assets/Restaurants/upstairs 1.jpg";
            }
            _r5 = new Restaurant();
            {
                _r5.Name = "Søfryd";
                _r5.Address = "Søfrydvej 8-10, 4040 Jyllinge, 4000 Roskilde, Denmark";
                _r5.Web = "www.hotel-sofryd.dk";
                _r5.Email = "info@hotel-sofryd.dk";
                _r5.Phone = "+45 46 78 80 11";
                _r5.CityArea = "Sealand, Møn, Lolland-Falster";
                _r5.ConferenceFacilities =
                    "Maximum capacity in restaurant (100), Number of restaurants (1),Number of rooms for group activities (1)";
                _r5.GeneralFacilities = "Bar, Coach/truck parking, Internet parking, Restaurant";
                _r5.Description = "Restaurant Søfryd is a cosy and comfortabel restaurant placed with a view of Roskilde fjord.The menu offers both classic courses, local courses and French courses plus menues and buffets with ingredients modified the seasons. During spring, summer and autumn when the weather allows there will also be service at the terrace of the restaurant.";
                _r5.Image = "../Assets/Restaurants/sofryd 1.jpg";
            }
            _r6 = new Restaurant();
            {
                _r6.Name = "Raadhuskælderen";
                _r6.Address = "Fondens Bro 3, 4000 Roskilde, Denmark";
                _r6.Web = "www.raadhuskaelderen.dk";
                _r6.Email = "mail@raadhuskaelderen.dk";
                _r6.Phone = "+45 46360100";
                _r6.CityArea = "Roskilde, Sealand, Møn, Lolland-Falster";
                _r6.ConferenceFacilities =
                    "Maximum capacity in restaurant (100), Number of restaurants (1),Number of rooms for group activities (1)";
                _r6.GeneralFacilities = "Parking for motor coaches";
                _r6.Description =
                    " The Restaurant Raadhuskælderen in the heart of Roskilde offers a lunch menu of delicious Danish open sandwiches and a la carte while the dinner menu concentrates on BBQ dishes cooked on lava stone as well as fish of the day and a la carte.Lunch is served between 11-15.30, dinner between 17-21.In the summer you can enjoy your meal in the garden behind the old city hall overlooking the Roskilde Cathedral.";
                _r6.Image = "../Assets/Restaurants/raadhusk 1.jpg";
            }
            _r7 = new Restaurant();
            {
                _r7.Name = "Svogerslev";
                _r7.Address = "Svogerslev Hovedgade 45, 4000 Roskilde, Denmark";
                _r7.Web = "www.svogerslevkro.dk";
                _r7.Email = "kontakt@svogerslevkro.dk";
                _r7.Phone = "+45 46383005";
                _r7.CityArea = "Lejre, Roskilde Sealand, Møn, Lolland-Falster";
                _r7.ConferenceFacilities =
                    "Maximum capacity in restaurant (100), Number of restaurants (1),Number of rooms for group activities (1)";
                _r7.GeneralFacilities = "Parking for motor coaches";
                _r7.Description =
                    "Welcome to Svogerslev Inn. Svogerslev Inn is situated only a few kilometres from the city of Roskilde in quiet and peaceful surroundings. With only 30 km to Copenhagen the inn is the ideal starting point for tours and excursions. The inn has its own special charm, with thatched roof on the wings and a cosy atmosphere inside with beamed ceiling and rustic style furnishing. All together, this forms the perfect surroundings for any kind of social occasion. The inn has 18 double rooms at its disposal, all with private shower. The inn is known throughout the country for its large selection of Danish as well as international specialities.";
                _r7.Image = "../Assets/Restaurants/svogerslev 1.jpg";
            }
            _r8 = new Restaurant();
            {
                _r8.Name = "Herthadalen";
                _r8.Address = "Slangealleen 1, 4000 Roskilde, Denmark";
                _r8.Web = "www.herthadalen.dk";
                _r8.Email = "info@herthadalen.dk";
                _r8.Phone = "+45 4648 0157";
                _r8.CityArea = "Lejre RoskildeSealand, Møn, Lolland-Falster";
                _r8.ConferenceFacilities =
                    "Maximum capacity in restaurant (100), Number of restaurants (1),Number of rooms for group activities (1)";
                _r8.GeneralFacilities = "Bar,Buffet, Free parking, Restaurant";
                _r8.Description =
                    "At the end of Denmark's longest avenue, Ledreborg Allé, as part of Ledreborg Castle, is Restaurant Herthadalen. Herthadalen specializes in special arrangements, and their beautiful rooms all have a private terrace overlooking the lake Knapsø. Facilities accommodate 15 to 200 people and at Ledrebrog Castle there is room for 450 guests in a private room.";
                _r8.Image = "../Assets/Restaurans/herthalen 1.jpg";
            }
            #endregion 
            _weather = new Weather();
            loadXML();
            
        }

        //Load Weather fom XML
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
       

        #region PropertyChanged

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
