using Application;
using Management;
using System;
using System.Diagnostics;
using Xunit;
using System.Collections.Generic;

namespace TestUnitaire
{ 
    public class UniTest_Utilisateur
    {
        public Dictionary<string, Utilisateur> listComptes = new Dictionary<string, Utilisateur>();
        Listes listeTest = new Listes();
        

        [Fact]
        public void TestUtilisateurSansIdentité()
        {
            //Renvoie False lorsqu'on test la validité d'un utilisateur sans nom prenom
            Utilisateur u1 = new Utilisateur("", "", new DateTime(2003, 1, 30), 190, 190, "bamartel", "mdpDeBamartel");
            Assert.False(CreationObjectValidator.ValidationAjoutUser(u1));
        }

        [Fact]
        public void TestMensurationTropElevee()
        {
            //Renvoie false lorsque le poids et la taille rentrés sont trop elevés ( 300 kg pour le poids et 260 cm pour la taille)
            Utilisateur u1 = new Utilisateur("Baptiste", "Martel", new DateTime(2003, 1, 30), 300, 300, "bamartel", "mdpDeBamartel");
            Assert.False(CreationObjectValidator.ValidationAjoutUser(u1));
        }

        
    }








}
    


