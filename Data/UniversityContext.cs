using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication4.Models;

namespace WebApplication4.Data
{
	public class UniversityContext : DbContext
	{
		
        static private UniversityContext universityContextInstance = null;
        public DbSet<Student>? Student { get; set; }
		
		public UniversityContext(DbContextOptions o) : base(o) { }

		public static UniversityContext Instantiate_University_Context()
		{
            if (universityContextInstance == null)
            {

                var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
                optionsBuilder.UseSqlite(@"Data Source=C:\Users\Nada\source\repos\tp4-net\tp4-net\tp4.db");
                universityContextInstance = new UniversityContext(optionsBuilder.Options);
                Debug.WriteLine("instance created for the first time");
                return universityContextInstance;
            }
            else
            {
                Debug.WriteLine("instance already created");
                return universityContextInstance;
            }
        }


	}
}
