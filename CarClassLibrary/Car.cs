using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        // Серия + Номер ПТС (уникальный идентификатор автомобиля)
        public string PtsNumber { get; set; }

        // Марка
        public CarBrandType CarBrandType { get; set; }

        // Тип кузова
        public CarBodyType CarBodyType { get; set; }

        // Год выпуска
        public int Year { get; set; }

        // Цвет
        public CarColorType CarColorType { get; set; } 
    }
}
