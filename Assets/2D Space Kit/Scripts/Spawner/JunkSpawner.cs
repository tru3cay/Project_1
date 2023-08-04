using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{
    protected static JunkSpawner instance;
    public static JunkSpawner Instance { get => instance; }

    public static string bulletOne = "Meteorite_1(Asteroid 1)";

    protected override void Awake()
    {
        base.Awake();
        if (JunkSpawner.instance != null) Debug.LogWarning("Only 1 JunkSpawner allow to exist");
        JunkSpawner.instance = this;
    }
}
