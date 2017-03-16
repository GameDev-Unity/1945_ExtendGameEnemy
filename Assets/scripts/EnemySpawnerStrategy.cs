using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerStrategy : MonoBehaviour
{

    public float minHeight = -4;
    public float maxHeight =  4;

    private Random random = new Random();
    private float spawnPercentage = 2;
    private float spawnPercentageShootingEnemy = 0.5f;


    // Use this for initialization
    public virtual void StartStrategy () {
		
	}
	
	// Update is called once per frame
	public virtual void UpdateStrategy () {
        if (Random.value*100 < spawnPercentage)
        {
            //instansiate enemy
            GameObject randomEnemy = (GameObject)Instantiate(Resources.Load("Enemy"));
            float spawn_y = Random.Range(minHeight, maxHeight);
            randomEnemy.transform.position = new Vector3(10, spawn_y, 0);

        }

        if (Random.value * 100 < spawnPercentageShootingEnemy)
        {
            //instansiate enemy
            GameObject randomEnemy = (GameObject)Instantiate(Resources.Load("ShootingEnemy"));
            float spawn_y = Random.Range(minHeight, maxHeight);
            randomEnemy.transform.position = new Vector3(10, spawn_y, 0);

        }
    }
}
