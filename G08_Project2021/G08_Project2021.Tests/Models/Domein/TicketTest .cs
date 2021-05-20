using G08_Project2021.Models.Domein;
using G08_Project2021.Tests.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace G08_Project2021.Tests.Models.Domein
{
   public  class TicketTest
    {
        private Ticket _ticket1;
        private DummyDbContext _context;
        public TicketTest()
        {
            _context = new DummyDbContext();
            _ticket1 = new Ticket("dit is de test van het ticket", Status.AANGEMAAKT, "test op naam", G08_Project2021.Models.Domein.Type.NORMAAL, _context.Arthur, _context.Thibault);
        }

        [Fact]
         public void maakJuisteTicketTitel()
        {
            string titel = _ticket1.Titel;
            Assert.Equal("test op naam", titel);
        }
        [Fact]
        public void maakJuisteTicketOmschrijving()
        {
            string omschrijving = _ticket1.Omschrijving;
            Assert.Equal("dit is de test van het ticket", omschrijving);
        }
       

    }
}
