﻿#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This content is released under the (http://opensource.org/licenses/MIT) MIT License, see license/jni4net-MIT.txt.
*/

#endregion

namespace java.lang
{
    partial class Long
    {
        public static implicit operator Long(long value)
        {
            return new Long(value);
        }

        public static explicit operator long(Long value)
        {
            return value.longValue();
        }
    }
}