using System.ComponentModel;
using Xamarin.Forms;
using NoteKeeper.ViewModels;

namespace NoteKeeper.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}