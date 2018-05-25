using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOrganization.Module
{
    public class MedOrganization
    {
        public List<Pacient> pacientList;

        public MedOrganization():this("","","")
        {

        }
        public MedOrganization(string nameOrgan, string address, string telNumber)
        {
            NameOrgan = nameOrgan;
            Address = address;
            TelNumber = telNumber;

            pacientList = new List<Pacient>();
        }

        public int Id { get; set; }
        public string NameOrgan { get; set; }
        public string Address { get; set; }
        public string TelNumber { get; set; }

        public void MedOrganizationInfo()
        {
            Console.WriteLine($"Название организации ={NameOrgan} \n Aдресс ={Address} \n  Номер телефона ={TelNumber} \n ID ={Id} \n");
        }
    }
}