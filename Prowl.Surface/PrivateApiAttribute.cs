﻿using System;

namespace Prowl.Surface.Metadata;

[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Constructor
                | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Struct)]
public sealed class PrivateApiAttribute : Attribute
{

}
