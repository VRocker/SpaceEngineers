﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox.Common.ObjectBuilders
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_UserControllableGun : MyObjectBuilder_FunctionalBlock
    {
        [ProtoMember(1)]
        public bool IsShooting = false;

        [ProtoMember(2)]
        public bool IsShootingFromTerminal = false;

        [ProtoMember(3)]
        public bool IsLargeTurret = false;
    }
}
