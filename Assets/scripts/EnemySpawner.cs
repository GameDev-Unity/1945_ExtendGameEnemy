using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    private EnemySpawnerStrategy strategy;

	// Use this for initialization
	void Start ()
	{
	    strategy = gameObject.AddComponent<EnemySpawnerStrategy>();
		strategy.StartStrategy();
	}
	
	// Update is called once per frame
	void Update () {
		strategy.UpdateStrategy();
	}
}
