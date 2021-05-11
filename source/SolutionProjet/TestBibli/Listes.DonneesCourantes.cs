﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    // pas à sérialiser
    public partial class Listes
    {
        /// <summary>
        /// Utilisateur Connecté
        /// </summary>
        private Utilisateur utilisateurCourant;

        public Utilisateur UtilisateurCourant { get; set; }

        /// <summary>
        /// Programme choisi par un utilisateur avant de le lancer
        /// </summary>
        public Programme ProgrammeChoisi { get; set; }

        /// <summary>
        /// Méthode qui permet le lancement d'un programme dans la classe utilisateur à partir d'un programme et d'une difficulté
        /// et qui met à jour les valeurs du dernier programme effectué et de la difficulté de celui ci
        /// </summary>
        /// <param name="prog"></param>
        /// <param name="diff"></param>
        public void LancementProgramme(Programme prog, String diff)
        {
            Enum.TryParse(diff, out Difficulte value); // Nouvelle varibale value, qui devient une difficulté au lieu d'une string
            ProgrammeChoisi = prog; // programmeChoisi prend la valeur de prog
            LinkedList<Exercice> list = prog.LesExercices; // Instanciation d'une nouvelle LinkedList d'exercice, qui prend la valeur de celle de prog
            foreach (Exercice ex in list) // pour chaque exercice dans list
            {
                if (diff.ToString().Equals("DEBUTANT")) //Si la difficulté est "DEBUTANT"
                {
                    ex.ValeurCourante = ex.ValeurDeb; // la valeur courante de chaque exercice sera ValeurDeb
                }
                if (diff.ToString().Equals("INTERMEDIAIRE")) //Si la difficulté est "INTERMEDIAIRE"
                {
                    ex.ValeurCourante = ex.ValeurInter; // la valeur courante de chaque exercice sera ValeurInter
                }
                if (diff.ToString().Equals("EXPERT")) //Si la difficulté est "EXPERT"
                {
                    ex.ValeurCourante = ex.ValeurExpert; // la valeur courante de chaque exercice sera ValeurExpert
                }
            }

            UtilisateurCourant.LancerProgramme(ProgrammeChoisi, value); // Appelle de la méthode LancerProgramme dans la classe utilisateur
        }
    }
}
