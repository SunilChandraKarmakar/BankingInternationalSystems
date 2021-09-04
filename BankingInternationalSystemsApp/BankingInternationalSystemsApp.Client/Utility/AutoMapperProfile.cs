using AutoMapper;
using BankingInternationalSystemsApp.Client.ViewModels.AdminDashboardViewModel;
using BankingInternationalSystemsApp.Client.ViewModels.LoginRegisterViewModel;
using BankingInternationalSystemsApp.Client.ViewModels.UserDashboardViewModel;
using BankingInternationalSystemsApp.Client.ViewModels.WithdrawAccountViewModel;
using BankingInternationalSystemsApp.Model.Models;

namespace BankingInternationalSystemsApp.Client.Utility
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateAccountViewModel, Account>();
            CreateMap<LoginAccountViewModel, Account>();
            CreateMap<Account, LoginAccountViewModel>();
            CreateMap<CreateWithdrawAccountViewModel, WithdrawAccount>();
            CreateMap<CreateLodgeAccountViewModel, LodgeAccount>();
            CreateMap<Account, AccountViewModel>();
        }
    }
}
