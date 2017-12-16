using System;
using System.Windows;
using System.Windows.Input;

namespace JeuNombreMystere
{
    public class MacroManager : ICommand
    {

        private MainWindow mainWindow;
        public event EventHandler CanExecuteChanged;

        public MacroManager(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public void Execute(object parameter)
        {
            if (parameter != null)
            {
                if (parameter.ToString() == "Ctrl+N")
                    this.mainWindow.nouveauJoueur_Click(null, null);
                if (parameter.ToString() == "Ctrl+D")
                    this.mainWindow.Demarrer_Click(null, null);
                if (parameter.ToString() == "Ctrl+S")
                    this.mainWindow.tableauScore_Click(null, null);
            }
        }

        public bool CanExecute(object parameter) => true;
    }
}
