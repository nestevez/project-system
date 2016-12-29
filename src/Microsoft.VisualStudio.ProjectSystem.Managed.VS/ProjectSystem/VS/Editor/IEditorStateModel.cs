﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.VisualStudio.Threading;

namespace Microsoft.VisualStudio.ProjectSystem.VS.Editor
{
    interface IEditorStateModel
    {
        Task OpenEditorAsync();

        Task<bool> CloseWindowAsync();

        Task DisposeEditorAsync();

        JoinableTask ScheduleProjectFileUpdate();

        Task SaveProjectFileAsync();
    }
}
