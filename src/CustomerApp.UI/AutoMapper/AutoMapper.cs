using AutoMapper;
using CustomerApp.Core.Models;
using CustomerApp.UI.ViewModels;

namespace CustomerApp.UI.AutoMapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Customer, CustomerViewModel>().ReverseMap();
        }
    }
}
