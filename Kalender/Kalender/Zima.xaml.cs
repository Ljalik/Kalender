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
    public partial class Zima : TabbedPage
    {
        public Zima()
        {
            InitializeComponent();
        }
        private async void Button_Clicked3(object sender, EventArgs e)
        {
            await DisplayAlert("договор", "2 декабря 1939 между СССР и ФДР был заключён Договор о взаимопомощи и дружбе. Основные положения этого договора соответствовали требованиям, которые ранее СССР предъявлял финским представителям (передача территорий на Карельском перешейке, продажа ряда островов в Финском заливе, сдача в аренду Ханко). В обмен предусматривалась передача Финляндии значительных территорий в Советской Карелии и денежная компенсация. Статья 8 договора обещала ратификацию «в возможно более короткий срок в столице Финляндии — городе Хельсинки».", "välja");
        }
        private async void Button_Clicked4(object sender, EventArgs e)
        {
            await DisplayAlert("наступленин", "Калинковичско-Мозырская наступательная операция (8—30 января 1944 года) — наступательная операция советских войск Белорусского фронта в Великой Отечественной войне.", "välja");
        }
        private async void Button_Clicked5(object sender, EventArgs e)
        {
            await DisplayAlert("ростов", "Ростовская наступательная операция 1943 года (1 января — 18 февраля 1943 года) — наступательная операция войск Южного фронта, проведённая при содействии Закавказского фронта, а с 24 января — Северо-Кавказского фронта; часть Северо-Кавказской операции 1943 г. Цель — освободить Ростов-на-Дону, отрезать пути отхода северо-кавказской группировке противника на север.", "välja");
        }
    }
}