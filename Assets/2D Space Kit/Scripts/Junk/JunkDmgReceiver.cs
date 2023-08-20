using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDmgReceiver : DamageReceiver
{
    [SerializeField] protected JunkCtrl junkCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkCtrl();
    }

    protected virtual void LoadJunkCtrl()
    {
        if (this.junkCtrl != null) return;
        this.junkCtrl = transform.parent.GetComponent<JunkCtrl>();
        Debug.Log(transform.name + ": LoadJunkCtrl", gameObject);
    }

    protected override void OnDead()
    {
        this.OnDeadFX();
        this.junkCtrl.JunkDespawn.DespawnObject();
    }

    protected virtual string GetOnDeadFXName()
    {
        return FXSpawner.smokeOne;
    }

    protected virtual void OnDeadFX()
    {
        string fxName = this.GetOnDeadFXName();
        Transform fxOnDead = FXSpawner.Instance.Spawn(fxName, transform.position, transform.rotation);
        fxOnDead.gameObject.SetActive(true);
    }

    public override void Reborn()
    {
        this.hpMax = this.junkCtrl.JunkSO.hpMax;
        base.Reborn();
    }
}
