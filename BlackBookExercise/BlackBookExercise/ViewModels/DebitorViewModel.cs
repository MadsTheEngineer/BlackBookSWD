using System.Collections.ObjectModel;
using System.Linq;
using BlackBookExercise.DAL;
using BlackBookExercise.Models;
using Caliburn.Micro;

namespace BlackBookExercise.ViewModels
{
    public class DebitorViewModel : PropertyChangedBase
    {
        public ShellViewModel ParentViewModel { get; set; }
        public DebitorViewModel(ShellViewModel parentViewModel)
        {
            ParentViewModel = parentViewModel;
            var db = new EntityContext();
            Debitors = new ObservableCollection<Debitor>(db.Debitors.ToList());

        }
        public ObservableCollection<Debitor> Debitors { get; set; }
    }
    
}