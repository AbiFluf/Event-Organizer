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
using System.Windows.Shapes;

namespace Event_Organizer
{
    /// <summary>
    /// Interaction logic for Sponsers.xaml
    /// </summary>
    public partial class Sponsers : Window
    {
        public Sponsers()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            show.Children.Clear();
            show.Children.Add(new AddSponsers());

        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            show.Children.Clear();
            show.Children.Add(new ViewSponsers());
        }
    }
}
