using System;
using System.Collections.Generic;

namespace Exceptions_Catch
{
    public class AddressBook
    {
        public Dictionary<string, Contact> addressbook = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            addressbook.Add(contact.Email, contact);
        }

        public Contact GetByEmail(string email)
        {
            try
            {
                Contact returnContact = addressbook[email];
                return returnContact;
            }
            catch(KeyNotFoundException)
            {
                return null;
            }
        }

    }
}