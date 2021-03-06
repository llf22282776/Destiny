﻿using Destiny.Core.Data;
using Destiny.Maple.Characters;

namespace Destiny.Maple.Maps.Portals
{
    public sealed class market17 : Portal
    {
        public market17(Datum datum) : base(datum) { }

        public override void Enter(Character character)
        {
            character.Variables.Add(new Variable("fm_origin", character.Map.MapleID));
            character.Variables.Add(new Variable("fm_origin_portal", this.Label));

            this.PlaySoundEffect(character);

            character.ChangeMap(910000000, "out00");
        }
    }
}
