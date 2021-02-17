// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace NuGet.SolutionRestoreManager
{
    public static class ExperimentalFeatures
    {
        public const string BulkFileOperationGranular = "BulkFileOperation.Granular";
        public const string BulkFileOperationGlobal = "BulkFileOperation.Global";

        private static List<string> EnabledFlights = new List<string>() { BulkFileOperationGlobal };

        public static bool IsEnabled(string featureName)
        {
            return EnabledFlights.Contains(featureName);
        }
    }
}
