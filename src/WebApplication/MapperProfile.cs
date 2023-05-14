using AutoMapper;
using Medicine.Entities.Models;
using Medicine.Web.UseCases.Dto;
using Medicine.Web.UseCases.Reminder.Dto;
using Medicine.WebApplication.GraphQL.Entities.DosageRecommendations.Response;
using Medicine.WebApplication.GraphQL.Entities.Reminders.Response;

namespace Medicine.WebApplication
{
    public class MapperProfile : Profile
    {

        public MapperProfile()
        {

            CreateMap<Reminder, ReminderDto>();


            CreateMap<DosageRecommendation,DosageRecommendationResponse>().ReverseMap();
            CreateMap<Reminder, ReminderResponse>().ReverseMap();
            CreateMap<DosageRecommendation, DosageRecommendationResponse>().ReverseMap();
            //.ForSourceMember(x => x.DosageRecommendations, opt => opt.DoNotValidate());





            CreateMap<Therapy, TherapyDto>().ForMember(
                    dest => dest.Title,
                    opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Title))
                 .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Description))
                 .ForMember(
                    dest => dest.Language,
                    opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Language));


            CreateMap<Course, CourseDto>().ForMember(
                    dest => dest.Title,
                    opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Title))
                 .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Description))
                 .ForMember(
                    dest => dest.Language,
                    opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Language));

            CreateMap<DosageRecommendation, DosageRecommendationDto>().ForMember(
                    dest => dest.Title,
                    opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Title))
                 .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Description))
                 .ForMember(
                    dest => dest.Language,
                    opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Language));

            CreateMap<DosingFrequency, DosingFrequencyDto>().ForMember(
                    dest => dest.Title,
                    opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Title))
                 .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Description))
                 .ForMember(
                    dest => dest.Language,
                    opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Language));

            CreateMap<Drug, DrugDto>().ForMember(
                    dest => dest.Title,
                    opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Title))
                 .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Description))
                 .ForMember(
                    dest => dest.Language,
                    opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Language));


        }
    }
}
