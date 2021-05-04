using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using TestsMvvmCross.Core.Model;
using TestsMvvmCross.Core.Services.Definitions;
using Xamarin.Forms;

namespace TestsMvvmCross.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private IContactService ContactService { get; }
        private IMvxNavigationService NavigationService { get; }
        public string WelcomeText => "Hello Xamarin.Forms with MvvmCross Test By Andrés";

        public MainViewModel(IMvxNavigationService navigationService, IContactService contactService)
        {
            ContactService = contactService;
            NavigationService = navigationService;
        }

        public ICommand FlashCommand => new Command<Contact>((obj ) =>
        {
            ShowContactDetails(obj);
        });


        public ObservableCollection<Contact> Contacts { get; set; }

        public override Task Initialize()
        {
            var contacts = ContactService.FetchContacts();
            Contacts = new ObservableCollection<Contact>(contacts);
            return base.Initialize();
        }

        public Task ShowContactDetails(Contact contact)
        {
            return NavigationService.Navigate<ContactDetailsViewModel, Contact>(contact);
        }

    }
}
