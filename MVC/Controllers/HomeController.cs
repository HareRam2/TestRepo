using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
	public partial class HomeController : Controller
	{		
		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}

	public partial class HomeController
	{
		public ActionResult Index()
		{
			return View();
		}

		// Car Exterior Functionality 
		public void BuildTrim() { }
		public void BuildWheels() { }
	}
		public partial class HomeController
	{
		// A partial method definiton
		partial void InitializeCar();
		public ActionResult About()
		{
			InitializeCar();
			return View();
		}
		// Car Interior Functionality 
		public void BuildSeats() { }
		public void BuildDashboard() { }
		}
		public partial class HomeController
		{

		// A partial method implementaion
		partial void InitializeCar()
		{
			string str = "Car";
			ViewBag.Message = "Your application description page."+str;
			// Put all car initialization here
		}
		/// Car Engine
		public void BuildEngine() { }
		}
			 
}