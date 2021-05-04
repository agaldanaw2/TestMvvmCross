
using TestsMvvmCross.Core.Model;

namespace TestsMvvmCross.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ContactSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            ViewModel.ShowContactDetails(e.SelectedItem as Contact);
        }
    }
}
