
using Microsoft.AspNetCore.Mvc;
using TodoList.Api.Controllers.Models;

namespace TodoList.Api.Controllers
{
    [ApiController]
    [Route("controller")]
    public class TaskController : ControllerBase
    {
        private readonly TaskContext _taskContext;
        public TaskController(TaskContext taskContext)
        {
            _taskContext = taskContext;
        }
        [HttpPost]
        public async Task<ActionResult<TaskItem>> AddTask(TaskItem task)
        {
            var taskItem = new TaskItem
            {
                TaskName = task.TaskName,
                IsCompleted = task.IsCompleted,
            };
            await _taskContext.AddAsync(taskItem);
            await _taskContext.SaveChangesAsync();
            return Ok();
        }

    }
}