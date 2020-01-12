using System;
using System.Linq;
using System.Windows.Input;
using WpfClientForm.Model;

namespace WpfClientForm.VM
{
    public class MainVM : ViewModelBase
    {
        private CultureVM current;
        public MainVM()
        {
            Cultures = Enum.GetValues(typeof(Culture)).Cast<Culture>().ToArray();

            CreateCommand = new RelayCommand(ChangeSelectedType);
        }

        private void ChangeSelectedType(object param)
        {
            if(param is Culture c)
            {
                switch (c)
                {
                    case Culture.Fruits: 
                        CurrentCulture = new FruitsVM();
                        return;
                    case Culture.Gargen:
                        CurrentCulture = new GargenVM();
                        return;
                    case Culture.Grape:
                        CurrentCulture = new GrapeVM();
                        return;
                    case Culture.Vegetables:
                        CurrentCulture = new VegetablesVM();
                        return;
                    default:
                        return;
                }
            }
        }

        public CultureVM CurrentCulture
        {
            get { return current; }
            set { SetProperty(ref current, value); }
        }

        public ICommand CreateCommand { get; }
        public Culture[] Cultures { get; }
    }
}
