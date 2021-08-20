using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDataTool
{
    class GunnerWeapon
    {
		private byte model;
		private byte rarity;
		private byte unk1;
		private byte reloadSpeed;
		private UInt32 price;
		private UInt16 damage;
		private byte defense;
		private byte sortOrder;
		private byte recoilLvl;
		private byte ammoCapacity;
		private byte unk3;
		private byte unk4;
		private UInt32 stringOffset;
		private Int32 bulletConfig;
		private string name;

        public GunnerWeapon(byte model, byte rarity, byte unk1, byte reloadSpeed, uint price, ushort damage, byte defense, byte sortOrder, byte recoilLvl, byte ammoCapacity, byte unk3, byte unk4, uint stringOffset, Int32 bulletConfig)
        {
            this.model = model;
            this.rarity = rarity;
            this.unk1 = unk1;
            this.reloadSpeed = reloadSpeed;
            this.price = price;
            this.damage = damage;
            this.defense = defense;
            this.sortOrder = sortOrder;
            this.recoilLvl = recoilLvl;
            this.ammoCapacity = ammoCapacity;
            this.unk3 = unk3;
            this.unk4 = unk4;
            this.stringOffset = stringOffset;
            this.bulletConfig = bulletConfig;
        }

        public byte Model { get => model; set => model = value; }
        public byte Rarity { get => rarity; set => rarity = value; }
        public byte Unk1 { get => unk1; set => unk1 = value; }
        public byte ReloadSpeed { get => reloadSpeed; set => reloadSpeed = value; }
        public uint Price { get => price; set => price = value; }
        public ushort Damage { get => damage; set => damage = value; }
        public byte Defense { get => defense; set => defense = value; }
        public byte SortOrder { get => sortOrder; set => sortOrder = value; }
        public byte RecoilLvl { get => recoilLvl; set => recoilLvl = value; }
        public byte AmmoCapacity { get => ammoCapacity; set => ammoCapacity = value; }
        public byte Unk3 { get => unk3; set => unk3 = value; }
        public byte Unk4 { get => unk4; set => unk4 = value; }
        public uint StringOffset { get => stringOffset; set => stringOffset = value; }
        public Int32 BulletConfig { get => bulletConfig; set => bulletConfig = value; }
        public string Name { get => name; set => name = value; }
    }
}
