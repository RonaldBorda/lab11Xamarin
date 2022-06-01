using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lab11.Views
{
    public partial class Operations : ContentPage
    {
        public Operations()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.OperationsViewModel();
        }
    }
}
