﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace testGithub
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    class Osoba
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Osoba(int age, string name)
        {
            Age = age;
        }

        
    }

    class Muz : Osoba
    {
        public bool Gender { get; set; }
        public Muz(int age,string name,bool gender) :base(age,name)
        {
            Gender = gender;
        }
    }
}
