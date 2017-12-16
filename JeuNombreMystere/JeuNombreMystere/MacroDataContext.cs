using System.Windows.Input;

namespace JeuNombreMystere
{

    public class MacroDataContext
    {
        ICommand _macroManager;

        public MacroDataContext(MainWindow mainWindow)
        {
            _macroManager = new MacroManager(mainWindow);
        }

        public ICommand MacroManager
        {
            get { return _macroManager; }
        }
    }
}
