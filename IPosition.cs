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
using System.Collections.Generic;

namespace Balsam
{
    /// <summary>
    /// Defines the contract a position must implement.
    /// </summary>
    public interface IPosition : IPortfolioHolding
    {
        /// <summary>
        /// Gets the position side.
        /// </summary>
        PositionSide Side { get; }

        /// <summary>
        /// Gets the position id.
        /// </summary>
        long Id { get; }

        /// <summary>
        /// Gets the strategy name.
        /// </summary>
        string StrategyName { get; }

        /// <summary>
        /// Gets the first entry date.
        /// </summary>
        DateTime EntryDate { get; }

        /// <summary>
        /// Gets the average entry price.
        /// </summary>
        double EntryPrice { get; }

        /// <summary>
        /// Gets the date of the last price update or the date on which the position was closed.
        /// </summary>
        DateTime LastDate { get; }

        /// <summary>
        /// Gets the last price or the exit price if the position has been closed.
        /// </summary>
        double LastPrice { get; }

        /// <summary>
        /// Gets the P&amp;L.
        /// </summary>
        double PnL { get; }

        /// <summary>
        /// Gets the P&amp;L is percentage terms.
        /// </summary>
        double PnLPercent { get; }

        /// <summary>
        /// Gets the number of bars since entry.
        /// </summary>
        int BarsSinceEntry { get; }

        /// <summary>
        /// Gets a collection of variables.
        /// </summary>
        IDictionary<string, object> Variables { get; }
    }
}
