using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taskify.Core.Entities
{
    public class UserAchievement
    {
        public int UserId { get; set; }
        public int AchievementId { get; set; }
        public DateTime UnlockedAt { get; set; } = DateTime.UtcNow;
    }
}