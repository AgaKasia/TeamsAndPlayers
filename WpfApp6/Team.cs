using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class Team
    {
        public string Name { get; set; }

        public string ImageName { get; set; }



        public ObservableCollection<Player> Players { get; set; }

        public Team()
        {
            Players = new ObservableCollection<Player>();
        }

        public Team(string name):this()
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
