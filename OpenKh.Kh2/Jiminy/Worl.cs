﻿using Xe.BinaryMapper;

namespace OpenKh.Kh2.Jiminy
{
    public class Worl
    {
        [Data] public byte Id { get; set; } //also responsible for world icon in journal, menu/<region>/jm_world.2ld
        [Data(Count = 2)] public string Name { get; set; }
        [Data] public byte Padding { get; set; }
        [Data] public ushort TextTitle { get; set; }
        [Data] public ushort TextSubmenu { get; set; }
        [Data] public ushort Unk08 { get; set; }
        [Data] public ushort TextTitle2 { get; set; } //these 3 fields are only used by hollow bastion, to switch to radiant garden later
        [Data] public ushort TextSubmenu2 { get; set; }
        [Data] public ushort Unk0E { get; set; }
    }
}
