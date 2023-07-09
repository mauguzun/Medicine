using Medicine.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine.Application.Interfaces
{
    public interface IReminderService
    {
        public IList<Reminder> Get();
    }
}
