using Ecommerce.Servicios;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Ecommerce.ViewModels
{
    public class MenuItemViewModel
    {
        #region Atributos
        private NavigationService navigationService;
        #endregion
        #region Propiedades
        public string Icon { get; set; }

        public string Title { get; set; }

        public string PageName { get; set; }
        #endregion
        #region constructor
        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        }
        #endregion
        #region Comandos
        public ICommand NavigateCommand { get { return new RelayCommand(Navigate); } }

        private async void Navigate()
        {
           await navigationService.Navigate(PageName);
        }
        #endregion
    }
}
