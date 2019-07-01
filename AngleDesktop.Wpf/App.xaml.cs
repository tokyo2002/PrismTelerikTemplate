using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using CheaprModule;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using Telerik.Windows.Controls;

namespace AngleDesktop.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            //return ServiceLocator.Current.GetInstance<MainShell>();
            return null;
        }

        protected override void OnInitialized()
        {
            MainShell mainShell = Container.Resolve<MainShell>();
            mainShell.Show();

            MainWindow = mainShell.ParentOfType<Window>();

            InitializeModules();
            base.OnInitialized();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //throw new NotImplementedException();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<CheaprUiModule>();
        }
    }
}
