using G08_Project2021.Models;
using G08_Project2021.Models.Domein;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace G08_Project2021.Tests.Models.Domein
{
    public class ContractTest
    {
        private ContractType ct;
        private Contract c;
        private Gebruiker g;

        public ContractTest()
        {
            g = new Gebruiker("Synalco", "ThibaultV", "Vincke", Rol.KLANT, GebruikerStatus.ACTIEF, "Thibault", "thibault@gmail.com");
            ct = new ContractType("Gold", AanmaakTypeManier.APPLICATIE, 5, 2, 500);
            c = new Contract(ct, DateTime.Today, g);
        }

        [Fact]
        public void NewContract_JuisteEindDatum()
        {
            DateTime einddatum = DateTime.Today.AddYears(c.ContractType.MinLooptijdContract);
            Assert.Equal(einddatum, c.EindDatum);
        }

        [Fact]
        public void NewContract_GekoppeldAanJuisteGebruiker()
        {
            Gebruiker testgebruiker = g;
            Assert.Equal(testgebruiker, c.Gebruiker);
        }
        [Fact]
        public void NewContract_BepaalStatus_KrijgtStatusInBehandeling()
        {
            c.BepaalStatus();
            Assert.Equal(ContractStatus.IN_BEHANDELING, c.ContractStatus);
        }
    }
}
