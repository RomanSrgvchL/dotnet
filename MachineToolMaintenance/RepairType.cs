using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineToolMaintenance
{
    /// <summary>
    /// Тип ремонта
    /// </summary>
    public class RepairType : IValidatable
    {
        /// <summary>
        /// Название ремонта
        /// </summary>
        public string Name { get; set; } = "Замена резины на зимнюю";

        /// <summary>
        /// Продолжительность ремонта
        /// </summary>
        public TimeSpan Duration { get; set; } = TimeSpan.FromDays(1);

        /// <summary>
        /// Стоимость ремонта (руб)
        /// </summary>
        public int Cost { get; set; } = 2_000;

        /// <summary>
        /// Примечания к ремонту
        /// </summary>
        public string Notes { get; set; } = "Отсутствуют";

        public bool IsValid
        {
            get
            {
                if (Name.Length > 5 && Name.Length < 200 && Duration >= TimeSpan.FromMinutes(10) &&
                    Duration <= TimeSpan.FromDays(30) && Cost > 100 && Cost < 1_000_000 && 
                    Notes.Length > 5 && Notes.Length < 200)
                {
                    return true;
                }
                return false;
            }
        }

        public RepairType()
        {

        }

        public RepairType(string name, TimeSpan duration, int cost, string notes)
        {
            Name = name;
            Duration = duration;
            Cost = cost;
            Notes = notes;
        }

        public override string ToString()
        {
            return $"Название: {Name} ; " +
                $"Длительность: {Duration.Days} дн, {Duration.Hours} ч, {Duration.Minutes} м ; " +
                $"Стоимость: {Cost} руб ; " +
                $"Примечания: {Notes}";
        }
    }
}
