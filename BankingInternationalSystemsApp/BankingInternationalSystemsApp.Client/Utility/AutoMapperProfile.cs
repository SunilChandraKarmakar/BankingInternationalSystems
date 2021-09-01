using AutoMapper;
using BankingInternationalSystemsApp.Client.ViewModels.Account;
using BankingInternationalSystemsApp.Model.Models;

namespace BankingInternationalSystemsApp.Client.Utility
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateAccountViewModel, Account>();
        }
    }
}
