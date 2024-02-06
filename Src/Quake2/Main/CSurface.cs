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

using SharpDX;
using SharpDX.Direct2D1;
using System;

namespace Quake2
{
    public class CSurface
    {
        public static int BLOCK_WIDTH = 800;
        public static int BLOCK_HEIGHT = 640;

        internal void BeginBuildingLightmaps(ref CModel.SModel sModel)
        {
            throw new NotImplementedException();
        }

        internal void BuildPolygonFromSurface(ref CModel.SMSurface mSurface)
        {
            throw new NotImplementedException();
        }

        internal int[] BuildSurfaceIndex(CModel.SMSurface sMSurface)
        {
            throw new NotImplementedException();
        }

        internal void BuildSurfaceIndex(ref CModel.SMSurface sMSurface)
        {
            throw new NotImplementedException();
        }

        internal void CreateSurfaceLightmap(CModel.SModel sModel, ref CModel.SMSurface mSurface)
        {
            throw new NotImplementedException();
        }

        internal void EndBuildingLightmaps(ref CModel.SModel sModel)
        {
            throw new NotImplementedException();
        }

        internal void SubdivideSurface(ref CModel.SMSurface sMSurface)
        {
            throw new NotImplementedException();
        }
    }
}