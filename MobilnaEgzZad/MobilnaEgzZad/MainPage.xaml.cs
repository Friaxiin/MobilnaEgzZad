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

        /*private void CheckPrice(object sender, EventArgs e)
        {
            if (washing.IsChecked)
            {
                Price = 50;
                service = "Pranie";
                image.Source = "pralka.jpg";
            }
            if (vaccuming.IsChecked)
            {
                Price = 70;
                service = "Odkurzanie";
                image.Source = "odkurzacz.jpg";
            }
            if (fasterService.IsChecked)
            {
                Price *= 1.3;
            }
            price.Text = Price.ToString();
        }*/


        private void Accept(object sender, EventArgs e)
        {
            if (washing.IsChecked || vaccuming.IsChecked)
            {
                DisplayAlert("Zamówienie zaakceptowane!", "Twoje zamówienie: " + service + " zostało zaakceptowane" + "\nCena: " + Price + " zł", "OK");
            }
            else
            {
                DisplayAlert("Błąd", "Wybierz usługę", "OK");
            }
        }

        private void CheckSelection(object sender, CheckedChangedEventArgs e)
        {
            if (washing.IsChecked)
            {
                Price = 50;
                service = "Pranie";
                image.Source = "pralka.jpg";
            }
            if (vaccuming.IsChecked)
            {
                Price = 70;
                service = "Odkurzanie";
                image.Source = "odkurzacz.jpg";
            }
            price.Text = Price.ToString();
        }

        private void CheckCheckbox(object sender, CheckedChangedEventArgs e)
        {
            if (fasterService.IsChecked)
            {
                price.Text = (1.3 * Price).ToString();
            }
            else
            {
                price.Text = Price.ToString();

            }
        }
    }
}
