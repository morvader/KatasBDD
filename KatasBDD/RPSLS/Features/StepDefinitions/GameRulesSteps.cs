using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace RPSLS
{
    [Binding]
    public class GameRulesSteps
    {
        [Given(@"escojo la opcion '(.*)'")]
        public void GivenEscojoLaOpcion(string p0)
        {
            var jugadorHumano = new Jugador();

            Opcion opcionNumerica = (Opcion)Enum.Parse(typeof(Opcion),p0);

            jugadorHumano.Opcion = opcionNumerica;

            ScenarioContext.Current.Add("jugadorHumano", jugadorHumano);

        }
        
        [When(@"CPU escoge la opcion '(.*)'")]
        public void WhenCPUEscogeLaOpcion(string p0)
        {
            var jugadorCPU = new Jugador();

            Opcion opcionNumerica = (Opcion)Enum.Parse(typeof(Opcion), p0);

            jugadorCPU.Opcion = opcionNumerica;

            ScenarioContext.Current.Add("jugadorCPU", jugadorCPU);
        }
        
        [Then(@"veo el resultado '(.*)'")]
        public void ThenVeoElResultado(string p0)
        {
            var jugadorHumano = ScenarioContext.Current.Get<Jugador>("jugadorHumano");
            var jugadorCPU = ScenarioContext.Current.Get<Jugador>("jugadorCPU");

            var partida = new Partida(jugadorHumano,jugadorCPU);

            string ganador = partida.getGanador();

            Assert.That(ganador, Is.EqualTo(p0), "Ganador no esperado");

        }
    }
}
