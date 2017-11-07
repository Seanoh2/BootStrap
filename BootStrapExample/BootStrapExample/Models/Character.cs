using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BootStrapExample.Models
{
    public class Character
    {
        private static int IdGen = 3;    
        public int Id { get; set; }
        public int Age { get; set; }
        public String Type { get; set; }
        public String Name { get; set; }
        public String Summary { get; set; }
        public String Mobility { get; set; }
        public String SpecialAttack { get; set; }
        public String Trivia { get; set; }

        public Character(int Age, String Type, String Name, String Summary, String Mobility, String SpecialAttack, String Trivia)
        {
            this.Id = IdGen;
            IdGen += 1;
            this.Age = Age;
            this.Type = Type;
            this.Name = Name;
            this.Summary = Summary;
            this.Mobility = Mobility;
            this.SpecialAttack = SpecialAttack;
            this.Trivia = Trivia;
        }



        public Character()
        {

        }
    }
}