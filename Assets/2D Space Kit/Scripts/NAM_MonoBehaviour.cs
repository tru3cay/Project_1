using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NAM_MonoBehaviour : MonoBehaviour
{
    protected virtual void Reset()
    {
        this.LoadComponents();
    }
    protected virtual void Awake()
    {
        this.LoadComponents();
    }
    protected virtual void Start()
    {
        //override
    }
    protected virtual void LoadComponents()
    {
        //override
    }
}
