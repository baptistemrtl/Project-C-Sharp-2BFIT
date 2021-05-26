﻿using Homepage.ucadmin;
using Homepage.ucuser;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Application;
using Persistance;
using System.Collections.ObjectModel;

namespace Homepage
{
    /// <summary>
    /// Logique d'interaction pour WindowMainAdmin.xaml
    /// </summary>
    public partial class WindowMainAdmin : Window
    {
        public Listes List => (App.Current as App).List;
        private Navigator Navigator = Navigator.GetInstance();

        private ExercicePageUCAdmin ucProg;
        public AdminProfilUC ucProfil;
        public WindowMainAdmin()
        {
            InitializeComponent();
            //DataContext = List;
        }

        private void listBoxProg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWindowContentControl.Content = InitUserControlProg();
            List.ProgrammeChoisi = (sender as ListBox).SelectedItem as Programme;
        }

        private void MWButtonProfile_Click(object sender, RoutedEventArgs e)
        {
            MainWindowContentControl.Content = InitUserControlProfil();
        }

        private ExercicePageUCAdmin InitUserControlProg()
        {
            if (ucProg == null)
            {
                ucProg = new ExercicePageUCAdmin();
            }
            return ucProg;
        }

        private AdminProfilUC InitUserControlProfil()
        {
            if (ucProfil == null)
            {
                ucProfil = new AdminProfilUC();
            }
            return ucProfil;
        }

        private void AjouterButton_Click(object sender, RoutedEventArgs e)
        {
            AjouterProgramme ap = new AjouterProgramme();
            ap.ShowDialog();
        }
    }
}
