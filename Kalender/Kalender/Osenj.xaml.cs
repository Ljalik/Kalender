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
    public partial class Osenj : TabbedPage
    {
        public Osenj()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("начало войны", "1 сентября началась Вторая Мировая война", "välja");
        }
        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await DisplayAlert("День учителей", "День учителей и наставников в Узбекистане  Праздники Узбекистана. У каждого из нас есть свой Учитель и свой Наставник. Это люди, без которых мы не состоялись бы как личности, не получили бы жизненно важных навыков, знаний и умений.", "välja");
        }
        private async void Button_Clicked2(object sender, EventArgs e)
        {
            await DisplayAlert("Сталинград", "19 ноября 1942 года в ходе Великой Отечественной войны началась одна из крупнейших стратегических операций советских войск под кодовым названием «Уран». Началось контрнаступление в районе Сталинграда.", "välja");
        }

    }
}