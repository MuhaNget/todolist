

namespace TodoApp.Api.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public bool IsComplete { get; set; }
    }
}