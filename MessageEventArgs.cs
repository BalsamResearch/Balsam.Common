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
using System.Runtime.Serialization;

namespace Balsam
{
    /// <summary>
    /// A class used to pass messages to listeners.
    /// </summary>
    [DataContract]
    public class MessageEventArgs : EventArgs
    {
        [DataMember(Order = 1)]
        private DateTime _timestamp = DateTime.UtcNow;

        [DataMember(Order = 2)]
        private string _message;

        [DataMember(Order = 3)]
        private SeverityLevel _severity;

        [DataMember(Order = 4)]
        private string _symbol;

        /// <summary>
        /// Used to support serialization.
        /// </summary>
        private MessageEventArgs() { }

        /// <summary>
        /// Initializes a new message with default severity level of Info.
        /// </summary>
        /// <param name="message">The message to be delivered.</param>
        public MessageEventArgs(string message)
            : this(message, SeverityLevel.Info)
        {
        }

        /// <summary>
        /// Initializes a new message with the specified severity level.
        /// </summary>
        /// <param name="message">The message to be delivered.</param>
        /// <param name="severity">The severity level.</param>
        public MessageEventArgs(string message, SeverityLevel severity)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message), "Message cannot be null.");

            _message = message;
            _severity = severity;
        }

        /// <summary>
        /// Gets the timestamp of the message.
        /// </summary>
        public DateTime Timestamp
        {
            get { return _timestamp.ToLocalTime(); }
        }

        /// <summary>
        /// Gets the message.
        /// </summary>
        public string Message 
        {
            get { return _message; }
        }

        /// <summary>
        /// Gets the severity level.
        /// </summary>
        public SeverityLevel Severity
        {
            get { return _severity; }
        }

        /// <summary>
        /// Gets/sets the symbol that generated the message, if any.
        /// </summary>
        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

        /// <summary>
        /// Gets/sets an object representing the user state. This can be used to pass additional context or data, including exceptions.
        /// </summary>
        public object UserState { get; set; }

        /// <summary>
        /// Returns a string representation of this message.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0}: {1}", Severity, Message);
        }
    }
}
