using AutoMapper;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Auth;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.Common;
using Medicine.Web.UseCases.Responses;
using Medicine.Web.UseCases.Responses.Base;
using Medicine.Web.UseCases.Responses.Translates;

namespace Medicine.Web.UseCases.Utils
{
    public class MapperProfile : Profile
    {

        public MapperProfile()
        {

            CreateMap<DosingFrequencyReminderDto, DosingFrequencyReminder>().ReverseMap();
            CreateMap<ReminderDto, Reminder>().ReverseMap();
            CreateMap<DosingFrequencyDto, DosingFrequency>().ReverseMap();
            CreateMap<DosageLogDto, DosageLog>().ReverseMap();
            CreateMap<CourseDto, Course>().ReverseMap();
            CreateMap<TherapyDto, Therapy>().ReverseMap();
            CreateMap<CourseSettingsDto, CourseSettings>().ReverseMap();
            CreateMap<CourseGroupDto, CourseGroup>().ReverseMap();
            CreateMap<DrugDto, Drug>().ReverseMap();
            CreateMap<DrugCategoryDto, DrugCategory>().ReverseMap();
            CreateMap<ActiveElementResponse, ActiveElement>().ReverseMap();
            CreateMap<SimilarDrugsDto, SimilarDrugs>().ReverseMap();

            CreateMap<TranslatedDosingFrequency, TranslatedDto>().ReverseMap();
            CreateMap<TranslatedCourse, TranslatedDto>().ReverseMap();
            CreateMap<TranslatedTherapy, TranslatedDto>().ReverseMap();
            CreateMap<TranslatedDrugs, TranslatedDrugsResponce>().ReverseMap();
            CreateMap<TranslatedDrugsCategory, TranslatedDto>().ReverseMap();

            CreateMap<User, TokenData>()
                            .ForMember(dest => dest.Role, opt => opt.Ignore());


        }
    }
}
