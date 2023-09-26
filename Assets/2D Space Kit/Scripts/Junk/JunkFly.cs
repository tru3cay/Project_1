using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkFly : ParentFly
{
    [SerializeField] protected float minCamPos = -10f;
    [SerializeField] protected float maxCamPos = 10f;


    protected override void ResetValue()
    {
        base.ResetValue();
        this.moveSpeed = 1f;
    }
    protected virtual void GetFlyDirection()
    {
        Vector3 camPos = this.GetCamPos();
        Vector3 objPos = transform.parent.position;

        camPos.x += Random.Range(this.minCamPos, this.maxCamPos);
        camPos.y += Random.Range(this.minCamPos, this.maxCamPos);

        Vector3 diff = camPos - objPos;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x)*Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z);
        Debug.DrawLine(camPos, objPos + diff*1, Color.red, Mathf.Infinity);
    }

    protected virtual Vector3 GetCamPos()
    {
        if(GameCtrl.Instance == null) return Vector3.zero;
        Vector3 camPos = GameCtrl.Instance.MainCamera.transform.position;
        return camPos;
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        this.GetFlyDirection();
    }
}
