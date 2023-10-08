using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootableObjectAbstract : NAM_MonoBehaviour
{
    [SerializeField] protected ShootableObjectCtrl shootableObjectCtrl;
    public ShootableObjectCtrl ShootableObjectCtrl => shootableObjectCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadShootableObjectCtrl();
    }

    protected virtual void LoadShootableObjectCtrl()
    {
        if (this.shootableObjectCtrl != null) return;
        this.shootableObjectCtrl = transform.parent.GetComponent<ShootableObjectCtrl>();
        Debug.LogWarning(transform.name + ": LoadShootableObjectCtrl", gameObject);
    }
}
