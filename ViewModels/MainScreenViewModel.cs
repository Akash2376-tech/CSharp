using System.Windows;
using System.Windows.Input;
using Utility;

namespace ViewModels
{
    public class MainScreenViewModel:ViewModelBase
    {
        #region Private Variables
        private string _text;        
        private ICommand _print;
        #endregion
        #region Public Variables        
        public string Text { get { return _text; } set { _text = value; onPropertyChanged("Text"); } }
        public ICommand Print { get { return _print ?? (_print = new RelayCommand(para => showData())); } set { _print = value; } }
        #endregion
        public MainScreenViewModel()
        {

        }
        public void showData()
        {
            MessageBox.Show(Text);
        }

    }
}
