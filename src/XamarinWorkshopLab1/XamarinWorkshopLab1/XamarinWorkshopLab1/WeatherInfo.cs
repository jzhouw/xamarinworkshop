using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinWorkshopLab1
{
    public class WeatherInfo
    {
        public MainInfo main { get; set; }
    }
    
    public class MainInfo
    {
        public double temp { get; set; }

        public double humidity {get;set;}
    }
}
