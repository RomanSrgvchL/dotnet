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
        private static Storage _instance;

        public static Storage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Storage();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Словарь типов станка
        /// </summary>
        private Dictionary<int, MachineToolType> _machineToolTypes { get; } = new Dictionary<int, MachineToolType>();

        /// <summary>
        /// Словарь типов ремонта
        /// </summary>
        private Dictionary<string, RepairType> _repairTypes { get; } = new Dictionary<string, RepairType>();

        /// <summary>
        /// Спосок ремонтов
        /// </summary>
        private List<Repair> _repairs { get; } = new List<Repair>();

        /// <summary>
        /// Коллекция станка
        /// </summary>
        public IEnumerable<MachineToolType> MachineToolTypes
        {
            get 
            { 
                return _machineToolTypes.Values.AsEnumerable(); 
            }
        }

        /// <summary>
        /// Коллекция типов ремонта
        /// </summary>
        public IEnumerable<RepairType> RepairTypes
        {
            get
            {
                return _repairTypes.Values.AsEnumerable();
            }
        }

        /// <summary>
        /// Коллекция ремонтов
        /// </summary>
        public IEnumerable<Repair> Repairs
        {
            get
            {
                return _repairs;
            }
        }

        public event EventHandler MachineToolTypeAdded;
        public event EventHandler RepairTypeAdded;
        public event EventHandler RepairAdded;
        public event EventHandler MachineToolTypeRemoved;
        public event EventHandler RepairTypeRemoved;
        public event EventHandler RepairRemoved;

        private Storage()
        {

        }

        /// <summary>
        /// Добавление типа станка
        /// </summary>
        /// <param name="machineToolType">Информация о типе станка</param>
        public void AddMachineToolType(MachineToolType machineToolType)
        {
            if (!machineToolType.IsValid)
            {
                throw new Exception.InvalidMachineToolTypeException("Информация о типе станка заполнена некорректно");
            }
            try
            {
                _machineToolTypes.Add(machineToolType.Id, machineToolType);
                // Герерируем событие о том, что тип ремонта добавлен
                MachineToolTypeAdded?.Invoke(machineToolType, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new Exception.InvalidMachineToolTypeException("При добавлении типа станка произошла ошибка", 
                    exception);
            }
        }

        /// <summary>
        /// Добавление типа ремонта
        /// </summary>
        /// <param name="repairType">Информация о типе ремонта</param>
        public void AddRepairType(RepairType repairType)
        {
            if (!repairType.IsValid)
            {
                throw new Exception.InvalidRepairTypeException("Информация о типе ремонта заполнена некорректно");
            }
            try
            {
                _repairTypes.Add(repairType.Name, repairType);
                // Герерируем событие о том, что тип ремонта добавлен
                RepairTypeAdded?.Invoke(repairType, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new Exception.InvalidRepairTypeException("При добавлении типа ремонта произошла ошибка", 
                    exception);
            }
        }

        /// <summary>
        /// Информация о ремонте
        /// </summary>
        /// <param name="repair"></param>
        public void AddRepair(Repair repair)
        {
            if (!repair.IsValid)
            {
                throw new Exception.InvalidRepairException("Информация о ремонте заполнена некорректно");
            }
            try
            {
                _repairs.Add(repair);
                // Герерируем событие о том, что информация о ремонте добавлена
                RepairAdded?.Invoke(repair, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new Exception.InvalidRepairException("При добавлении ремонта произошла ошибка", exception);
            }
        }

        /// <summary>
        /// Удалить тип станка по идентификатору
        /// </summary>
        /// <param name="machineToolTypeId">Идентификатор типа станка</param>
        public void RemoveMachineToolType(int machineToolTypeId)
        {
            _machineToolTypes.Remove(machineToolTypeId);
            // Генерируем событие о том, что тип станка удалён
            MachineToolTypeRemoved?.Invoke(machineToolTypeId, EventArgs.Empty);
            // Получаем список сведений о ремонтах данного типа станка
            var repairsForMachineToolType = Repairs.Where(s => s.MachineToolType.Id == machineToolTypeId).ToList();
            for (int i = 0; i < repairsForMachineToolType.Count; i++)
            {
                // Удаляем сведения о ремонтах данного типа станка
                RemoveRepair(repairsForMachineToolType[i]);
            }
        }

        /// <summary>
        /// Удалить тип ремонта по имени
        /// </summary>
        /// <param name="repairTypeName">Название типа ремонта</param>
        public void RemoveRepairType(string repairTypeName)
        {
            _repairTypes.Remove(repairTypeName);
            // Генерируем событие о том, что тип ремонта удалён
            RepairTypeRemoved?.Invoke(repairTypeName, EventArgs.Empty);
            // Получаем список сведений о ремонтах данного типа
            var repairsForRepairType = Repairs.Where(s => s.RepairType.Name == repairTypeName).ToList();
            for (int i = 0; i < repairsForRepairType.Count; i++)
            {
                // Удаляем сведения о поселении в номер
                RemoveRepair(repairsForRepairType[i]);
            }
        }

        /// <summary>
        /// Удалить информацию о ремонте
        /// </summary>
        /// <param name="repair">Информация о ремонте</param>
        public void RemoveRepair(Repair repair)
        {
            _repairs.Remove(repair);
            // Генерируем событие о том, что информация о поселении удалена
            RepairRemoved?.Invoke(repair, EventArgs.Empty);
        }
    }
}