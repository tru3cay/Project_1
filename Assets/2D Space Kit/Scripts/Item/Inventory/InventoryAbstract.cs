using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryAbstract : NAM_MonoBehaviour
{
    [SerializeField] protected Inventory inventory;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadInventory();
    }
    protected virtual void LoadInventory()
    {
        if (this.inventory != null) return;
        this.inventory = transform.parent.GetComponent<Inventory>();
    }
}
