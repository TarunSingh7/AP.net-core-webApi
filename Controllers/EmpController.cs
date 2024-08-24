using Microsoft.AspNetCore.Mvc;
using WebApplication1.dbconnect;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	[ApiController]
	public class EmpController : ControllerBase
	{
		private readonly dbconnection _db;
		public EmpController(dbconnection db)
		{

			_db = db;
		}


		[HttpGet]
		[Route("api/getname")]
		public string hello()
		{
			string hh = "this is tarun here ";
			return hh;
		}

		[HttpGet]
		[Route("api/GetEmpdata")]
		public List<Employee> GetEmpdata()
		{
			var data = _db.Employees.ToList();
			return data;
		}
		[HttpDelete]
		[Route("api/DeleteData")]

		public void Delete(int id)
		{
			var data = _db.Employees.Where(a => a.Id == id).FirstOrDefault();
			_db.Employees.Remove(data);
			_db.SaveChanges();
		}
		[HttpPost]
		[Route("api/adddata")]
		public IActionResult AddOrUpdateEmployee(Employee obj)
		{
			if (obj == null)
			{
				return BadRequest("Employee object is null.");
			}

			if (obj.Id == 0)
			{
				_db.Employees.Add(obj);
			}
			else
			{
				var existingEmployee = _db.Employees.Find(obj.Id);
				if (existingEmployee == null)
				{
					return NotFound("Employee not found.");
				}

				_db.Entry(existingEmployee).CurrentValues.SetValues(obj);
			}

			_db.SaveChanges();
			return Ok("Operation successful.");
		}
		[HttpGet]
		[Route("api/getById")]
		public IActionResult getById(int id)
		{
			var res=_db.Employees.Where(a=>a.Id == id).FirstOrDefault();
			return Ok(res);
		}
	}
}