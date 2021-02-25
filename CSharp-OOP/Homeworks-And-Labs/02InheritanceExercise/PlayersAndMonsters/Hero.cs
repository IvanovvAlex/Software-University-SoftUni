using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Hero
    {
        private string username;
        private int level;
        public Hero(string username, int level)
        {
            Username = username;
            Level = level;
        }
        public string Username { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {Username} Level: {Level}"; 
        }
    }
}
