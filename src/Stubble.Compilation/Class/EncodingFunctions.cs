﻿// <copyright file="EncodingFunctions.cs" company="Stubble Authors">
// Copyright (c) Stubble Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Linq.Expressions;
using System.Net;

namespace Stubble.Compilation.Class
{/// <summary>
 /// Contains some default implementations for encoding html
 /// </summary>
    public static class EncodingFunctions
    {
        /// <summary>
        /// Gets the web utility implementation of Html Encode
        /// </summary>
        public static Expression<Func<string, string>> WebUtilityHtmlEncoding { get; } = (str) => WebUtility.HtmlEncode(str);
    }
}
