using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class EnemySpawnerStrategy : MonoBehaviour {

    private Random random = new Random();
    private float spawnPercentage = 5;
    
    // Use this for initialization
    public virtual void StartStrategy () {
		
	}
	
	// Update is called once per frame
	public virtual void UpdateStrategy () {
        Debug.Log("strategy fucked");
        if (random.Next(100) < spawnPercentage)
        {
            //instansiate enemy
            GameObject randomEnemy = (GameObject)Instantiate(Resources.Load("Enemy"));
            randomEnemy.transform.position = new Vector3(10,0,0);

        }
    }
}
