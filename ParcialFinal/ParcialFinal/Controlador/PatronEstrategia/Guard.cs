using System.Collections.Generic;

namespace ParcialFinal.Controlador.PatronEstrategia
{
    public class Guard : User
    {
        public Guard(string card, string name, string lastName, string password, string dui, string dateBirth) : base(card, name, lastName, password, dui, dateBirth)
        {
        }

        public Guard()
        {
        }
        /*
        public void AddtoList(string carné, string temperature)
        {
            Dictionary<string, string> dictionary = Dictionary<string, string>();
            
            dictionary.Add(carné, temperature);
        }*/
    }
}