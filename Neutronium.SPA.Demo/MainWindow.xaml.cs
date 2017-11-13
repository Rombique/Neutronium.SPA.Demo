﻿using System;
using Neutronium.SPA.Demo.ViewModel;
using Neutronium.SPA.Demo.ViewModel.Pages;
using Neutronium.WPF.ViewModel;

namespace Neutronium.SPA.Demo 
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = BuildApplicationViewModel();
        }

        private ApplicationViewModel BuildApplicationViewModel()
        {
            var window = new WindowViewModel(this);
            var routeSolver = RoutingConfiguration.Register();
            return ApplicationViewModel.CreateApplicationViewModel<MainViewModel>(window, routeSolver, new DependencyInjectionConfiguration());
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.HtmlView.Dispose();
        }
    }
}
