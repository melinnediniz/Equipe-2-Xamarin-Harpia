﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_lib_harpia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaygoPage : ContentPage
    {
        public PaygoPage()
        {
            InitializeComponent();
        }

        async void PaymentTypeTapped(object sender, EventArgs e)
        {
            string[] paymentTypes = { "Não definido", "Crédito", "Débito", "Carteira Digital"};
            string option = await DisplayActionSheet("Tipo de Pagamento", "cancelar", null, paymentTypes);

            if ((option != "cancelar") && (option != null))
            {
                PaymentTypeLabel.Text = option;
            }
        }

        void ValueEntryChangedToInt(object sender, EventArgs e)
        {
            if ((ValueEntry.Text != "") && (ValueEntry.Text != null))
            {
                double num = Math.Truncate(Single.Parse(ValueEntry.Text.ToString()));
                ValueEntry.Text = num.ToString();
            }
        }

        void ParcelEntryChangedToInt(object sender, EventArgs e)
        {
            if ((ValueEntry.Text != "") && (ValueEntry.Text != null))
            {
                double num = Math.Truncate(Single.Parse(ParcelEntry.Text.ToString()));
                ParcelEntry.Text = num.ToString();
            }
        }
    }
}