using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;

namespace WPF.SQLite.ViewModel
{
    public class StartViewModel : BaseViewModel
    {
        public ICommand CreateDbCommand { get; set; }

        public StartViewModel()
        {
            CreateDbCommand = new RelayCommand(() =>
            {
                MessageBox.Show("Hello !");
            });

        }
    }
}
