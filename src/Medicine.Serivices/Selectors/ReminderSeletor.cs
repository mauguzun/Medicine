using Medicine.Domain.Entities;
using Medicine.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Medicine.Domain.Selectors
{
    public class ReminderSeletor
    {
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Drug> Drugs { get; set; }


        public void SelectByTime()
        {


            var time = new TimeOnly(DateTime.UtcNow.Hour, DateTime.UtcNow.Minute);
            var lang = Language.enUs;

            var selected = Reminders
                .Include(x => x.DosageRecommendations)
                .ThenInclude(x => x.DosingFrequency)
                .ThenInclude(x => x.Course)
                .ThenInclude(x => x.Therapy)
                .Where(x => x.Time == time);


      


        }
    }
}
