using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BlackBookExercise.Models;
using BlackBookExercise.ViewModels;

namespace BlackBookExercise.Views
{
    /// <summary>
    /// Interaction logic for Debitors.xaml
    /// </summary>
    public partial class DebitorsView : UserControl
    {
        public DebitorsView()
        {
            InitializeComponent();
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var debitor = Selector.SelectedItem as Debitor;
            var dc = DataContext as DebitorViewModel;
            dc.ParentViewModel.ExchangeVm.Exchanges = new ObservableCollection<Exchange>(debitor.Transactions);
        }
    }
}
