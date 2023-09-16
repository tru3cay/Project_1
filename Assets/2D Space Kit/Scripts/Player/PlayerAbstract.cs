using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbstract : NAM_MonoBehaviour
{
    [SerializeField] protected PlayerCtrl playerCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
    }

    protected virtual void LoadPlayerCtrl()
    {
        if (this.playerCtrl != null) return;
        this.playerCtrl = transform.GetComponentInParent<PlayerCtrl>();
        Debug.Log(transform.name + " LoadPlayerCtrl", gameObject);
    }
}
