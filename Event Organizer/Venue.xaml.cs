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
    /// Interaction logic for Venue.xaml
    /// </summary>
    public partial class Venue : Window
    {
        public Venue()
        {
            InitializeComponent();
        }

        private void AddVenue_Click(object sender, RoutedEventArgs e)
        {
            showV.Children.Clear();
            showV.Children.Add(new AddVenue());

        }

        private void ViewVenue_Click(object sender, RoutedEventArgs e)
        {
            showV.Children.Clear();
            showV.Children.Add(new ViewVenue());

        }
    }
}
