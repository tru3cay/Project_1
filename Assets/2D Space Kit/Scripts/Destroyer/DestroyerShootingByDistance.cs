using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerShootingByDistance : DestroyerShooting
{
    [SerializeField] protected Transform target;
    [SerializeField] protected float minDis = 3f;
    [SerializeField] protected float distance = Mathf.Infinity;


    public virtual void SetTarget(Transform target)
    {
        this.target = target;
    }

    protected override bool IsShooting()
    {
        this.distance = Vector3.Distance(transform.position, this.target.position);
        this.isShooting = this.distance < this.minDis;
        return isShooting;
    }
}
