using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinWorkshopLab4
{
    public class Page1ViewModel : System.ComponentModel.INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}

        private string _city;
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
                OnPropertyChanged("City");
            }
        }

        private string _weatherData;
        public string WeatherData
        {
            get { return _weatherData; }
            set
            {
                _weatherData = value;
                OnPropertyChanged("WeatherData");
            }
        }

        private string _deviceData;
        public string DeviceData
        {
            get { return _deviceData; }
            set
            {
                _deviceData = value;
                OnPropertyChanged("DeviceData");
            }
        }

        public System.Windows.Input.ICommand GetCommand { get; set; }

        public Page1ViewModel()
        {
            City = "Beijing";
            GetCommand = new Xamarin.Forms.Command(GetData);
        }

        private async void GetData()
        {
            WeatherData = await GetWeather(City);

            DeviceData = $"{Plugin.DeviceInfo.CrossDeviceInfo.Current.Platform} {Plugin.DeviceInfo.CrossDeviceInfo.Current.Model}";
        }

        public async System.Threading.Tasks.Task<string> GetWeather(string city)
        {
           
            //如下代码需要Internet网络
            string apiKey = "1f05b04d2ec44ac5f74dffe877e4234d"; //http://openweathermap.org/api
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&APPID={apiKey}";
            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
            string jsonWeather = await httpClient.GetStringAsync(apiUrl);
            WeatherInfo weather = Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherInfo>(jsonWeather);
            return $"{city} 气温: {weather.main.temp}, 湿度: {weather.main.humidity}";

            //没有Internet网络时,请使用如下代码
            //return $"{city} 气温: 22, 湿度: 11";
        }
    }
}
