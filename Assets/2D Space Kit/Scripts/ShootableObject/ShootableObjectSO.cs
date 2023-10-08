using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShootableObject", menuName = "ScriptableObject/ShootableObject")]
public class ShootableObjectSO : ScriptableObject
{
    public string objName = "Shootable Object";
    public ObjectType objType;

    public int hpMax = 2;
    public List<DropRate> dropList;
}
