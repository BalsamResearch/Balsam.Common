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
    /// Defines the contract a strategy must implement.
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// Raises a message event.
        /// </summary>
        event EventHandler<MessageEventArgs> Message;

        /// <summary>
        /// Gets the strategy name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets/sets the start date.
        /// </summary>
        DateTime StartDate { get; set; }

        /// <summary>
        /// Gets/sets the end date.
        /// </summary>
        DateTime EndDate { get; set; }

        /// <summary>
        /// Gets an enumerable of open positions.
        /// </summary>
        IEnumerable<IPosition> OpenPositions { get; }

        /// <summary>
        /// Gets an enumerable of closed positions.
        /// </summary>
        IEnumerable<IPosition> ClosedPositions { get; }

        /// <summary>
        /// Gets an enumerable of target positions.
        /// </summary>
        IEnumerable<IPosition> TargetPositions { get; }

        /// <summary>
        /// Gets an enumerable of pending orders.
        /// </summary>
        IEnumerable<IOrder> PendingOrders { get; }

        /// <summary>
        /// Runs the strategy.
        /// </summary>
        void RunSimulation();

        /// <summary>
        /// Clears the strategy.
        /// </summary>
        void Clear();
    }
}
