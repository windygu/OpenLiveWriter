﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

namespace mshtml
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("3051041A-98B5-11CF-BB82-00AA00BDCE0B"), TypeLibType((short)0x1040)]
    public interface IHTMLDocumentCompatibleInfo
    {
        [DispId(0x3e9)]
        string userAgent { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x3e9)] get; }
        [DispId(0x3ea)]
        string version { [return: MarshalAs(UnmanagedType.BStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x3ea)] get; }
    }
}
