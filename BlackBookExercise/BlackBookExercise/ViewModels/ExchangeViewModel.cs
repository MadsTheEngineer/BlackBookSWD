using System.Collections.Generic;
using System.Collections.ObjectModel;
using BlackBookExercise.DAL;
using BlackBookExercise.Models;
using Caliburn.Micro;

namespace BlackBookExercise.ViewModels
{
    public class ExchangeViewModel : PropertyChangedBase
    {
        private ObservableCollection<Exchange> _exchanges; 
        public ObservableCollection<Exchange> Exchanges
        {
            get { return _exchanges; }
            set
            {
                _exchanges = value;
                NotifyOfPropertyChange();
            }
        }

        public ExchangeViewModel()
        {
            var db = new EntityContext();
            Exchanges = new ObservableCollection<Exchange>();
        }
    }
}
