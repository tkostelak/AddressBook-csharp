using Microsoft.AspNetCore.Mvc;
using Address.Models;
using System.Collections.Generic;

namespace AddressBook.Controllers
{
  public class AddressBookController : Controllers
  {
    [HttpGet("/address")]
    public ActionResult AddressList()
    {
      return View()
    }

    [HttpGet("/address-form")]
    public ActionResult AddressForm()
    {
      return View()
    }

    [HttpPost("/address-add-new")]
    public ActionResult SubmitAddress()

    }

  }

}
