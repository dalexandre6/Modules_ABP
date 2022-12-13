using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace ModuleA
{
    public class TodoOne : Entity<Guid> //Inheritance added DM3
    {
        public string Content { get; set; }
        public bool IsDone { get; set; }
    }
}
