﻿using AutoMapper;
using HR_Management.Extensions;
using HR_Management.Infrastructure;
using HR_Management.Resources.Person;
using System;

namespace HR_Management.Mapping.Person
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<CreatePersonResource, Domain.Models.Person>()
                .ForMember(x => x.FirstName, opt => opt.MapFrom(src => src.FirstName.RemoveSpaceCharacter()))
                .ForMember(x => x.LastName, opt => opt.MapFrom(src => src.LastName.RemoveSpaceCharacter()))
                .ForMember(x => x.Email, opt => opt.MapFrom(src => src.Email.RemoveSpaceCharacter()))
                .ForMember(x => x.Description, opt => opt.MapFrom(src => src.Description.RemoveSpaceCharacter()))
                .ForMember(x => x.Phone, opt => opt.MapFrom(src => src.Phone.RemoveSpaceCharacter()))
                .ForMember(x => x.CreatedAt, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(x => x.StaffId, opt => opt.MapFrom(src => ComputeStaffId()))
                .ForMember(x => x.Avatar, opt => opt.MapFrom(src => "default.jpg")) // Use default image for new person.
                .ForMember(x => x.OrderIndex, opt => opt.MapFrom(src => DefaultOrderIndexPerson())); // Use Default value while create a person record

            CreateMap<PersonResource, Domain.Models.Person>()
                .ForMember(x => x.FirstName, opt => opt.MapFrom(src => src.FirstName.RemoveSpaceCharacter()))
                .ForMember(x => x.LastName, opt => opt.MapFrom(src => src.LastName.RemoveSpaceCharacter()))
                .ForMember(x => x.Email, opt => opt.MapFrom(src => src.Email.RemoveSpaceCharacter()))
                .ForMember(x => x.Description, opt => opt.MapFrom(src => src.Description.RemoveSpaceCharacter()))
                .ForMember(x => x.Phone, opt => opt.MapFrom(src => src.Phone.RemoveSpaceCharacter()));

            CreateMap<UpdatePersonResource, Domain.Models.Person>()
                .ForMember(x => x.FirstName, opt => opt.MapFrom(src => src.FirstName.RemoveSpaceCharacter()))
                .ForMember(x => x.LastName, opt => opt.MapFrom(src => src.LastName.RemoveSpaceCharacter()))
                .ForMember(x => x.Email, opt => opt.MapFrom(src => src.Email.RemoveSpaceCharacter()))
                .ForMember(x => x.Description, opt => opt.MapFrom(src => src.Description.RemoveSpaceCharacter()))
                .ForMember(x => x.Phone, opt => opt.MapFrom(src => src.Phone.RemoveSpaceCharacter()));
        }

        string DefaultOrderIndexPerson()
            => string.Format($"{(int)eOrder.WorkHistory},{(int)eOrder.Skill},{(int)eOrder.Education},{(int)eOrder.Certificate},{(int)eOrder.Project}");

        /// <summary>
        /// You should rewrite this method, rely on Id of person in DB
        /// </summary>
        /// <returns></returns>
        private string ComputeStaffId()
        {
            DateTime tempDate = DateTime.Now;
            string tempMonth = tempDate.Month < 10 ? $"0{tempDate.Month}" : $"{tempDate.Month}";
            string tempDay = tempDate.Day < 10 ? $"0{tempDate.Day}" : $"{tempDate.Day}";

            Random tempRnd = new Random();
            int lastDigit = tempRnd.Next(1000, 9933) + tempDate.Second;

            return string.Format($"{tempDate.Year}{tempMonth}{tempDay}{lastDigit}");
        }
    }
}
