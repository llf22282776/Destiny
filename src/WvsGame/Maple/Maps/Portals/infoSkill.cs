﻿using Destiny.Core.Data;
using Destiny.Maple.Characters;

namespace Destiny.Maple.Maps.Portals
{
    public sealed class infoSkill : Portal
    {
        public infoSkill(Datum datum) : base(datum) { }

        public override void Enter(Character character)
        {
            if (character.Quests.Started.ContainsKey(1035))
            {
                this.ShowTutorialMessage(character, "UI/tutorial.img/23");
            }
        }
    }
}
