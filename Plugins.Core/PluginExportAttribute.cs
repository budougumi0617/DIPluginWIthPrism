﻿//
// PluginExportAttribute.cs
//
// Author:
//       budougumi0617 <budougumi0617@gmail.com>
//
// Copyright (c) 2016 budougumi0617
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.ComponentModel.Composition;

namespace Plugins.Core
{
    /// <summary>
    /// This custom Attribute is used to discern each plugin.
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class PluginExportAttribute : ExportAttribute, IPluginMetadataView
    {
        /// <summary>
        /// Create plugin ID string by <see cref="System.Type"/>.
        /// </summary>
        /// <param name="id">Plugin class.</param>
        public PluginExportAttribute(Type id)
            : base(typeof(IPlugin))
        {

            pluginId = id.FullName;
        }

        /// <summary>
        /// Full name of Plugin Class
        /// </summary>
        private string pluginId;
        public string PluginId
        {
            get
            {
                return pluginId;
            }
        }
    }
}