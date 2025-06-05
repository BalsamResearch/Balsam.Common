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

[assembly: CLSCompliant(true)]
namespace Balsam
{
    /// <summary>
    /// Order side
    /// </summary>
    public enum OrderSide
    {
        /// <summary>
        /// None or not set
        /// </summary>
        None = 0,
        /// <summary>
        /// Buy
        /// </summary>
        Buy,
        /// <summary>
        /// Sell
        /// </summary>
        Sell,
        /// <summary>
        /// Sell short
        /// </summary>
        SellShort,
        /// <summary>
        /// Cover
        /// </summary>
        Cover,
    }

    /// <summary>
    /// Position side
    /// </summary>
    public enum PositionSide
    {
        /// <summary>
        /// Long
        /// </summary>
        Long = 1,
        /// <summary>
        /// Flat or no position
        /// </summary>
        Flat = 0,
        /// <summary>
        /// Short
        /// </summary>
        Short = -1,
    }

    /// <summary>
    /// Order time in force.
    /// </summary>
    public enum TimeInForce
    {
        /// <summary>
        /// Order good for one day or bar. Default TimeInForce.
        /// </summary>
        Day = 0,
        /// <summary>
        /// Order to be executed on the open.
        /// </summary>
        Open,
        /// <summary>
        /// Order to be executed on the close.
        /// </summary>
        Close,
        /// <summary>
        /// Order good until canceled.
        /// </summary>
        GTC,
        /// <summary>
        /// Order good until expiration date.
        /// </summary>
        GTD,
    }

    /// <summary>
    /// Order status
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// New
        /// </summary>
        New = 0,
        /// <summary>
        /// Pending submit.
        /// </summary>
        PendingSubmit,
        /// <summary>
        /// Submitted
        /// </summary>
        Submitted,
        /// <summary>
        /// Canceled
        /// </summary>
        Canceled,
        /// <summary>
        /// Expired
        /// </summary>
        Expired,
        /// <summary>
        /// Rejected
        /// </summary>
        Rejected,
        /// <summary>
        /// Filled
        /// </summary>
        Filled,
        /// <summary>
        /// Contingent. For use in production scenarios.
        /// </summary>
        Contingent,
    }
    
    /// <summary>
    /// Severity level of messages.
    /// </summary>
    public enum SeverityLevel
    {
        /// <summary>
        /// Trace
        /// </summary>
        Trace,
        /// <summary>
        /// Debug
        /// </summary>
        Debug,
        /// <summary>
        /// Informational
        /// </summary>
        Info,
        /// <summary>
        /// Warning
        /// </summary>
        Warn,
        /// <summary>
        /// Error
        /// </summary>
        Error,
        /// <summary>
        /// Fatal error. Execution should not continue.
        /// </summary>
        Fatal,
    }
       
    /// <summary>
    /// Type of indexing for ISeries
    /// </summary>
    public enum IndexKind
    {
        /// <summary>
        ///  Absolute. Indexed from zero to Count - 1.
        /// </summary>
        Absolute = 0,
        /// <summary>
        /// As an offset to the current index (e.g. 0 is current index; 1 is 1 bar prior).
        /// </summary>
        RelativeToCurrent,
    }

    /// <summary>
    /// Instrument type
    /// </summary>
    public enum InstrumentType
    {
        /// <summary>
        /// Unknown or not specified
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Equity
        /// </summary>
        Equity,
        /// <summary>
        /// Index
        /// </summary>
        Index,
        /// <summary>
        /// Option
        /// </summary>
        Option,
        /// <summary>
        /// Future
        /// </summary>
        /// 
        Future,
        /// <summary>
        /// Forex
        /// </summary>
        Forex,
        /// <summary>
        /// Cash or spot
        /// </summary>
        Cash,
    }
}
