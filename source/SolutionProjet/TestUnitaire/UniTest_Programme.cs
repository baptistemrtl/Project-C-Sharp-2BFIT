﻿using Application;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace TestUnitaire
{
    public class UniTest_Programme
    {
        Listes l = new Listes();
        [Fact]

        public void TestValiditeProgrammeSansNom()
        {   
            Programme p1 = new Programme("", "chemin image A", "Programme PUSH");
            Assert.False(Management.CreationObjectValidator.ValidationAjoutProgramme(p1));
        }

        [Fact]
        public void TestAjoutExerciceSansNom()
        {
            
            Programme p1 = new Programme("push", "Programme PUSH", "chemin image A");
            Assert.Throws<ArgumentException>(() => Management.Manager.AjouterUnExercice(p1,new Exercice("", "chemin image ", new Valeur(1, 2, 3), new Valeur(4, 5, 6), new Valeur(7, 8, 9)),l));
            
        }

        [Fact]
        public void TestAjoutExerciceValeurVide()
        {
            Programme p1 = new Programme("push", "Programme PUSH", "chemin image A");
            Assert.Throws<ArgumentException>(() => Management.Manager.AjouterUnExercice(p1, new Exercice("", "chemin image ", new Valeur(1, 2, 3), new Valeur(0, 0, 0), new Valeur(0, 0, 0)), l));
        }
    }
}
