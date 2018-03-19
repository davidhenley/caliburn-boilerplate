using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnBoilerplate.ViewModels
{
    class ShellViewModel : Screen
    {
        private string helloWorld;

        public string HelloWorld
        {
            get { return helloWorld; }
            set
            {
                helloWorld = value;
                NotifyOfPropertyChange(() => HelloWorld);
            }
        }

        public ShellViewModel()
        {
            HelloWorld = "Hello World!";
        }
    }
}
