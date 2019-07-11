using System.Collections.Generic;

namespace address_book
{
    public class AddressBook
    {
        public Dictionary<string, Contact> contacts{get; set;} = new Dictionary<string, Contact>();

        public void AddContact(Contact name)
        {
            contacts.Add(name.Email, name);
        }
    public Contact GetByEmail(string Email)
        {
            return contacts[Email];
        }
    }

 
}