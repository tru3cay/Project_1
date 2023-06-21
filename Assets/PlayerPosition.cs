using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{

    public float playerPosX;
    List<GameObject> minions; //Tao list minions
    public GameObject minionPrefab;

    //Start
    private void Start()
    {
        this.minions = new List<GameObject>(); //khoi tao minions
    }

    // Update is called once per frame
    void Update()
    {
        this.playerPosX = transform.position.x;

        int spawnLocation = 7;

        if (this.playerPosX >= spawnLocation)
        {
           this.Spawn();
        }
        else
        {
            this.NotSpawn();
        }
    }

    void Spawn()
    {
        Debug.Log("Spawn");

        if (this.minions.Count >= 7) return;

        int index = this.minions.Count + 1;
        GameObject minion = Instantiate(this.minionPrefab);
        minion.name = this.minions[index].name;

        minion.transform.position = transform.position; //vi tri quai duoc transform ra

        this.minions.Add(minion);
    }

    void NotSpawn()
    {
        Debug.Log("Not Spawn");
    }
}
