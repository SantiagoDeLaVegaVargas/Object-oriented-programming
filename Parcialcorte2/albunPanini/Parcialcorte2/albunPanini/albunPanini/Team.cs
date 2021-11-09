using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albunPanini
{
    class Team
    {
        private string name;
        private string description;
        private DateTime foundationDate;
        private Player[] players = new Player[11];


        public Team(string name, string description, DateTime foundationDate)
        {
            this.name = name;
            this.description = description;
            this.foundationDate = foundationDate;
            players = new Player(1,43,34,34,34,"jorgito","benavides", (2011, 6, 10));
        }

        private int getPositionVoid()
        {
            int i = 0;
            for (i = 0; i < players.Length; i++)
            {
                if (players[i] == null)
                    return i;
            }
            return i;
        }



    }
}
