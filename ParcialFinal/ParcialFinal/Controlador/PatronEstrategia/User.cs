namespace ParcialFinal.Controlador
{
    public class User
    {
        private string card;
        private string name;
        private string lastName;
        private string password;
        private string dui;
        private string dateBirth;

        public User(string card, string name, string lastName, string password, string dui, string dateBirth)
        {
            this.card = card;
            this.name = name;
            this.lastName = lastName;
            this.password = password;
            this.dui = dui;
            this.dateBirth = dateBirth;
        }
        public User(){}
    }
}