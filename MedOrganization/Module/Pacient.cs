using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOrganization.Module
{
    public class Pacient
    {
        public Pacient() { }

        public Pacient(string surname, string name, string patronymic, int iIN)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            IIN = iIN;
        }

        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int IIN { get; set; }

        public MedOrganization MedOrganization { get; set; }

        public void PacientInfo()
        {
            Console.WriteLine($"Фамилия = {Surname}\n Имя = {Name}\n Отчество = {Patronymic}\n ИИН = {IIN}\n");
        }
    }
}
