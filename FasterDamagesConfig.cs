﻿using System.ComponentModel;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace FasterDamages
{
    [Label("Faster Weapons Config")]
    public class FasterDamagesConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        public static FasterDamagesConfig Instance;

        [Header("Speed")]
        [Label("Weapon Speed")]
        [DefaultValue(1.25f)]
        [Range(0.5f, 10f)]
        public float WeaponSpeed;
    }
}