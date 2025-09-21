using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineToolMaintenance
{
    /// <summary>
    /// Техническое обслуживание станков
    /// </summary>
    public class Storage
    {
        /// <summary>
        /// Словарь типов станка
        /// </summary>
        public static Dictionary<int, MachineToolType> MachineToolTypes { get; } = new Dictionary<int, MachineToolType>();
        /// <summary>
        /// Словарь типов ремонта
        /// </summary>
        public static Dictionary<string, RepairType> RepairTypes { get; } = new Dictionary<string, RepairType>();
        /// <summary>
        /// Спосок ремонтов
        /// </summary>
        public static List<Repair> Repairs { get; } = new List<Repair>();
    }
}