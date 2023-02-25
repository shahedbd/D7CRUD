using System.ComponentModel.DataAnnotations;

namespace D7CRUD.Models
{
    public class Category
    {
        public Int64 Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
