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
    /// <summary>
    /// The start view model.
    /// </summary>
    public class StartViewModel : BaseViewModel
    {
        /// <summary>
        /// Gets or sets the create db command.
        /// </summary>
        public ICommand CreateDbCommand { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartViewModel"/> class.
        /// </summary>
        public StartViewModel()
        {
            CreateDbCommand = new RelayCommand(() =>
            {

                /* Following are few steps which will make easy to work with Sqlite...
                1. Install Sqlite provider for design time in visual studio
                   http://system.data.sqlite.org/downloads/1.0.99.0/sqlite-netFx46-setup-bundle-x86-2015-1.0.99.0.exe
                2. Install-Package System.Data.SQLite (This will install core,linq,EF6)...
                3. Install-Package SQLiteNetExtensions if required for mapping
                4. Install-Package SQLite.CodeFirst for code first approch if required
                */

                MessageBox.Show("Hello !");

                var footballDbContext = new FootballDbContext();
                foreach (var team in footballDbContext.Set<Team>())
                {
                    var aa = team;
                }

                var myDbContext = new MyDbContext();
                foreach (var team in myDbContext.Set<AspNetUser>())
                {
                    var aa = team;
                }

                MessageBox.Show("DB creation done !");

            });

        }
    }
}
