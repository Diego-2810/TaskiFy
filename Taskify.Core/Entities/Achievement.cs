using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taskify.Core.Entities
{
    public class Achievement
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Requiredvalue { get; set; }
    }
}