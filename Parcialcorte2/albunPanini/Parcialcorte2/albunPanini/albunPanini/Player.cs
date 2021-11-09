using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albunPanini
{ 
    enum Position
        {
        Forward,
        Outfield,
        OffensiveMidfield,
        DefensiveMidfield,
        Defense,
        Goalkeeper,
    }
    class Player : Person
    {

        private int shoot;
        private int defend;
        private int speed;
        private int power;
        private Position position;


        public Player(Position position, int shoot, int defend, int speed, int power, string firstName, string lastName, DateTime birthdayDate) : base(firstName, lastName, birthdayDate)
        {
            this.position = position;
            this.shoot = shoot;
            this.defend = defend;
            this.speed = speed;
            this.power = power;
        }

        public string longPass()
        {
            return "I am making a long pass";
        }
        public string shortPass()
        {
            return "I am making a short shot";
        } 
        public string shooting()
        {
            return "I am shooting";
        }
    }
}
