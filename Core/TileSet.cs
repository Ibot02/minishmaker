﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MinishMaker.Core
{
    public class TileSet
    {
        byte[] tilesetData;

        public int Size
        {
            get { return tilesetData.Length / 0x20; }
        }

        public TileSet(byte[] data)
        {
            tilesetData = data;
        }

        public void SetChunk(byte[] newdata, int dest)
        {
            newdata.CopyTo(this.tilesetData, dest);
        }

        //draws a quarter tile
        public void DrawQuarterTile(ref Bitmap tileImg, Point p, int tnum, Color[] pal, bool hflip, bool vflip, bool overwrite)
        {
            byte[] data = new byte[0x20];
            Array.Copy(tilesetData, tnum * 0x20, data, 0, 0x20);

            int dataPos = 0;
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x += 2) //2 pixels at a time
                {
                    //itteration						0	1	2	3	4	5	6	7	-	0	1	2	3	4	5	6	7
                    int posX = hflip ? 6 - x : x; //	6+7	4+5	2+3	0+1	x	x	x	x	or	0+1	2+3	4+5	6+7	x	x	x	x
                    int posY = vflip ? 7 - y : y; //	7	6	5	4	3	2	1	0	or	0	1	2	3	4	5	6	7 
                    posX += p.X;
                    posY += p.Y;

                    int colorData = data[dataPos];
                    int data1 = hflip ? colorData >> 4 : colorData & 0x0F; // /16 for last 4 bits or & 15 for the first 4 bits
                    int data2 = hflip ? colorData & 0x0F : colorData >> 4;
                    Color color1 = pal[data1];
                    Color color2 = pal[data2];

                    if (color1.A > 0)//if see through dont draw white
                    {
                        tileImg.SetPixel(posX, posY, color1);
                    }
                    else if (overwrite)
                    {
                        tileImg.SetPixel(posX, posY, Color.White);
                    }
                    if (color2.A > 0)//if see through dont draw white
                    {
                        tileImg.SetPixel(posX + 1, posY, color2);
                    }
                    else if (overwrite)
                    {
                        tileImg.SetPixel(posX + 1, posY, Color.White);
                    }
                    dataPos++;
                }
            }
        }
    }
}
