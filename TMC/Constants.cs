﻿namespace MinishMaker.TMC
{
    public enum RegionVersion
    {
        EU,
        JP,
        US,
        None
    }

    public struct HeaderData
    {
        public int MapHeaderBase;

        public HeaderData(int map)
        {
            this.MapHeaderBase = map;
        }
    }

    public class Header
    {
        private HeaderData[] headerTable = new HeaderData[]
        {   //             MAP     ,
            new HeaderData(0x11D95C),
            new HeaderData(0), 
            new HeaderData(0x11E214)
        };

        public HeaderData GetHeaderAddresses(RegionVersion region)
        {
            return headerTable[(int)region];
        }
    }
}
