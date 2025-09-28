using MachineToolMaintenance.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace MachineToolMaintenance.Serialization
{
    [Serializable]
    public class MTMSerializable
    {
        public List<MachineToolType> MachineToolTypes { get; set; } = new List<MachineToolType>();
        public List<RepairType> RepairTypes { get; set; } = new List<RepairType>();
        public List<RepairSerializable> Repairs { get; set; } = new List<RepairSerializable>();

        public static void Save(string fileName, SerializeType type)
        {
            var mtmSerializable = new MTMSerializable();
            var storage = Storage.Instance;
            foreach (var machineToolType in storage.MachineToolTypes)
            {
                mtmSerializable.MachineToolTypes.Add(machineToolType);
            }
            foreach (var repairType in storage.RepairTypes)
            {
                mtmSerializable.RepairTypes.Add(repairType);
            }
            foreach (var repair in storage.Repairs)
            {
                mtmSerializable.Repairs.Add(new RepairSerializable
                {
                    MachineToolTypeId = repair.MachineToolType.Id,
                    RepairTypeName = repair.RepairType.Name,
                    StartDate = repair.StartDate,
                    Notes = repair.Notes
                });
            }
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(MTMSerializable));
                    using (StreamWriter xmlStreamWriter = new StreamWriter(fileName))
                    {
                        xmlSerializer.Serialize(xmlStreamWriter, mtmSerializable);
                    }
                    break;
                case SerializeType.JSON:
                    using (StreamWriter jsonStreamWriter = File.CreateText(fileName))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer { Formatting = Formatting.Indented };
                        jsonSerializer.Serialize(jsonStreamWriter, mtmSerializable);
                    }
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream binaryFileStream = new FileStream(fileName, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(binaryFileStream, mtmSerializable);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public static void Load(string fileName, SerializeType type)
        {
            MTMSerializable mtmSerializable;
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(MTMSerializable));
                    StreamReader streamReader = new StreamReader(fileName);
                    mtmSerializable = (MTMSerializable)xmlSerializer.Deserialize(streamReader);
                    break;
                case SerializeType.JSON:
                    StreamReader jsonStreamReader = File.OpenText(fileName);
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    mtmSerializable = (MTMSerializable)jsonSerializer.Deserialize(jsonStreamReader, typeof(MTMSerializable));
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream binaryFileStream = new FileStream(fileName, FileMode.Open);
                    mtmSerializable = (MTMSerializable)formatter.Deserialize(binaryFileStream);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            var storage = Storage.Instance;
            var storageMachineToolTypes = storage.MachineToolTypes.ToList();
            var storageRepairTypes = storage.RepairTypes.ToList();
            var storageRepairs = storage.Repairs.ToList();
            foreach (var storageMachineToolType in storageMachineToolTypes)
            {
                storage.RemoveMachineToolType(storageMachineToolType.Id);
            }
            foreach (var storageRepairType in storageRepairTypes)
            {
                storage.RemoveRepairType(storageRepairType.Name);
            }
            foreach (var storageRepair in storageRepairs)
            {
                storage.RemoveRepair(storageRepair);
            }
            var machineToolTypes = new Dictionary<int, MachineToolType>();
            var repairTypes = new Dictionary<string, RepairType>();
            int maxMachineToolTypeId = 0;
            foreach (var machineToolType in mtmSerializable.MachineToolTypes)
            {
                if (machineToolType.Id > maxMachineToolTypeId) maxMachineToolTypeId = machineToolType.Id;
                machineToolTypes.Add(machineToolType.Id, machineToolType);
                storage.AddMachineToolType(machineToolType);
            }
            MachineToolType.NewMachineToolTypeId = maxMachineToolTypeId;
            foreach (var repairType in mtmSerializable.RepairTypes)
            {
                repairTypes.Add(repairType.Name, repairType);
                storage.AddRepairType(repairType);
            }
            foreach (var repair in mtmSerializable.Repairs)
            {
                storage.AddRepair(new Repair
                {
                    MachineToolType = machineToolTypes[repair.MachineToolTypeId],
                    RepairType = repairTypes[repair.RepairTypeName],
                    StartDate = repair.StartDate,
                    Notes = repair.Notes
                });
            }
        }
    }
}
