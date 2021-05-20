using G08_Project2021.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace G08_Project2021.Tests.Data
{
    public class DummyDbContext
    {
        public Gebruiker Arthur { get; }
        public Gebruiker Thibault { get; }

        public DummyDbContext()
        {
            Arthur = new Gebruiker("Degitise", "ArthurG", "Geeraert",Rol.KLANT,GebruikerStatus.ACTIEF,"Arthur","Arthur.geeraert@student.hogent.be") ;
            Thibault = new Gebruiker("Degitise", "Thibault", "Vyncke", Rol.TECHNIEKER, GebruikerStatus.ACTIEF, "thibault", "thibault@student.hogent.be");
        }
    }
}
