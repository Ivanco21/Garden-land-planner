using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfClientForm.Model;

namespace WpfClientForm.VM
{
    public class MainVM : ViewModelBase
    {
        public MainVM()
        {
            Cultures = Enum.GetValues(typeof(Culture)).Cast<Culture>().ToArray();

            CreateCommand = new RelayCommand(p => Console.WriteLine($"Param = {p}"));
        }


        public ICommand CreateCommand { get; }
        public Culture[] Cultures { get; }
    }
}
