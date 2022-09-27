using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Sept23
{
    public class Player:IComparable
    {
        private int run;
        private string name;
        public Player(int run, string name)
        {
            this.run = run;
            this.name = name;
        }

        public int CompareTo(object obj)
        {
            Player p = (Player)obj;

            if(this.run > p.run)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return $"Runs {run}  name {name}";
        }
    }
    public class Team : IEnumerable
    {
        Player[] players;
        public Team()
        {
            players = new Player[3];
            players[0] = new Player(14000, "Rohit");
            players[1] = new Player(15000, "Virat");
            players[2] = new Player(10000, "Rahul");
        }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }

}














