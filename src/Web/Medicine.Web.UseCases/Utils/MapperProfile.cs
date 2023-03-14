using AutoMapper;
using Medicine.Entities.Models;
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

            CreateMap<Therapy, TherapyDto>()
                .ForMember(
                    dest => dest.Title,
                    opt => opt.MapFrom(x => x.Translations.FirstOrDefault().Title ?? string.Empty))
                 .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(x => x.Translations.FirstOrDefault().Description ?? string.Empty));


            CreateMap<Course, CourseDto>()
                    .ForMember(
                    dest => dest.Title,
                    opt => opt.MapFrom(x => x.Translations.FirstOrDefault().Title ?? string.Empty))
                 .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(x => x.Translations.FirstOrDefault().Description ?? string.Empty));

            CreateMap<DosageRecommendation, DosageRecommendationDto>()
                  .ForMember(
                    dest => dest.Title,
                    opt => opt.MapFrom(x => x.Translations.FirstOrDefault().Title ?? string.Empty))
                 .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(x => x.Translations.FirstOrDefault().Description ?? string.Empty));

            CreateMap<DosingFrequency, DosingFrequencyDto>()
                .ForMember(
                    dest => dest.Title,
                    opt => opt.MapFrom(x => x.Translations.FirstOrDefault().Title ?? string.Empty))
                 .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(x => x.Translations.FirstOrDefault().Description ?? string.Empty));

            CreateMap<Drug, DrugDto>()
                .ForMember(
                    dest => dest.Title,
                    opt => opt.MapFrom(x => x.Translations.FirstOrDefault().Title ?? string.Empty))
                 .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(x => x.Translations.FirstOrDefault().Description ?? string.Empty));

    
        }
    }
}
