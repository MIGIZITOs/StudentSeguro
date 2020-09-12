

namespace APIStudentAuth.Models
{
    using System.Data.Entity;
    public class DataContext: DbContext 
    {
        public DataContext(): base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APIStudentAuth.Models.Student> Students { get; set; }
    }
}