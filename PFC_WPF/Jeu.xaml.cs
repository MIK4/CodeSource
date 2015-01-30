using System;
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

namespace PFC_WPF
{
    /// <summary>
    /// Logique d'interaction pour Jeu.xaml
    /// </summary>
    /// 


    class Game
    {



    }



    class User
    {
       /* public string Name;
        public int Niv;
        public int Exp;
        public int Serie;
        public int Ratio;*/



        public int PointsTotal = 10;
        public int PointsGagner= 10;
        public string bispoint;
        public int Choix;



    }


   public class IntelligenceArtificiel
    {

        public bool State = false;
        public int choix;


       public int step_1()
        {
            Random rand = new Random();
            return rand.Next(1,4);
        }








    }





    public partial class Jeu : Window
    {
        public Jeu()
        {
            User NouveauUtilisateur = new User();

            InitializeComponent();

        }

        private void image_MouseDown(object sender, MouseButtonEventArgs e) // L'utilisateur clique sur  CISEAU 
        {
            User NouveauUtilisateur = new User();
            NouveauUtilisateur.Choix = 1;
            IntelligenceArtificiel It = new IntelligenceArtificiel();
            It.choix = It.step_1();
            image1_Copy1.Source = new BitmapImage(new Uri("Asset/Asset" + It.choix + ".png", UriKind.Relative));

            if (It.choix == 1) // Ordinateur choisis Ciseau
            {
                MessageBox.Show("VOUS ÊTES A EGALITE", "Résultat");
                NouveauUtilisateur.PointsTotal = NouveauUtilisateur.PointsTotal + NouveauUtilisateur.PointsGagner;
                NouveauUtilisateur.bispoint = NouveauUtilisateur.PointsTotal.ToString();
                NbrePoint.Text = NouveauUtilisateur.bispoint;
            }

            if (It.choix == 2) // Ordinateur choisis Feuille
            {

                MessageBox.Show("VOUS AVEZ GAGNER", "Résultat");
            }

            if (It.choix == 3) // Oatrdinateur choisis Feuille
            {

                MessageBox.Show("VOUS AVEZ PERDU", "Résultat");
            }
        }
        

        private void image1_MouseDown(object sender, MouseButtonEventArgs e) // L'utilisateur clique sur  FEUILLE 
        {
            User NouveauUtilisateur = new User();
            NouveauUtilisateur.Choix = 3;
            IntelligenceArtificiel It = new IntelligenceArtificiel();
            It.choix = It.step_1();
            image1_Copy1.Source = new BitmapImage(new Uri("Asset/Asset" + It.choix + ".png", UriKind.Relative));


            if (It.choix == 1) { MessageBox.Show("VOUS AVEZ PERDU", "Résultat"); }  // Ordinateur choisis Ciseau
            if (It.choix == 2) { MessageBox.Show("VOUS ÊTES A EGALITE", "Résultat"); }     // Ordinateur choisis Feuille 
            if (It.choix == 3)
            {
                NouveauUtilisateur.PointsTotal = NouveauUtilisateur.PointsTotal + NouveauUtilisateur.PointsGagner;
               NouveauUtilisateur.bispoint = NouveauUtilisateur.PointsTotal.ToString();
               NbrePoint.Text = NouveauUtilisateur.bispoint;
               MessageBox.Show("VOUS AVEZ GAGNER", "Résultat"); 

            }     // Ordinateur choisis Pierre 

        }



        private void image2_MouseDown(object sender, MouseButtonEventArgs e) // L'utilisateur clique sur  PIERRE 
        {
            User NouveauUtilisateur = new User();
            NouveauUtilisateur.Choix = 2;
            IntelligenceArtificiel It = new IntelligenceArtificiel();
            It.choix = It.step_1();
            image1_Copy1.Source = new BitmapImage(new Uri("Asset/Asset" + It.choix + ".png", UriKind.Relative));

            if (It.choix == 1)
            {
                MessageBox.Show("VOUS AVEZ GAGNER", "Résultat");
                NouveauUtilisateur.PointsTotal = NouveauUtilisateur.PointsTotal + NouveauUtilisateur.PointsGagner;
                NouveauUtilisateur.bispoint = NouveauUtilisateur.PointsTotal.ToString();
                NbrePoint.Text = NouveauUtilisateur.bispoint;
            }  // Ordinateur choisis Ciseau
            if (It.choix == 2) { MessageBox.Show("VOUS AVEZ PERDU", "Résultat"); }     // Ordinateur choisis Feuille 
            if (It.choix == 3) { MessageBox.Show("VOUS ÊTES A EGALITE", "Résultat"); }     // Ordinateur choisis Pierre 
           
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            Jeu nvgame = new Jeu();
            nvgame.Show();
            this.Close();
        }

    
    }
}
