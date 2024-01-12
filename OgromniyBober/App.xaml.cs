﻿using OgromniyBober.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace OgromniyBober
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static OgromniyBoberDatabaseEntities db = new OgromniyBoberDatabaseEntities();
        public static MainWindow mainWindow;

        public static int UserID;
    }
}
