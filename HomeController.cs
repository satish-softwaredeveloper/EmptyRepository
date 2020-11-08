using System.Web.MVC;
using System.Web;
namespace GitTutorial
{
  public partial class HomeController : Controller
  {
     public void GetData()
	  {
	  //Body of GetData
	  }
	
	  //Changes made in Master branch in gitHub 
	  public void Display()
	  {
	  //Body of Display method
	   Response.Write("Display method Called");
	   //MOdified in master branch to test git merge from git
	  }
  }
}
