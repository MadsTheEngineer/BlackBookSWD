using System.Collections.ObjectModel;
using BlackBookExercise.Models;
using Caliburn.Micro;

namespace BlackBookExercise.ViewModels
{
    public class ShellViewModel : PropertyChangedBase, IShell
    {
        public DebitorViewModel DebitorVm
        {
            get { return new DebitorViewModel(this); }
        }

        private ExchangeViewModel _exchangeVm = new ExchangeViewModel();
        public ExchangeViewModel ExchangeVm
        {
            get { return _exchangeVm; }
            set { _exchangeVm = value; }
        }
    }
}
