﻿using SimulationFramework;
using SimulationFramework.Drawing;

using thrustr.basic;
using thrustr.utils;

partial class main {
    static void rend(ICanvas c) {
        c.Clear(Color.Black);

        fontie.rendertext(c, $"{math.round(1/Time.DeltaTime)} fps", 3,3);
    }
}