using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperheroCreator.Models
{
    public class Superhero
    {
        [Key]
        public string Name;
        public string AlterEgo;
        public string PrimaryAbility;
        public string SecondaryAbility;
        public string Catchphrase;

    }
}
