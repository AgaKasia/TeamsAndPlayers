using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Team> Teams;

        public MainWindow()
        {
            InitializeComponent();
            Teams = new ObservableCollection<Team>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Create two teams
            Team t1 = new Team() { Name = "Sligo Rovers", ImageName = "/images/sligorovers.jpg" };
            Team t2 = new Team() { Name = "Finn Harps" , ImageName = "/images/finnharps.png"};

            //Create two players
            Player p1 = new Player() { Name = "Tom" };
            Player p2 = new Player() { Name = "Mary" };

            //Add Players to teams
            t1.Players.Add(p1);
            t2.Players.Add(p2);

            //Add teams to collection
            Teams.Add(t1);
            Teams.Add(t2);

            //Display
            lbxTeams.ItemsSource = Teams;
        }

        private void LbxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //determine what team was selected
            Team selectedTeam = lbxTeams.SelectedItem as Team;

            if (selectedTeam != null)
            {
                //display players from that team
                lbxPlayers.ItemsSource = selectedTeam.Players;

                //update image
                imgTeam.Source = new BitmapImage(new Uri(selectedTeam.ImageName, UriKind.Relative));

             }

        }
    }
}
