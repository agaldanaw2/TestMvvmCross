using System.Collections.Generic;
using TestsMvvmCross.Core.Model;

namespace TestsMvvmCross.Core.Services.Definitions
{
    public interface IContactService
    {
        IEnumerable<Contact> FetchContacts();
    }
}
