using System;
using System.Collections.Generic;
using System.Text;

namespace App3.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _nombre;
        private string _paterno;
        private string _materno;

        public MainPageViewModel()
        {
            _nombre = "";
            _paterno = "";
            _materno = "";

        }

        public string Nombre
        {
            get => _nombre;
            set
            {
                _nombre = value;
                RaisePropertyChanged(nameof(Nombre));
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }

        public string Paterno
        {
            get => _paterno;
            set
            {
                _paterno = value;
                RaisePropertyChanged(nameof(Paterno));
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }

        public string Materno
        {
            get => _materno;
            set
            {
                _materno = value;
                RaisePropertyChanged(nameof(Materno));
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }

        public string NombreCompleto
        {

            get => string.Format("{0} {1} {2}", _nombre, _paterno, _materno);

        }

    }
}
