using AutoMapper;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Translated;
using Medicine.Web.UseCases.Responses;
using Medicine.Web.UseCases.Responses.Translates;

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
            CreateMap<DrugResponse, Drug>().ReverseMap();
            CreateMap<DrugCategoryResponse, DrugCategory>().ReverseMap();
            CreateMap<ActiveElementResponse, ActiveElement>().ReverseMap();
            CreateMap<SimilarDrugsResponse, SimilarDrugs>().ReverseMap();

            CreateMap<TranslatedDosingFrequency, TranslatedResponse>().ReverseMap();
            CreateMap<TranslatedCourse, TranslatedResponse>().ReverseMap();
            CreateMap<TranslatedTherapy, TranslatedResponse>().ReverseMap();
            CreateMap<TranslatedDrugs, TranslatedDrugsResponce>().ReverseMap();
            CreateMap<TranslatedDrugsCategory, TranslatedResponse>().ReverseMap();

        }
    }
}
