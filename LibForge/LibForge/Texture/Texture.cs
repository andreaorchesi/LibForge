﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibForge.Texture
{
  public class Texture
  {
    public class Mipmap
    {
      public int Width;
      public int Height;
      public int Flags;
      public byte[] Data;
    }

    public int BitsPerPixel;
    public Mipmap[] Mipmaps;
  }
}