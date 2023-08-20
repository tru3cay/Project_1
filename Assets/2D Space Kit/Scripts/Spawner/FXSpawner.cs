using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXSpawner: Spawner
{
    protected static FXSpawner instance;
    public static FXSpawner Instance  => instance; 

    public static string smokeOne = "Smoke_1";

    protected override void Awake()
    {
        base.Awake();
        if (FXSpawner.instance != null) Debug.LogWarning("Only 1 FXSpawner allow to exist");
        FXSpawner.instance = this;
    }
}
