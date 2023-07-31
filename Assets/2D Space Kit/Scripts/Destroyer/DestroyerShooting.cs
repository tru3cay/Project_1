using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerShooting : MonoBehaviour
{
    [SerializeField] protected bool isShooting = false;
    [SerializeField] protected Transform bulletPrefab;
    [SerializeField] protected float shootDelay = 0.5f;
    [SerializeField] protected float shootTime = 0f;

    void Update()
    {
        this.IsShooting();
        //this.Shooting();
    }
    private void FixedUpdate()
    {
        this.Shooting();
    }

    protected virtual void Shooting()
    {
        if (!this.isShooting) return;

        this.shootTime += Time.fixedDeltaTime;
        if (this.shootTime < this.shootDelay) return;
        this.shootTime = 0f;


        Vector3 spawnPos = transform.position;
        Quaternion rotation = transform.parent.rotation;
        Transform newBullet = Instantiate(this.bulletPrefab, spawnPos, rotation);
        //Transform newBullet = Spawner.instance.Spawn(spawnPos, rotation);
        newBullet.gameObject.SetActive(true);
        
        Debug.Log("Shooting");
    }

    protected virtual bool IsShooting()
    {
        this.isShooting = InputManager.Instance.OnFiring == 1;
        return isShooting;
    }
}
