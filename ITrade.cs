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
    /// Interface used to convey information about a trade.
    /// </summary>
    public interface ITrade
    {
        /// <summary>
        /// Gets the date of the trade.
        /// </summary>
        DateTime Date { get; }

        /// <summary>
        /// Gets the order side.
        /// </summary>
        OrderSide Side { get; }

        /// <summary>
        /// Gets the symbol.
        /// </summary>
        string Symbol { get; }

        /// <summary>
        /// Gets the instrument.
        /// </summary>
        IInstrument Instrument { get; }

        /// <summary>
        /// Gets the quantity.
        /// </summary>
        double Quantity { get; }

        /// <summary>
        /// Gets the execution price.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the execution price that would have existed at the tradedate without the effects of backadjusting.
        /// </summary>
        double UnadjustedPrice { get; }

        /// <summary>
        /// Gets/sets the commission per share/contract in local currency.
        /// </summary>
        double Commission { get; set; }

        /// <summary>
        /// Gets/sets the slippage in decimal terms per share/contract.
        /// </summary>
        double Slippage { get; set; }

        /// <summary>
        /// Gets the strategy name.
        /// </summary>
        string StrategyName { get; }

        /// <summary>
        /// Gets the signal name.
        /// </summary>
        string SignalName { get; }

        /// <summary>
        /// Gets the order type that generated this trade.
        /// </summary>
        string OrderType { get; }

        /// <summary>
        /// Gets the time in force for the order.
        /// </summary>
        TimeInForce TimeInForce { get; }

        /// <summary>
        /// Gets the variable dictionary
        /// </summary>
        IDictionary<string, object> Variables { get; }
    }
}