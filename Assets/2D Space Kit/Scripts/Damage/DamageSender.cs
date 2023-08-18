using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : NAM_MonoBehaviour
{
    [Header("Damage Sender")]
    [SerializeField] protected int damage = 1;

    public virtual void Send(Transform obj)
    {
        DamageReceiver damageReceiver;
        damageReceiver = obj.GetComponentInChildren<DamageReceiver>();
        if (damageReceiver == null) return;
        this.Send(damageReceiver);
    }

    public virtual void Send(DamageReceiver damageReceiver)
    {
        damageReceiver.Deduct(this.damage);
    }

}
