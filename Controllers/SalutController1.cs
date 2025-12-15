using Microsoft.AspNetCore.Mvc;

namespace Petcu_Andreea_Cosmina_Lab1.Controllers
{
    public class SalutController1 : Controller
    {
        private string mesaj_welcome = "bine v-am gasit!";
        private string mesaj_salut = "salut!";

        public string Index()
        {
            return mesaj_welcome;
        }

        public string Salut()
        {
            return mesaj_salut;
        }

        public string AfiseazaDate(string text, int numar)
        {
            return $"Ai introdus textul: \"{text}\" și numărul: {numar}.";
        }
    }
}


