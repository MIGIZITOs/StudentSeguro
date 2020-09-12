namespace admStudentAuth.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<admStudentAuth.Models.Student> Students { get; set; }
    }
}