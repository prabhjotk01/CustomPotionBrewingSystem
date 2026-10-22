using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPotionBrewingSystem.Models
{
    public class BrewedPotion
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Effect { get; set; } = "";

        public DateTime BrewedDate { get; set; } = DateTime.Now;
    }
}
