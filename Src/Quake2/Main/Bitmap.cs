/*
===========================================================================
Copyright (C) 2000-2011 Korvin Korax
Author: Jacques Krige
http://www.sagamedev.com
http://www.korvinkorax.com

This file is part of Quake2 BSP XNA Renderer source code.
Parts of the source code is copyright (C) Id Software, Inc.

Quake2 BSP XNA Renderer source code is free software; you can redistribute it
and/or modify it under the terms of the GNU General Public License as
published by the Free Software Foundation; either version 2 of the License,
or (at your option) any later version.

Quake2 BSP XNA Renderer source code is distributed in the hope that it will be
useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Foobar; if not, write to the Free Software
Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
===========================================================================
*/

using Paloma;
using System;
using System.IO;

namespace Quake2
{
    public class Bitmap
    {
        public int Width;
        public int Height;
        private int bLOCK_WIDTH;
        private int bLOCK_HEIGHT;
        private object format32bppArgb;
        private Stream strm;
        private Bitmap image;
        internal ColorPalette Palette;
        private PixelFormat pf;
        private IntPtr intPtr;

        public Bitmap(Stream strm)
        {
            this.strm = strm;
        }

        public Bitmap(int bLOCK_WIDTH, int bLOCK_HEIGHT, object format32bppArgb)
        {
            this.bLOCK_WIDTH = bLOCK_WIDTH;
            this.bLOCK_HEIGHT = bLOCK_HEIGHT;
            this.format32bppArgb = format32bppArgb;
        }

        public Bitmap(Bitmap image)
        {
            this.image = image;
        }

        public Bitmap(int bLOCK_WIDTH, int bLOCK_HEIGHT, object format32bppArgb, PixelFormat pf, IntPtr intPtr) : this(bLOCK_WIDTH, bLOCK_HEIGHT, format32bppArgb)
        {
            this.pf = pf;
            this.intPtr = intPtr;
        }

        internal void Save(MemoryStream memStream, object png)
        {
            throw new NotImplementedException();
        }

        public void SetPixel(int x, int y, object value)
        {
            throw new NotImplementedException();
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}