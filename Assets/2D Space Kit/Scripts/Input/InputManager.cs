using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    protected static InputManager instance;
    public static InputManager Instance { get => instance; }

    [SerializeField] protected Vector3 mouseWorldPos;
    public Vector3 MouseWorldPos { get => mouseWorldPos; }

    [SerializeField] protected float onFiring;
    public float OnFiring { get => onFiring; }



    private void Awake()
    {
        if (InputManager.instance != null) Debug.LogWarning("Only 1 Input manager allow to exist");
        InputManager.instance = this;
    }
    //di chuot theo Camera
    void FixedUpdate()
    {
        this.GetMousePos();
    }

    protected virtual void GetMousePos()
    {
        this.mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    //press to shoot
    private void Update()
    {
        this.GetMousePress();
    }

    protected virtual void GetMousePress()
    {
        this.onFiring = Input.GetAxis("Fire1"); //Edit-ProjectManager-InputManager-Fire1
    }
}
