﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ychet
{
    public interface IColorSelector
    {
        /// <summary>
        /// Selects a suitable brush based on the item and/or its position withn a collection.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        Brush SelectBrush(int index);
    }
}
