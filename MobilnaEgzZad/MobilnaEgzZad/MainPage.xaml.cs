using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobilnaEgzZad
{
    public partial class MainPage : ContentPage
    {
        string service = "";
        double Price = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void CheckPrice(object sender, EventArgs e)
        {
            if (washing.IsChecked)
            {
                Price = 50;
                service = "Pranie";
            }
            if (vaccuming.IsChecked)
            {
                Price = 70;
                service = "Odkurzanie";
            }
            if (fasterService.IsChecked)
            {
                Price *= 1.3;
            }
            price.Text = Price.ToString();
        }

        private void Accept(object sender, EventArgs e)
        {
            if (washing.IsChecked || vaccuming.IsChecked && price.Text != "")
            {
                DisplayAlert("Zamówienie zaakceptowane!", "Twoje zamówienie: " + service + "zostało zaakceptowane" + "\n Cena: " + Price + " zł", "OK");
            }
        }
    }
}
