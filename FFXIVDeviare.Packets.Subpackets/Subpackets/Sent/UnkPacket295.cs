﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXIVDeviare.Packets.Subpackets.Subpackets.Sent
{
    class UnkPacket295 : Subpacket
    {


        public override Int32 SubpacketId => 295;

        public override Type PacketDataFormatType => typeof(Data);

        unsafe struct Data
        {

#pragma warning disable 649
            public UInt32 Unk1 { get; set; }
            public UInt32 Unk2 { get; set; }

#pragma warning restore 649

        };
    }
}
