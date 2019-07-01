using CheaprModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace CheaprModule
{
    public class CheaprUiModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(CheaprApprovalView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}