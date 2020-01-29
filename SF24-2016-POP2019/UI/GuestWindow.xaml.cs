﻿using SF24_2016_POP2019.Database;
using SF24_2016_POP2019.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace SF24_2016_POP2019.UI
{
    /// <summary>
    /// Interaction logic for GuestWindow.xaml
    /// </summary>
    public partial class GuestWindow : Window
    {
        ICollectionView view;
        public Termin IzabraniTermin { get; set; }
        public GuestWindow()
        {
            InitializeComponent();
            CreateView();
        }

        private void CreateView()
        {
            view = CollectionViewSource.GetDefaultView(Data.Instance.Termini);
            view.Filter = PrikazFilter;

            dgGuest.IsSynchronizedWithCurrentItem = true;
            dgGuest.DataContext = this;
            dgGuest.ItemsSource = view;
        }

        private bool PrikazFilter(object obj)
        {
            return !((Termin)obj).Obrisano;
        }

        //Sakrivanje nepotrebnih kolona
        private void DgGuest_AutoGeneratedColumns(object sender, EventArgs e)
        {
            dgGuest.Columns[0].Visibility = System.Windows.Visibility.Hidden;
            dgGuest.Columns[5].Visibility = System.Windows.Visibility.Hidden;
            dgGuest.Columns[7].Visibility = System.Windows.Visibility.Hidden;
        }

        private void ZatvoriProzor_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
        
    }
}
