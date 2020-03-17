using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Player> Roster
        {
            get { return this.roster; }
            set { this.roster = value; }
        }
        public int Count => this.roster.Count;

        public Guild(string name, int capacity)
        {
            this.roster = new List<Player>();
            this.Name = name;
            this.Capacity = capacity;
        }

        public void AddPlayer(Player player)
        {
            if (this.Capacity >= this.roster.Count && !this.roster.Contains(player))
            {
                this.roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            bool isRemoved = false;

            if (this.roster.Where(p => p.Name == name).Any())
            {
                this.roster.Remove(this.roster.Where(p => p.Name == name).First());
                isRemoved = true;
            }

            return isRemoved;
        }

        public void PromotePlayer(string name)
        {
            if (this.roster.Where(p => p.Name == name).Any())
            {
                Player player = this.roster.Where(p => p.Name == name).First();
                if (player.Rank != "Member")
                {
                    player.Rank = "Member";
                }
            }
        }

        public void DemotePlayer(string name)
        {
            if (this.roster.Where(p => p.Name == name).Any())
            {
                Player player = this.roster.Where(p => p.Name == name).First();
                if (player.Rank != "Trial")
                {
                    player.Rank = "Trial";
                }
            }
        }

        public Player[] KickPlayersByClass(string className)
        {
            List<Player> kicked = new List<Player>();

            while (this.roster.Where(p => p.Class == className).Any())
            {
                Player player = this.roster.Where(p => p.Class == className).First();
                kicked.Add(player);
                this.roster.Remove(player);
            }

            return kicked.ToArray();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (Player player in this.roster)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
