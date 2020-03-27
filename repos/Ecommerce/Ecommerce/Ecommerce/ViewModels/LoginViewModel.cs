using Ecommerce.Servicios;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Ecommerce.ViewModels
{
  public class LoginViewModel
    {
        #region Atributos
        private NavigationService navigationService;
        private DialogService dialogService;

        #endregion

        #region Propiedades
        public string User { get; set; }

        public string Password { get; set; }

        public bool IsRemembered { get; set; }
        #endregion

        #region Constructor
        public LoginViewModel()
        {
            navigationService = new NavigationService();
            dialogService = new DialogService();
            IsRemembered = true;
        }
        #endregion

        #region Comandos
        public ICommand LoginCommand { get {return new RelayCommand(Login); } }

        private async void Login()
        {
            if(string.IsNullOrEmpty(User))
            {
                await dialogService.ShowMessage("Error", "Debes ingresar un usuario");
                return;
            }
            if (string.IsNullOrEmpty(Password))
            {
                await dialogService.ShowMessage("Error", "Debes ingresar un Password");
                return;
            }
            navigationService.SetMailPage();
        }
        #endregion
    }
}
