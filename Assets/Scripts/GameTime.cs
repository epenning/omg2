﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour {

    public static float timeMultiplier = 1;

    public static bool paused = false;

    public static float deltaTime { get { return paused ? 0 : Time.deltaTime * timeMultiplier; } }
}
