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

            _r1 = new Restaurant("Vigen", "Baunehojve 5, 4000 Roskilde, Denmark", "www.vigen.dk", "mail@vigen.dk",
                "+45 6475-5008", "Lejre, Roskilde, Sealand, Møn, Lolland-Falster",
                "Maximum capacity in restaurant (100), Number of restaurants (1),Number of rooms for group activities (1)",
                "Bar, Coach/truck parking, Internet parking, Restaurant",
                "At the Restaurant Vigen in Roskilde you can enjoy a delicious meal overlooking the entire town from opposite the fjord. The restaurant takes pride in providing exceptional food from fresh basics prepared by skilled staff. Apart from tradional Danish dishes the menu includes salads, sandwiches and fish.Four times a year the restaurant offers events with live music and dinner and every Sunday of July there is jazz at the terrace.",
                ,"../Assets/Restaurants/Vigen 1.jpg","../Assets/Restaurants/Vigen 2.jpg","../Assets/Restaurants/Vigen1.jpg","../Assets/Restaurants/Vigen2.jpg","../Assets/Restaurants/Vigen3.jpg");
            _r2 = new Restaurant("Østens Perle", "Køgevej 56, 4000 Roskilde, Denmark", "www.østens-perle.dk",
                "info@østens-perle.dk", "+45 46368236", "Lejre, Roskilde, Sealand, Møn, Lolland-Falster",
                "Maximum capacity in restaurant (100), Number of restaurants (1),Number of rooms for group activities (1)",
                "Bar, Coach/truck parking, Internet parking, Restaurant",
                "The cuisine of Østens Perle in Roskilde is inspired by Asian culinary art. Only fresh raw materials are used and exotic spices such as coriander, lemon grass, coconut milk, chilli and curry.The restaurant is situated in the centre of Roskilde close to the station.",
                "../Assets/Restaurants/perle 1.jpg","../Assets/Restaurants/perle 2.jpg","../Assets/Restaurants/perle1.jpg","../Assets/Restaurants/perle2.jpg","../Assets/Restaurants/perle3.jpg");
            _r3 = new Restaurant("Comwell Roskilde", "Vestre Kirkevej 12, 4000 Roskilde, Denmark",
                "www.comwellroskilde.dk", "hotel.roskilde@comwell.com", "+45 46323131",
                "Lejre, Roskilde, Sealand, Møn, Lolland-Falster",
                "Maximum banquet seating (300), Maximum classroom seating (150), Maximum theatre seating (285), Number of rooms for group activities (18)",
                "bar, elevator, internet parking, restaurant",
                "At Comwell Roskilde you will always experience great food, fantastic wine and good service.We are proud to have a world champion in our kitchen at Comwell Roskilde. Our head chef, Rasmus Rasmussen, won the title as the world’s best conference chef at the World Championship in Chicago in 2010 and he is still strongly passioned about his cooking. Every day he makes sure our guests are served high quality food. We only use the very best produce and the menu varies with the season. We take pride in making food that is delicious to all senses.Our bar has a great view over Roskilde Fjord. When weather allows it, you can enjoy a glass of wine or a cup of coffee at our terrace, with a view as well.At Comwell Roskilde you are always welcomed by smiling and accommodating staff, who will make your experience a special one.We look forward to welcoming you at Comwell Roskilde.",
                "../Assets/Restaurants/comwell 1.jpg","../Assets/Restaurants/comwell 2.jpg","../Assets/Restaurants/comwell1.jpg","../Assets/Restaurants/comwell2.jpg","../Assets/Restaurants/comwell3.jpg");
            _r4 = new Restaurant("Upstairs", "Skomagergade 4, 4000 Roskilde, Denmark", "www.upstairs-roskilde.dk",
                "restaurant@upstairs-roskilde.dk", "+45 46351900", "Roskilde, Sealand, Møn, Lolland-Falster",
                "Maximum capacity in restaurant (100), Number of restaurants (1),Number of rooms for group activities (1)",
                "Bar, Coach/truck parking, Internet parking, Restaurant",
                "The restaurant is situated at the beginning of the walking street of Roskilde City. The lunch menu offers amongst others: Danish open faced sandwiches, herrings, warm dishes & cheeses. The evening menu consists of 3 starters, 3 main courses, and 3 desserts, which can be combined according to taste. The menus are inspired by the seasons.The restaurant is also open sunday for brunch or lunch, but only if you have made reservations on beforehand and is minimum 20 persons.",
                "../Assets/Restaurants/upstairs 1.jpg","../Assets/Restaurants/upstairs 2.jpg","../Assets/Restaurants/upstairs1.jpg","../Assets/Restaurants/upstairs2.jpg","../Assets/Restaurants/upstairs3.jpg");
            _r5 = new Restaurant("Søfryd", "Søfrydvej 8-10, 4040 Jyllinge, 4000 Roskilde, Denmark",
                "www.hotel-sofryd.dk", "info@hotel-sofryd.dk", "+45 46 78 80 11", "Sealand, Møn, Lolland-Falster",
                "Maximum capacity in restaurant (100), Number of restaurants (1),Number of rooms for group activities (1)",
                "Bar, Coach/truck parking, Internet parking, Restaurant",
                "Restaurant Søfryd is a cosy and comfortabel restaurant placed with a view of Roskilde fjord.The menu offers both classic courses, local courses and French courses plus menues and buffets with ingredients modified the seasons. During spring, summer and autumn when the weather allows there will also be service at the terrace of the restaurant.",
                ,"../Assets/Restaurants/sofryd 1.jpg","../Assets/Restaurants/sofryd 2.jpg","../Assets/Restaurants/sofryd1.jpg","../Assets/Restaurants/sofryd2.jpg","../Assets/Restaurants/sofryd3.jpg");
            _r6 = new Restaurant("Raadhuskælderen", "Fondens Bro 3, 4000 Roskilde, Denmark", "www.raadhuskaelderen.dk",
                "mail@raadhuskaelderen.dk", "+45 46360100", "Roskilde, Sealand, Møn, Lolland-Falster",
                "Maximum capacity in restaurant (100), Number of restaurants (1),Number of rooms for group activities (1)",
                "Parking for motor coaches",
                " The Restaurant Raadhuskælderen in the heart of Roskilde offers a lunch menu of delicious Danish open sandwiches and a la carte while the dinner menu concentrates on BBQ dishes cooked on lava stone as well as fish of the day and a la carte.Lunch is served between 11-15.30, dinner between 17-21.In the summer you can enjoy your meal in the garden behind the old city hall overlooking the Roskilde Cathedral.",
               , "../Assets/Restaurants/raadhusk 2.jpg","../Assets/Restaurants/raadhusk1.jpg","../Assets/Restaurants/raadhusk2.jpg","../Assets/Restaurants/raadhusk3.jpg");
            _r7 = new Restaurant("Svogerslev", "Svogerslev Hovedgade 45, 4000 Roskilde, Denmark", "www.svogerslevkro.dk",
                "kontakt@svogerslevkro.dk", "+45 46383005", "Lejre, Roskilde Sealand, Møn, Lolland-Falster",
                "Maximum capacity in restaurant (100), Number of restaurants (1),Number of rooms for group activities (1)",
                "Parking for motor coaches",
                "Welcome to Svogerslev Inn. Svogerslev Inn is situated only a few kilometres from the city of Roskilde in quiet and peaceful surroundings. With only 30 km to Copenhagen the inn is the ideal starting point for tours and excursions. The inn has its own special charm, with thatched roof on the wings and a cosy atmosphere inside with beamed ceiling and rustic style furnishing. All together, this forms the perfect surroundings for any kind of social occasion. The inn has 18 double rooms at its disposal, all with private shower. The inn is known throughout the country for its large selection of Danish as well as international specialities.",
                ,"../Assets/Restaurants/svogerslev 2.jpg","../Assets/Restaurants/svogerslev1.jpg","../Assets/Restaurants/svogerslev2.jpg","../Assets/Restaurants/svogerslev3.jpg");
            _r8 = new Restaurant("Herthadalen", "Slangealleen 1, 4000 Roskilde, Denmark", "www.herthadalen.dk",
                "info@herthadalen.dk", "+45 4648 0157", "Lejre RoskildeSealand, Møn, Lolland-Falster",
                "Maximum capacity in restaurant (100), Number of restaurants (1),Number of rooms for group activities (1)",
                "Bar,Buffet, Free parking, Restaurant",
                "At the end of Denmark's longest avenue, Ledreborg Allé, as part of Ledreborg Castle, is Restaurant Herthadalen. Herthadalen specializes in special arrangements, and their beautiful rooms all have a private terrace overlooking the lake Knapsø. Facilities accommodate 15 to 200 people and at Ledrebrog Castle there is room for 450 guests in a private room.",
                "../Assets/Restaurans/herthalen 1.jpg", "../Assets/Restaurans/herthalen 2.jpg", "../Assets/Restaurans/herthalen1.jpg", "../Assets/Restaurans/herthalen2.jpg", "../Assets/Restaurans/herthalen3.jpg");
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
