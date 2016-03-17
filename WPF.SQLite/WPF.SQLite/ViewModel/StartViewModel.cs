using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using WPF.SQLite.EF.Entity;
using WPF.SQLite.EF.POCO;

namespace WPF.SQLite.ViewModel
{
    public class StartViewModel : BaseViewModel
    {
        public ICommand CreateDbCommand { get; set; }

        public StartViewModel()
        {
            CreateDbCommand = new RelayCommand(() =>
            {
                //MessageBox.Show("Hello !");
             
                var context = new FootballDbContext();
               
                foreach (var team in context.Set<Team>())
                {
                    var aa = team;
                }
                MessageBox.Show("DB creation done !");

            });

        }
    }
}
