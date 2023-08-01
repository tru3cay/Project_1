using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Despawn : NAM_MonoBehaviour
{
    protected abstract bool CanDespawn();

    protected virtual void Despawning()
    {
        if(!this.CanDespawn()) return;
        this.DespawnObject();
    }

    protected virtual void DespawnObject()
    {
        Destroy(transform.parent.gameObject);
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();

    }

    protected virtual void FixedUpdate()
    {
        this.Despawning();
    }
}
