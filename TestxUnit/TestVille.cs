using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Ville.Bibliotheque;

namespace TestxUnit
{
    public class TestVille
    {
        //        Etapes du projet:
        //1. Si le texte de la recherche contient moins de 2 caractères, ***Une exception est levée de type NotFoundException***.
        [Fact]
        public void Search_LessThan2Char_ShouldTriggerException()
        {
            var rechercheVille = new RechercheVille();
            Assert.Throws<Exception>(() => rechercheVille.Rechercher("A"));
        }


        //2. Si le texte de recherche est égal ou supérieur à 2 caractères, il doit renvoyer tous les noms de ville commençant par le texte de recherche exact.
        //   Par exemple, pour le texte de recherche "Va", la fonction doit renvoyer Valence et Vancouver
        

        //3. La fonctionnalité de recherche doit être insensible à la casse


        //4. La fonctionnalité de recherche devrait également fonctionner lorsque le texte de recherche n'est qu'une partie d'un nom de ville
        //   Par exemple "ape" devrait renvoyer la ville "Budapest"


        //5. Si le texte de recherche est un « * » (astérisque), il doit renvoyer tous les noms de ville.
    } 
}

