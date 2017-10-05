using System;

namespace Server.Items
{
    public class CowBellDeed : BaseAddonDeed
    {
        public override int LabelNumber { get { return 1098418; } } // cowbell

        [Constructable]
        public CowBellDeed()
        {
        }

        public CowBellDeed(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddon Addon { get { return new CowBellAddon(); } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadEncodedInt();
        }
    }

    public class CowBellAddon : BaseAddon
    {
        public override BaseAddonDeed Deed { get { return new CowBellDeed(); } }
        public override bool RetainDeedHue { get { return true; } }

        [Constructable]
        public CowBellAddon()
        { 
            AddComponent(new InstrumentedAddonComponent(0x4C5A, 0x66F), 0, 0, 10);
        }

        public CowBellAddon(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadEncodedInt();
        }
    }
}