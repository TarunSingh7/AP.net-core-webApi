using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace WebApplication1.dbconnect
{
	public class dbconnection:DbContext
	{
		public dbconnection()
		{

		}
		public dbconnection(DbContextOptions<dbconnection>Hello ): base(Hello)
		{
		}
		public DbSet<Employee> Employees { get; set; }

	}
}
