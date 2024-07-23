using AutoMapper;
using CleanArchWPF.Models;
using DB_Repo.Models;
using Dispatcher.Models;

namespace CleanArchWPF.Profiles
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            UiFlowProfiles();
            DbQueryFlowProfiles();
        }

        private void DbQueryFlowProfiles()
        {
            CreateMap<UiDispatcherDto, TaskModel>();
        }

        private void UiFlowProfiles()
        {
            CreateMap<RepoDispatcherDto, UiDispatcherDto>();
        }
    }
}
