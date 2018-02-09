using System.Collections.Generic;
using System;

namespace ContactList.Models
{
  public class Contact
  {
      private string _name;
      private string _phoneNumber;
      private string _address;


      private static List<Contact> _allContacts = new List<Contact> {};

      public Contact (string name, string phoneNumber, string address)
      {
        _name = name;
        _phoneNumber = phoneNumber;
        _address = address;
      }

      public string GetName()
      {
        return _name;
      }

      public string GetPhoneNumber()
      {
        return _phoneNumber;
      }

      public string GetAddress()
      {
        return _address;
      }

      public static List<Contact> RetrieveAllContacts()
      {
        return _allContacts;
      }

    }
}
