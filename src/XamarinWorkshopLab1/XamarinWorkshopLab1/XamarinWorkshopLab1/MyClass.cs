using System;

namespace XamarinWorkshopLab1
{
	public class MyClass
	{
		public MyClass ()
		{
            
        }

        public async System.Threading.Tasks.Task<string> GetWeather()
        {
            string city = "beijing";

            //如下代码需要Internet网络
            //string apiKey = "1f05b04d2ec44ac5f74dffe877e4234d"; //http://openweathermap.org/api
            //string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&APPID={apiKey}";
            //System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
            //string jsonWeather = await httpClient.GetStringAsync(apiUrl);
            //WeatherInfo weather = Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherInfo>(jsonWeather);
            //return $"{city} 气温: {weather.main.temp}, 湿度: {weather.main.humidity}";

            //没有Internet网络时,请使用如下代码
            return $"{city} 气温: 22, 湿度: 11";
        }

        public string GetDevice()
        {
            
#if __ANDROID__
            return $"{Android.OS.Build.Brand} {Android.OS.Build.Model}";
#elif __IOS__
            return $"{UIKit.UIDevice.CurrentDevice.Name} {UIKit.UIDevice.CurrentDevice.Model}";
#elif WINDOWS_PHONE_APP
            Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation deviceInfo = new Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation();
            return $"{deviceInfo.SystemManufacturer} {deviceInfo.FriendlyName}"; 
#endif
        }
    }
}

