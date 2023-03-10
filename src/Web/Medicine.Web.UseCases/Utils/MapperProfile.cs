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
            CreateMap<Therapy, TherapyDto>()
                .ForMember(dest => dest.Title,
                    opt => opt.MapFrom(x => x.TranslatedTherapies.FirstOrDefault().Title ?? string.Empty));


            CreateMap<Course, CourseDto>()
                .ForMember(dest => dest.Title,
                    opt => opt.MapFrom(x => x.TranslatedCourses.FirstOrDefault().Title ?? string.Empty));


            CreateMap<Reminder, ReminderDto>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(x => x.Title));
            
            CreateMap<DosageRecommendation, DosageRecommendationDto>()
                .ForMember(dest => dest.Title, 
                opt => opt.MapFrom(x => x.TranslatedDosageRecommendations.FirstOrDefault().Title));

            CreateMap<DosingFrequency, DosingFrequencyDto>()
                .ForMember(dest => dest.Title,
                    opt => opt.MapFrom(x => x.TranslatedDosingFrequency.FirstOrDefault().Title));

            CreateMap<Drug, DrugDto>()
                .ForMember(dest => dest.Title,
                    opt => opt.MapFrom(x => x.TranslatedDrugs.FirstOrDefault().Title));  
            
            CreateMap<Drug, DrugDto>()
                .ForMember(dest => dest.Title,
                    opt => opt.MapFrom(x => x.TranslatedDrugs.FirstOrDefault().Title));
        }
    }
}
