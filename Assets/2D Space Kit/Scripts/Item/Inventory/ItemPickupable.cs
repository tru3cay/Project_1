using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]

public class ItemPickupable : JunkAbstract
{
    [SerializeField] protected SphereCollider _collider;

    public static ItemCode StringToItemCode(string itemName)
    {
        try
        {
            return (ItemCode)System.Enum.Parse(typeof(ItemCode), itemName);
        }
        catch(ArgumentException e)
        {
            Debug.LogError(e.ToString());
            return ItemCode.NoItem;
        }
    }

    public virtual void OnMouseDown()
    {
        PlayerCtrl.Instance.PlayerPickup.ItemPickup(this);
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadTrigger();
    }


    protected virtual void LoadTrigger()
    {
        if (this._collider != null) return;
        this._collider = transform.GetComponent<SphereCollider>();
        this._collider.isTrigger = true;
        this._collider.radius = 0.1f;
        Debug.LogWarning(transform.name + " LoadTrigger", gameObject);
    }

    public virtual ItemCode GetItemCode()
    {
        return ItemPickupable.StringToItemCode(transform.parent.name);
    }

    public virtual void Picked()
    {
        this.junkCtrl.JunkDespawn.DespawnObject();
    }

}
