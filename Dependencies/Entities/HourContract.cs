using System;
using System.Collections.Generic;
using System.Text;

namespace Dependencies.Entities
{
    internal class HourContract
    {
        //criação das propriedades
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //croação dos construtores
        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        //criar o metodo para calcular o valor total das horas tabalhadas
        // e vai retornar um valor double
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
