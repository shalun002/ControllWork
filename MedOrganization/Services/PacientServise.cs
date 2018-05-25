using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOrganization.Module.Services
{
    public enum Surname { Surname1, Surname2, Surname3, Surname4, Surname5, Surname6, Surname7, Surname8 }
    public enum Name { name1, name2, name3, name4, name5, name6, name7, name8 }
    public enum Patronymic { Patronymic1, Patronymic2, Patronymic3, Patronymic4, Patronymic5, Patronymic6, Patronymic7, Patronymic8 }
   
    public class PacientServise
    {
        public List<Pacient> PacientList = new List<Pacient>();
        public PacientServise()
        {
            PacientGenerator();
        }
        public Pacient this[int iin]
        {
            get
            {
                foreach (Pacient item in PacientList)
                {
                    if (item.IIN == iin)
                        return item;
                }
                return null;
            }
        }

        private Random rnd = new Random();
        private void PacientGenerator(int size = 0)
        {
            if (size == 0)
                size = rnd.Next(1,20);

            for (int i = 0; i < size; i++)
            {
                string Familiya = ((Surname)rnd.Next(1, 8)).ToString();
                string Imya = ((Name)rnd.Next(1, 8)).ToString();
                string Otchestvo = ((Patronymic)rnd.Next(1, 8)).ToString();
                int IIN = rnd.Next(100000, 999999);
                Pacient newPac = new Pacient(Familiya, Imya, Otchestvo, IIN);
                PacientList.Add(newPac);
            }
        }



        public void PokazVsehPacientov(List<Pacient> pac)
        {
            foreach (Pacient item in pac)
            {
                item.PacientInfo();
                Console.WriteLine("================================================");
            }
        }
        public Pacient SearchIIN(int iin)
        {
    
            bool yes = false;
            foreach (Pacient item in PacientList)
            {
                if (item.IIN == iin)
                {
                    item.PacientInfo();
                    yes = true;
                    return item;
                }
            }

            if (!yes)
                Console.WriteLine("Такого пациента нет");
            return null;
        }

    }
}
