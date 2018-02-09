using Microsoft.AspNetCore.Mvc;
using ContactList.Models;
using System.Collections.Generic;

namespace ContactList.Controllers
{
  public class ContactListController : Controller
  {
    [HttpGet("/")]
    public ActionResult ContactHome()
    {
      List<Contact> allContacts = Contact.GetAll();
      return View(allContacts);
    }

    [HttpGet("/contacts/form")]
    public ActionResult ContactForm()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult Create()
    {
      Contact newContact = new Contact (Request.Form["name"], Request.Form["phoneNumber"], Request.Form["address"]);
      newContact.Save();
      List<Contact> allContacts = Contact.GetAll();
      return View("ContactHome", allContacts);

    }

    [HttpPost("/contacts/delete")]
    public ActionResult ClearContactForm()
      {
        Contact.ClearAll();
        return View();
      }

    }

  }
