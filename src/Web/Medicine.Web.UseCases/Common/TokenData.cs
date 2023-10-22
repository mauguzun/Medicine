using Medicine.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeZone = Medicine.Entities.Enums.TimeZone;

namespace Medicine.Web.UseCases.Common
{


    public class TokenData
    {
        public string Email { get; set; }
        public int Id { get; set; }
        public Language Language { get; set; } = Language.en;
        public string Name { get; set; }
        public TimeZone TimeZone { get; set; } = TimeZone.CoordinatedUniversalTime;
        public SystemRole Role { get; private set; } = SystemRole.User;
        public Sex Sex { get; set; } = Sex.Male;
        public DateOnly? Birthday { get; set; }
        public string PhoneNumber { get; set; }

        public void SetRole (string role)
        {
            var asdfas = role;
        }
    }
}
