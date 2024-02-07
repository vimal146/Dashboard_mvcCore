using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models.Domain
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
