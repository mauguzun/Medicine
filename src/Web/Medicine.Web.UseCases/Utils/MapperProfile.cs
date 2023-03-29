using AutoMapper;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Web.UseCases.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine.Web.UseCases.Utils
{
    public class MapperProfile : Profile
    {

        public MapperProfile()
        {

            CreateMap<Reminder, ReminderDto>();

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
