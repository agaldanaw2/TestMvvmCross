using System.Collections.Generic;
using TestsMvvmCross.Core.Model;
using TestsMvvmCross.Core.Services.Definitions;

namespace TestsMvvmCross.Core.Services.Implementations
{
    public class ContactService : IContactService
    {
        public IEnumerable<Contact> FetchContacts()
        {
            var contacts = new List<Contact>();
            for (int i = 0; i < 10; i++)
            {
                contacts.Add(new Contact { Id = i, Name = $"Contact {i}" });
            }
            return contacts;
        }
    }
}
