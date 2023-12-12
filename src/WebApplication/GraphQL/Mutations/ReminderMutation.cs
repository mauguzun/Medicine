using AutoMapper;
using HotChocolate.Authorization;
using Medicine.Entities.Models.UserDoctor;
using Medicine.Infrastructure.Implementation.DataAccesPsql;

namespace Medicine.WebApplication.GraphQL.Mutations
{
    [Authorize]
    public class UserDoctorRelationMutation
    {
        [UseSorting()]
        [UseFiltering()]
        public UserDoctorRelation UpdateRelation(
            [Service] AppDbContext ctx,
            [Service] IMapper mapper,
            UserDoctorRelation reminderDto)
        {

            return null;
        }

    }

}