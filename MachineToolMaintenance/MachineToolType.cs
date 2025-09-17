using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineToolMaintenance
{
    /// <summary>
    /// Тип станка
    /// </summary>
    public class MachineToolType : IValidatable
    {
        /// <summary>
        /// Страна производителя станка
        /// </summary>
        public Country Country { get; set; } = Country.Russia;

        /// <summary>
        /// Год выпуска станка
        /// </summary>
        public int YearOfManufacture { get; set; } = 1900;

        /// <summary>
        /// Марка станка
        /// </summary>
        public Brand Brand { get; set; } = Brand.Stankoinstrument;

        /// <summary>
        /// Срок гарантии в месяцах
        /// </summary>
        public int Warranty { get; set; } = 12;

        public bool IsValid
        {
            get
            {
                if (YearOfManufacture >= 1900 && YearOfManufacture <= DateTime.Now.Year &&
                    Warranty >= 0 && Warranty <= 120)
                {
                    return true;
                }
                return false;
            }
        }

        public MachineToolType()
        {

        }

        public MachineToolType(Country country, int yearOfManufacture, Brand brand)
        {
            Country = country;
            YearOfManufacture = yearOfManufacture;
            Brand = brand;
        }

        public override string ToString()
        {
            return $"[Производитель: {Country} ; " +
                $"Год выпуска: {YearOfManufacture} ; " +
                $"Бренд: {Brand}]";
        }
    }
}
