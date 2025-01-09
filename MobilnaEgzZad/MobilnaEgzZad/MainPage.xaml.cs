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
        private void Accept(object sender, EventArgs e)
        {
            if (washing.IsChecked || vaccuming.IsChecked)
            {
                DisplayAlert("Zamówienie zaakceptowane!", "Twoje zamówienie: " + service + " zostało zaakceptowane" + "\nCena: " + price.Text + " zł", "OK");
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
                fasterService.IsChecked = false;
            }
            if (vaccuming.IsChecked)
            {
                Price = 70;
                service = "Odkurzanie";
                image.Source = "odkurzacz.jpg";
                fasterService.IsChecked = false;
            }
            price.Text = Price.ToString() + " zł";
        }
        private void CheckCheckbox(object sender, CheckedChangedEventArgs e)
        {
            if (washing.IsChecked || vaccuming.IsChecked)
            {
                if (fasterService.IsChecked)
                {
                    price.Text = (1.3 * Price).ToString() + " zł";
                }
                else
                {
                    price.Text = Price.ToString() + " zł";
                }
            }
            else
            {
                fasterService.IsEnabled = false;
            }
        }
    }
}
