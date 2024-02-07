using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models
{
    public class AddGst
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
