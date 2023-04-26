using MVVM_Pet_2.Core;
using MVVM_Pet_2.Models;
using MVVM_Pet_2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Window = System.Windows.Window;

namespace MVVM_Pet_2.ViewModel
{
    internal class MainWindowViewModel
    {
        #region METHODS OF OPEN WINDOW
        public MainWindowViewModel() { }
        private void OpenWindowOfPets()
        {
            PetsWindow pWindow = new PetsWindow();
            DataWorker.SetCenterPositionAndOpen(pWindow);
        }
        private void OpenWindowOfClients()
        {
            ClientsWindow cWindow = new ClientsWindow();
            DataWorker.SetCenterPositionAndOpen(cWindow);
        }
        #endregion



        #region COMMANDS TO OPEN WINDOWS
        private RelayCommand openPetsWindow;
        public RelayCommand OpenPetsWindow
        {
            get
            {
                return openPetsWindow?? new RelayCommand(obj =>
                {
                    OpenWindowOfPets();
                });
            }
        }


        private RelayCommand openClientsWindow;
        public RelayCommand OpenClientsWindow
        {
            get
            {
                return openClientsWindow ?? new RelayCommand(obj =>
                {
                    OpenWindowOfClients();
                });
            }
        }
        #endregion
    }
}
