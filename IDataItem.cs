// MIT License
//
// Copyright (c) 2007-2025 Balsam Research, LLC All rights reserved.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE

using System;

namespace Balsam
{
    /// <summary>
    /// Defines an interface for communicating information about a data file.
    /// </summary>
    public interface IDataItem
    {
        /// <summary>
        /// Gets the symbol.
        /// </summary>
        string Symbol { get; }

        /// <summary>
        /// Gets the number of records.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Gets the first date.
        /// </summary>
        DateTime FirstDate { get; }

        /// <summary>
        /// Gets the last date.
        /// </summary>
        DateTime LastDate { get; }

        /// <summary>
        /// Gets the full path of the file.
        /// </summary>
        string FullName { get; }

        /// <summary>
        /// Gets the last write time of the file.
        /// </summary>
        DateTime FileTime { get; }
    }
}
