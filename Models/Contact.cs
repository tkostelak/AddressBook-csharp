using System.Collections.Generic;
using System;

namespace ContactList.Models
{
  public class Contact
  {
      private string _name;
      private string _phoneNumber;
      private string _address;
      // private int _id;

      private static List<Contact> _instances = new List<Contact> {};

      public Contact (string name, string phoneNumber, string address)
      {
        _name = name;
        _phoneNumber = phoneNumber;
        _address = address;
        // _id = _instances.Count;
      }

      public void SetName(string newName)
      {
        _name = newName;
      }

      public string GetName()
      {
        return _name;
      }

      public void SetPhoneNumber(string newPhoneNumber)
      {
        _phoneNumber = newPhoneNumber;
      }

      public string GetPhoneNumber()
      {
        return _phoneNumber;
      }

      public void SetAddress(string newAddress)
      {
        _address = newAddress;
      }

      public string GetAddress()
      {
        return _address;
      }

      public static List<Contact> GetAll()
      {
        return _instances;
      }

      // public int GetId()
      // {
      //   return _id;
      // }

      public void Save()
      {
        _instances.Add(this);
      }

      public static void ClearAll()
      {
        _instances.Clear();
      }

      // public static Contact Find(int searchId)
      // {
      //   return _instances[searchId];
      // }
    }
  }
