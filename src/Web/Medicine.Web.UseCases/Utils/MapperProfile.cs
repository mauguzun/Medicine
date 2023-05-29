﻿using AutoMapper;
using Medicine.Entities.Models;
using Medicine.Web.UseCases.Dto;
using Medicine.Web.UseCases.Responses;

namespace Medicine.Web.UseCases.Utils
{
    public class MapperProfile : Profile
    {

        public MapperProfile()
        {

            CreateMap<DosingFrequencyReminder, DosageRecommendationResponse>().ReverseMap();
            CreateMap<Reminder, ReminderResponse>().ReverseMap();
            CreateMap<DosingFrequency, DosingFrequencyResponse>().ReverseMap();
            CreateMap<DosageLogResponse, DosageLog>().ReverseMap();
            CreateMap<CourseResponse, Course>().ReverseMap();
            CreateMap<TherapyResponse, Therapy>().ReverseMap();
            CreateMap<CourseSettingsResponse, CourseSettings>().ReverseMap();
            CreateMap<CourseGroupResponse, CourseGroup>().ReverseMap();
            CreateMap<DrugResponse, Drug>().ReverseMap();
            CreateMap<ActiveElementResponse, ActiveElement>().ReverseMap();
            //.ForSourceMember(x => x.DosageRecommendations, opt => opt.DoNotValidate()



            //CreateMap<Therapy, TherapyDto>().ForMember(
            //        dest => dest.Title,
            //        opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Title))
            //     .ForMember(
            //        dest => dest.Description,
            //        opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Description))
            //     .ForMember(
            //        dest => dest.Language,
            //        opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Language));


            //CreateMap<Course, CourseDto>().ForMember(
            //        dest => dest.Title,
            //        opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Title))
            //     .ForMember(
            //        dest => dest.Description,
            //        opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Description))
            //     .ForMember(
            //        dest => dest.Language,
            //        opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Language));

            //CreateMap<DosingFrequencyReminder, DosageRecommendationDto>().ForMember(
            //        dest => dest.Title,
            //        opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Title))
            //     .ForMember(
            //        dest => dest.Description,
            //        opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Description))
            //     .ForMember(
            //        dest => dest.Language,
            //        opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Language));

            //CreateMap<DosingFrequency, DosingFrequencyDto>().ForMember(
            //        dest => dest.Title,
            //        opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Title))
            //     .ForMember(
            //        dest => dest.Description,
            //        opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Description))
            //     .ForMember(
            //        dest => dest.Language,
            //        opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Language));

            //CreateMap<Drug, DrugDto>().ForMember(
            //        dest => dest.Title,
            //        opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Title))
            //     .ForMember(
            //        dest => dest.Description,
            //        opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Description))
            //     .ForMember(
            //        dest => dest.Language,
            //        opt => opt.MapFrom(x => x.Translations == null ? default : x.Translations.First().Language));


        }
    }
}
