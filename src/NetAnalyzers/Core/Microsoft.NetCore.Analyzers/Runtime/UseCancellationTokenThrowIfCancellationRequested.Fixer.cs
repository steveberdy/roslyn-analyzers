﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;

namespace Microsoft.NetCore.Analyzers.Runtime
{
    [ExportCodeFixProvider(LanguageNames.CSharp, LanguageNames.VisualBasic)]
    public sealed class UseCancellationTokenThrowIfCancellationRequestedFixer : CodeFixProvider
    {
        public override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(UseCancellationTokenThrowIfCancellationRequested.RuleId);

        public override Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            return Task.CompletedTask;
        }
    }
}
