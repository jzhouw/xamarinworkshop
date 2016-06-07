using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinWorkshopLab4
{
    public class WeatherInfo
    {
        public MainInfo main { get; set; }
    }

    public class MainInfo
    {
        public double temp { get; set; }

        public double humidity { get; set; }
    }
}
