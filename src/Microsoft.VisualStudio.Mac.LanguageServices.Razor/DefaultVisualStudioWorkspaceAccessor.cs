﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.Composition;
using Microsoft.CodeAnalysis;
using Microsoft.VisualStudio.Editor.Razor;
using MonoDevelop.Ide;
using MonoDevelop.Ide.TypeSystem;

namespace Microsoft.VisualStudio.Mac.LanguageServices.Razor
{
    [System.Composition.Shared]
    [Export(typeof(VisualStudioWorkspaceAccessor))]
    internal class DefaultVisualStudioWorkspaceAccessor : VisualStudioWorkspaceAccessor
    {
        public override Workspace Workspace => IdeServices.TypeSystemService.Workspace;
    }
}