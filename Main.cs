using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Data;

namespace UI
{
    public static class Main
    {
        public delegate void ProjectChangedEventHandler();

        public static event ProjectChangedEventHandler ProjectChanged;

        private static Project currentProject = null;
        public static Project CurrentProject
        {
            get
            {
                return currentProject;
            }
            set
            {
                currentProject = value;
                //При изменении данных свойства
                ProjectChanged();
            }
        }
    }
}
