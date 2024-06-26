﻿using LabFusion.Utilities;

using UnityEngine;

namespace LabFusion.SDK.Achievements
{
    public class OneMoreTime : Achievement
    {
        public override string Title => "One More Time";

        public override string Description => "Enter Jay's taxi while in multiplayer.";

        public override int BitReward => 200;

        public override Texture2D PreviewImage => FusionAchievementLoader.GetPair(nameof(OneMoreTime)).Preview;
    }
}
