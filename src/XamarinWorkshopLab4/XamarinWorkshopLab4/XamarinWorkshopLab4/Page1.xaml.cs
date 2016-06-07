using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinWorkshopLab4
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            this.BindingContext = new Page1ViewModel();
        }
    }
}
