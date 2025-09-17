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
        public string Name { get; set; } = "";

        /// <summary>
        /// Продолжительность ремонта
        /// </summary>
        public TimeSpan Duration { get; set; } = TimeSpan.FromSeconds(1);

        /// <summary>
        /// Стоимость ремонта (руб)
        /// </summary>
        public int Cost { get; set; } = 0;

        /// <summary>
        /// Примечания к станку
        /// </summary>
        public string Notes { get; set; } = "";

        public bool IsValid
        {
            get
            {
                if (Name.Length > 5 && Name.Length < 200 && Duration >= TimeSpan.FromMinutes(10) &&
                    Duration <= TimeSpan.FromDays(30) && Cost > 100 && Cost < 1_000_000 && Notes.Length > 0)
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
            return $"[Ремонт: {Name} ; " +
                $"Длительность: {Duration.Days} дней, {Duration.Hours} часов, {Duration.Minutes} минут ; " +
                $"Стоимость: {Cost} рублей ; " +
                $"Примечание: {Notes}]";
        }
    }
}
