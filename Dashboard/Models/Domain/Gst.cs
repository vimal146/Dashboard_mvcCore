using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models.Domain
{
    public class Gst
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
