using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kalender
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vesna : TabbedPage
    {
        public Vesna()
        {
            InitializeComponent();
        }
        private async void Button_Clicked9(object sender, EventArgs e)
        {
            await DisplayAlert("март", "1 месяц лета", "välja");
        }
        private async void Button_Clicked10(object sender, EventArgs e)
        {
            await DisplayAlert("мой др", "12 Апреля день рождения великиго императора Владислава Лялика", "välja");
        }
        private async void Button_Clicked11(object sender, EventArgs e)
        {
            await DisplayAlert("день победы", "9 мая завершилась Вторая Мировая война", "välja");
        }
    }
}