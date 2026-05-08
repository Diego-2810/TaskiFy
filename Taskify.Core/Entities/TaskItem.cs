using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taskify.Core.Enums;

namespace Taskify.Core.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; } = false;
        public int ExperienceReward { get; set; }
        public TaskDifficulty Difficulty { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int UserId { get; set; }
        public int CategoryId { get; set; }
    }
}