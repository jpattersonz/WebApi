﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;

namespace System.Web.OData
{
    public class SimpleOpenZipCode
    {
        public int Code { get; set; }
        public IDictionary<string, object> Properties { get; set; }
    }
}