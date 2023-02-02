using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
//------------------------------------------------------------------------------// 
/*
The mapping is found in Program.cs file with the 
MapControllerRoute function.

- The HelloWorldController class to use Razor view files. This cleanly 
    encapsulates the process of generating HTML responses to a client.

View templates are created using Razor. Razor-based view templates:

    - Have a .cshtml file extension.
    - Provide an elegant way to create HTML output with C#.

Controller methods:

Are referred to as action methods. For example, the Index action method in the preceding code.
Generally return an IActionResult or a class derived from ActionResult, not a type like string.
*/
//------------------------------------------------------------------------------// 
    
    
    //GET: /HelloWorld/
    /*Currently the Index method returns a string with a message in the 
    controller class.*/
    public IActionResult Index()
    {
        //Calls the controller's View method.Uses a view template to generate an HTML response.
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
    
    //public string MyMethodURI(string name, int numTimes = 1)
    //{return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");}


}