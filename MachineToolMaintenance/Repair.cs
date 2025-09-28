using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineToolMaintenance
{
    /// <summary>
    /// Ремонт
    /// </summary>
    public class Repair : IValidatable
    {
        /// <summary>
        /// Тип станка
        /// </summary>
        public MachineToolType MachineToolType { get; set; } = null;

        /// <summary>
        /// Тип ремонта
        /// </summary>
        public RepairType RepairType { get; set; } = null;
        
        /// <summary>
        /// Дата начала ремонта
        /// </summary>
        public DateTime StartDate { get; set; } = new DateTime(2025, 10, 26);

        /// <summary>
        /// Примечания к записи
        /// </summary>
        public string Notes { get; set; } = "Отсутствуют";

        /// <summary>
        /// Дата отсчёта ремонтов в системе
        /// </summary>
        public static readonly DateTime SystemStartDate = new DateTime(2025, 1, 1);
        
        public bool IsValid
        {
            get
            {
                if (MachineToolType != null && MachineToolType.IsValid && RepairType != null 
                    && RepairType.IsValid && StartDate >= SystemStartDate &&
                    Notes.Length > 5 && Notes.Length < 200)
                {
                    return true;
                }
                return false;
            }
        }

        public Repair()
        {

        }

        public Repair(MachineToolType machineToolType, RepairType repairType, DateTime startDate, string notes)
        {
            MachineToolType = machineToolType;
            RepairType = repairType;
            StartDate = startDate;
            Notes = notes;
        }

        public override string ToString()
        {
            return $"Идентификатор станка: {MachineToolType.Id} ; " +
                $"Название ремонта: {RepairType.Name} ; " +
                $"Дата начала ремонта: {StartDate} ; " +
                $"Примечания: {Notes}";
        }
    }
}
