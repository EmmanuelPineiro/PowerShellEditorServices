﻿//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using Microsoft.PowerShell.EditorServices.Services.TextDocument;

namespace Microsoft.PowerShell.EditorServices.Test.Shared.Definition
{
    public class FindsFunctionDefinitionInWorkspace
    {
        public static readonly ScriptRegion SourceDetails =
            new ScriptRegion(
                file: TestUtilities.NormalizePath("References/ReferenceFileD.ps1"),
                text: string.Empty,
                startLineNumber: 1,
                startColumnNumber: 2,
                startOffset: 0,
                endLineNumber: 0,
                endColumnNumber: 0,
                endOffset: 0);
    }
}
