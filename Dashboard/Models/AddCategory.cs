using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models
{
    public class AddCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
