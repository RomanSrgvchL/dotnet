using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineToolMaintenance.Serialization
{
    [Serializable]
    public class RepairSerializable
    {
        /// <summary>
        /// Тип станка
        /// </summary>
        public int MachineToolTypeId { get; set; }

        /// <summary>
        /// Тип ремонта
        /// </summary>
        public string RepairTypeName { get; set; } = null;

        /// <summary>
        /// Дата начала ремонта
        /// </summary>
        public DateTime StartDate { get; set; } = new DateTime(2025, 10, 26);

        /// <summary>
        /// Примечания к записи
        /// </summary>
        public string Notes { get; set; } = "Отсутствуют";
    }
}
