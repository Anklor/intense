﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intense.Text.Fonts.Tables
{
    /// <summary>
    /// Describes the preferred rasterization techniques for the typeface when it is rendered on grayscale-capable devices
    /// </summary>
    public class FontTableGasp
        : FontTable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FontTableGasp"/>.
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="record"></param>
        internal FontTableGasp(Stream stream, FontTableRecord record)
            : base(stream, record)
        {
            var buffer = ReadTable();

            // TODO: implement
        }
    }
}