using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;


public class IslandStrategy : EnemySpawnerStrategy
{
    Random random = new Random();


    public override void StartStrategy()
    {
        base.StartStrategy();
    }

    public override void UpdateStrategy()
    {
        Debug.Log("Island strategyhehehexd");
        if (random.Next(1000) > 10)
        {
            //instansiate enemy
            GameObject randomEnemy = (GameObject)Instantiate(Resources.Load("DangerousIsland"));
            randomEnemy.transform.position = new Vector3(10, random.Next(-4,4), 0);

        }
    }
}

