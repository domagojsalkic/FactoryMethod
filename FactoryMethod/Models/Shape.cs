﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
    public abstract class Shape
    {
        public abstract void Draw(Graphics graphics);
    }
}
