using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    [Table("tasks")]
    public class Task
    {
        [Key]
		public int TaskId { get; set; }
		public string Description { get; set; }
        [ForeignKey("Category")]
        private int CategoryId { get; set; }

		public Task()
		{
		}
	}
}
