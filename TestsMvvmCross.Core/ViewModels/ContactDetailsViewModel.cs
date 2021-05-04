using MvvmCross.ViewModels;
using TestsMvvmCross.Core.Model;

namespace TestsMvvmCross.Core.ViewModels
{
    public class ContactDetailsViewModel : MvxViewModel<Contact>
    {
        public Contact Contact { get; private set; }
        public override void Prepare(Contact parameter)
        {
            Contact = parameter;
        }
    }
}
