using AutoMapper;
using Medicine.Entities.Models.Auth;
using Medicine.Entities.Models.Courses;
using Medicine.Entities.Models.Dosages;
using Medicine.Entities.Models.Drugs;
using Medicine.Entities.Models.Reminders;
using Medicine.Entities.Models.Therapies;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.Models.Auth.Dto;
using Medicine.Web.UseCases.Models.GraphqlResponse.Base.Translates;
using Medicine.Web.UseCases.Models.GraphqlResponse.Course;
using Medicine.Web.UseCases.Models.GraphqlResponse.Dosage;
using Medicine.Web.UseCases.Models.GraphqlResponse.Drug;
using Medicine.Web.UseCases.Models.GraphqlResponse.Reminder;
using Medicine.Web.UseCases.Models.GraphqlResponse.Therapy;
using Medicine.Web.UseCases.Models.GraphqlResponse.Users;

namespace Medicine.Web.UseCases.Utils
{
    public class MapperProfile : Profile
    {

        public MapperProfile()
        {

            CreateMap<DosingFrequencyReminderResponse, DosingFrequencyReminder>().ReverseMap();
            CreateMap<ReminderResponse, Reminder>().ReverseMap();
            CreateMap<DosingFrequencyResponse, DosingFrequency>().ReverseMap();
            CreateMap<DosageLogResponse, DosageLog>().ReverseMap();
            CreateMap<CourseResponse, Course>().ReverseMap();
            CreateMap<TherapyResponse, Therapy>().ReverseMap();
            CreateMap<CourseSettingsResponse, CourseSettings>().ReverseMap();
            CreateMap<CourseGroupResponse, CourseGroup>().ReverseMap();
            CreateMap<DrugReponse, Drug>().ReverseMap();
            CreateMap<DrugCategoryResponse, DrugCategory>().ReverseMap();
            CreateMap<ActiveElementResponse, ActiveElement>().ReverseMap();
            CreateMap<SimilarDrugsDto, SimilarDrugs>().ReverseMap();
            CreateMap<User, UserResponse>().ReverseMap();

            CreateMap<TranslatedDosingFrequency, TranslatedResponse>().ReverseMap();
            CreateMap<TranslatedCourse, TranslatedResponse>().ReverseMap();
            CreateMap<TranslatedTherapy, TranslatedResponse>().ReverseMap();
            CreateMap<TranslatedDrugs, TranslatedDrugsResponce>().ReverseMap();
            CreateMap<TranslatedDrugsCategory, TranslatedResponse>().ReverseMap();


            CreateMap<User, UserSettingsDto>()
                            .ForMember(dest => dest.Role, opt => opt.Ignore()).ReverseMap();


        }
    }
}
