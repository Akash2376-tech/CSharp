using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

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
        public ICommand Print { get; set; }
        #endregion
        public MainScreenViewModel()
        {

        }
        public void showData()
        {

        }

    }
}
