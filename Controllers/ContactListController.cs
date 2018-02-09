using Microsoft.AspNetCore.Mvc;
using ContactList.Models;
using System.Collections.Generic;

namespace ContactList.Controllers
{
  public class ContactListController : Controller
  {
    [HttpGet("/contacts")]
    public ActionResult ContactHome()
    {
      List<Contact> allContacts = Contact.RetrieveAllContacts();
      return View(allContacts);
    }

    [HttpGet("/contacts/form")]
    public ActionResult ContactForm()
    {
      return View();
    }

    [HttpPost("/address-add-new")]
    public ActionResult SubmitAddress()
    {
      return View();
    }

    }

  }
