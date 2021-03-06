//   OData .NET Libraries
//   Copyright (c) Microsoft Corporation
//   All rights reserved. 

//   Licensed under the Apache License, Version 2.0 (the ""License""); you may not use this file except in compliance with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 

//   THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT. 

//   See the Apache Version 2.0 License for specific language governing permissions and limitations under the License.

namespace Microsoft.OData.Core.Atom
{
    /// <summary>
    /// Possible content types of expanded navigation link in ATOM.
    /// </summary>
    internal enum ODataAtomDeserializerExpandedNavigationLinkContent
    {
        /// <summary>No content found, no m:inline.</summary>
        None,

        /// <summary>Empty content found, m:inline without anything in it. Usually represents null entry.</summary>
        Empty,

        /// <summary>Expanded entry found.</summary>
        Entry,

        /// <summary>Expanded feed found.</summary>
        Feed
    }
}
