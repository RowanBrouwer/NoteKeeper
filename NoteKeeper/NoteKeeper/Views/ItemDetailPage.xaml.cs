using System.ComponentModel;
using Xamarin.Forms;
using NoteKeeper.ViewModels;
using System;
using NoteKeeper.Models;
using System.Collections.Generic;
using NoteKeeper.Services;

namespace NoteKeeper.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel ViewModel;
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            this.ViewModel = viewModel;
            BindingContext = this.ViewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();
            ViewModel = new ItemDetailViewModel();
            BindingContext = ViewModel;
        }

        public void Cancel_Clicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert ("Cancel option", "Cancel was selected", "Button 2", "Button 1");
        }

        public void Save_Clicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Save option", "Save was dlicked", "Button 2", "Button 1");
        }
    }
}