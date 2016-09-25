﻿using System;
using System.Runtime.InteropServices;

namespace FFXIVDeviare.Packets.Subpackets.Subpackets.Chat.Sent
{
    class GeneralMessageSent : Subpacket
    {
        public override Int32 SubpacketId => 101;
        public override SubpacketType Type { get { return SubpacketType.Chat; } }
        public override Type PacketDataFormatType => typeof(Data);


        unsafe struct Data
        {
#pragma warning disable 649

            public Byte Unk1 { get; set; }
            public Byte Unk2 { get; set; }
            public UInt16 Unk3 { get; set; }
            public UInt32 Unk4 { get; set; }


            fixed byte _message[1024];
            public String Message
            {
                get
                {
                    fixed (byte* pmessage = _message)
                        return Marshal.PtrToStringAnsi((IntPtr)pmessage);
                }
            }

            
            fixed byte _unknown[7];

#pragma warning restore 649

        };
    }
}

