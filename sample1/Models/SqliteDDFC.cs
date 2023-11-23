
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sample1.Models
{
    public class SqliteDDFC : DbContext
    {

        public SqliteDDFC(DbContextOptions<SqliteDDFC> options) : base(options)
        {

        }

        public DbSet<Depts> Dept { get; set; }
    }







    [Table("Dept")]
    public class Depts
    {
        [Key]
        [Required]
        public int deptid { get; set; }
        public string? dname { get; set; }

        public string? location { get; set; }
        public string? location_type { get; set; }
        public string? location_id { get; set; }
    }
}
