﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;


namespace Vidly.Controllers
{
	public class CustomersController : Controller
	{

		// -- Get Customers from Database --
		private ApplicationDbContext _context;

		public CustomersController()
		{
			_context = new ApplicationDbContext();
		}
		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}
		// -- Get Customers from Database --

		
		public ViewResult Index()
		{
			var customers = _context.Customers.Include(c => c.MembershipType).ToList();
			//var customers = GetCustomers();
			return View(customers);
		}

		// GET: /Customers/
		public ActionResult Details(int id)
		{

			var customers = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
			//var customer = _context.Customers.ToList().SingleOrDefault(c => c.Id == id);
			// var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

			//if (customers == null)
			//    return HttpNotFound();

			return View(customers);
		   //return View(customer);
		}


		//// -- Get Customers from Database --
		//private IEnumerable<Customer> GetCustomers()
		//{
		//    return new List<Customer>
		//     {
		//         new Customer { Id = 1, Name = "John Smith" },
		//         new Customer { Id = 2, Name = "Mary Williams" }
		//     };
		//}

	}
}