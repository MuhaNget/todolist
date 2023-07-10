

namespace TodoList.Api.Controllers.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public bool IsCompleted { get; set; }
    }
}