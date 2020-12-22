﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Microsoft.Health.DicomCast.TableStorage
{
    internal static class Constants
    {
        public const string FhirTableName = "FhirExceptionTable";

        public static readonly IEnumerable<string> AllTables = new List<string>() { FhirTableName };
    }
}
