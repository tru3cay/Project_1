using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : NAM_MonoBehaviour
{
    //public static Spawner instance;
    [SerializeField] protected List<Transform> prefabs;

    /*protected override void Awake()
    {
        base.Awake();
        Spawner instance = this;
    }*/

    protected override void LoadComponents()
    {
        this.LoadPrefabs();
    }
    protected virtual void LoadPrefabs()
    {
        Transform prefabs_1 = transform.Find("Prefabs");
        foreach (Transform prefab in prefabs_1)
        {
            this.prefabs.Add(prefab);
        }

        this.HidePrefabs();
    }

    protected virtual void HidePrefabs()
    {
        foreach (Transform prefab in prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }
    
    /*public virtual Transform Spawn(Vector3 spawnPos, Quaternion rotation)
    {
        Transform prefab = this.prefabs[0];
        Transform newPrefab = DestroyerShooting.Instantiate(this.prefabs, spawnPos, rotation);
        return newPrefab;
    }*/
}
