using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDti.Parte2
{
    class TelaViewModel : INotifyPropertyChanged
    {

        private static ObservableCollection<Resultado> resultados = Dados.CarregarDados;

        public ObservableCollection<Resultado> Resultados
        {
            get { return resultados; }

            set
            {
                resultados = value;
                RaisePropertyChangedEvent("Resultados");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            if (PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, e);
            }
        }
    }
}
