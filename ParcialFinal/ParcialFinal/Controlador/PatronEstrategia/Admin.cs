namespace ParcialFinal.Controlador
{
    public class Admin : User
    {
        public Admin(string card, string name, string lastName, string password, string dui, string dateBirth) : base(card, name, lastName, password, dui, dateBirth)
        {
        }
    }
}