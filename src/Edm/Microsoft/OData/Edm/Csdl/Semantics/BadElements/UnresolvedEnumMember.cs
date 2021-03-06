//   OData .NET Libraries
//   Copyright (c) Microsoft Corporation
//   All rights reserved. 

//   Licensed under the Apache License, Version 2.0 (the ""License""); you may not use this file except in compliance with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 

//   THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR NON-INFRINGEMENT. 

//   See the Apache Version 2.0 License for specific language governing permissions and limitations under the License.

using System;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Library;
using Microsoft.OData.Edm.Library.Values;
using Microsoft.OData.Edm.Validation;
using Microsoft.OData.Edm.Values;

namespace Microsoft.OData.Edm.Csdl.CsdlSemantics
{
    internal class UnresolvedEnumMember : BadElement, IEdmEnumMember
    {
        private readonly string name;
        private readonly IEdmEnumType declaringType;

        // Value cache.
        private readonly Cache<UnresolvedEnumMember, IEdmPrimitiveValue> value = new Cache<UnresolvedEnumMember, IEdmPrimitiveValue>();
        private static readonly Func<UnresolvedEnumMember, IEdmPrimitiveValue> ComputeValueFunc = (me) => me.ComputeValue();

        public UnresolvedEnumMember(string name, IEdmEnumType declaringType, EdmLocation location)
            : base(new EdmError[] { new EdmError(location, EdmErrorCode.BadUnresolvedEnumMember, Edm.Strings.Bad_UnresolvedEnumMember(name)) })
        {
            this.name = name ?? string.Empty;
            this.declaringType = declaringType;
        }

        public string Name
        {
            get { return this.name; }
        }

        public IEdmPrimitiveValue Value
        {
            get { return this.value.GetValue(this, ComputeValueFunc, null); }
        }

        public IEdmEnumType DeclaringType
        {
            get { return this.declaringType; }
        }

        private IEdmPrimitiveValue ComputeValue()
        {
            return new EdmIntegerConstant(0);
        }
    }
}
