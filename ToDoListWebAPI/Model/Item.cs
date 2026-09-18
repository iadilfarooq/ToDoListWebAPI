using System.ComponentModel.DataAnnotations;

namespace ToDoListWebAPI.Model
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public string Discription { get; set; }

        [Required]
        public bool isCompleted { get; set; }=false;
    }
}
