﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXIVDeviare.Packets.Subpackets.Subpackets.Received
{
    class UnkPacket260 : Subpacket
    {


        public override Int32 SubpacketId => 260;

        public override Type PacketDataFormatType => typeof(Data);

        unsafe struct Data
        {


#pragma warning disable 649

            public UInt32 ItemID { get; set; }
            public UInt32 Unk2 { get; set; }
            public UInt16 Unk3 { get; set; }
            public UInt16 Unk4 { get; set; }
            public UInt32 Unk5 { get; set; }

#pragma warning restore 649

        };
    }
}

