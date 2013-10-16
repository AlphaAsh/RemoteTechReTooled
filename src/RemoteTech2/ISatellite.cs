﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace RemoteTech
{
    public interface ISatellite
    {
        bool Visible { get; }
        String Name { get; set; }
        Guid Guid { get; }
        Vector3 Position { get; }
        CelestialBody Body { get; }

        bool Powered { get; }
        bool IsCommandStation { get; }

        float OmniRange { get; }
        IEnumerable<Dish> Dishes { get; }
    }
}