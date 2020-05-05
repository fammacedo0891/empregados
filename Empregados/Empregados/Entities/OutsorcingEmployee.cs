using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados.Entities
{
    class OutsorcingEmployee : Employee
    {

        public double AdditionalCharge { get; set; }

        public OutsorcingEmployee()
        {

        }

        /*
         * criando uma metodo com os parametros do metodo da superclasse name, hours, valueperhour
         * usando o base para aproveitar os parametros criado
         */


        public OutsorcingEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base (name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;


        }
        

        // permite sobrepor o valor do metodo de pagto da superclasse employee

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
