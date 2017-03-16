using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    private EnemySpawnerStrategy strategy;
    private EnemySpawnerStrategy islands;

	// Use this for initialization
	void Start ()
	{
	    strategy = gameObject.AddComponent<EnemySpawnerStrategy>();
	  //  islands = gameObject.AddComponent<IslandStrategy>();
		//strategy.StartStrategy();
       // islands.StartStrategy();
	}
	
	// Update is called once per frame
	void Update () {
		strategy.UpdateStrategy();
        //islands.UpdateStrategy();
	}
}
