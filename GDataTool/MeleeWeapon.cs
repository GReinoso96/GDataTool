using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDataTool
{
    class MeleeWeapon
    {
        private byte modelID;
        private byte rarity;
        private UInt16 sharpnessID;
        private UInt32 price;
        private UInt16 damage;
        private byte defense;
        private byte fire;
        private byte water;
        private byte thunder;
        private byte dragon;
        private byte poison;
        private byte paralysis;
        private byte sleep;
        private UInt16 sortOrder;
        private UInt32 nameOffset;
        private string name;

        public byte ModelID { get => modelID; set => modelID = value; }
        public byte Rarity { get => rarity; set => rarity = value; }
        public ushort SharpnessID { get => sharpnessID; set => sharpnessID = value; }
        public uint Price { get => price; set => price = value; }
        public ushort Damage { get => damage; set => damage = value; }
        public byte Defense { get => defense; set => defense = value; }
        public byte Fire { get => fire; set => fire = value; }
        public byte Water { get => water; set => water = value; }
        public byte Thunder { get => thunder; set => thunder = value; }
        public byte Dragon { get => dragon; set => dragon = value; }
        public byte Poison { get => poison; set => poison = value; }
        public byte Paralysis { get => paralysis; set => paralysis = value; }
        public byte Sleep { get => sleep; set => sleep = value; }
        public ushort SortOrder { get => sortOrder; set => sortOrder = value; }
        public uint NameOffset { get => nameOffset; set => nameOffset = value; }
        public string Name { get => name; set => name = value; }

        public MeleeWeapon(byte modelID, byte rarity, UInt16 sharpnessID, UInt32 price, UInt16 damage,
            byte defense, byte fire, byte water, byte thunder, byte dragon, byte poison, byte paralysis,
            byte sleep, UInt16 sortOrder, UInt32 nameOffset)
        {
            this.ModelID = modelID;
            this.Rarity = rarity;
            this.SharpnessID = sharpnessID;
            this.Price = price;
            this.Damage = damage;
            this.Defense = defense;
            this.Fire = fire;
            this.Water = water;
            this.Thunder = thunder;
            this.Dragon = dragon;
            this.Poison = poison;
            this.Paralysis = paralysis;
            this.Sleep = sleep;
            this.SortOrder = sortOrder;
            this.NameOffset = nameOffset;
        }
    }
}
