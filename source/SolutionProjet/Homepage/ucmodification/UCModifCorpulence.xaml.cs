﻿using Application;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homepage.ucmodification
{
    /// <summary>
    /// Logique d'interaction pour UCModifCorpulence.xaml
    /// </summary>
    public partial class UCModifCorpulence : UserControl
    {
        public Listes List => (App.Current as App).List;
        public UCModifCorpulence()
        {
            InitializeComponent();
            DataContext = List;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(newTaille.Text))
                {

                }
                else
                    List.UtilisateurCourant.Taille = Int16.Parse(newTaille.Text);
                if (string.IsNullOrWhiteSpace(newPoids.Text))
                {

                }
                else
                    List.UtilisateurCourant.Poids = float.Parse(newPoids.Text);
                Window.GetWindow(this).Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Mauvaises valeurs rentrées, veuillez réessayer", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}