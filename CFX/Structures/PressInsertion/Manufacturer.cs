/*
Copyright 2018 TE Connectivity

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
-------------------------------------------------------------------------
*/
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.PressInsertion
{
    /// <summary>
    /// Describes a Manufacturer
    /// <code language="none">
    /// {
    ///     "UniqueIdentifier": "UID23890423",
    ///     "Name": "ACME"
    /// }
    /// </code>
    /// </summary>
    public class Manufacturer
    {
        /// <summary>
        /// The unique identifier of the Manufacturer
        /// </summary>
        public string UniqueIdentifier
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the Manufacturer
        /// </summary>
        public string Name
        {
            get;
            set;
        }
    }
}
