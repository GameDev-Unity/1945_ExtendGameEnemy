using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Random = System.Random;

public class SubmarineSpawner : MonoBehaviour
{
    private SubmarineSpawnerStrategy strat;
    Random rand = new Random();
    public float SpawnRate = 8;
    public float NextSpawn = 0.0F;

    // Use this for initialization
    void Start ()
    {
        strat = gameObject.AddComponent<SubmarineSpawnerStrategy>();
        strat.StartStrategy();
    }
	
	// Update is called once per frame
	void Update () {
	    if (Time.time > NextSpawn)
	    {
	        NextSpawn = Time.time + 8;
            strat.UpdateStrategy();
            //Debug.Log("Sub Spawned, waiting to spawn the next one");
        }
    }
}
public class SubmarineSpawnerStrategy : MonoBehaviour
{
    Random rand = new Random();

    private int x_MaxFluctuation = 8;
    private int x_MinFluctuation = 1;
    private int y_MaxFluctuation = 4;
    private int y_MinFluctuation = -4;

    // Use this for initialization
    public virtual void StartStrategy()
    {
        Debug.Log("Submarine Spawn strategy started");
    }

    // Update is called once per frame
    public virtual void UpdateStrategy()
    {
        
        float xRand = rand.Next(x_MinFluctuation, x_MaxFluctuation);
        float yRand = rand.Next(y_MinFluctuation, y_MaxFluctuation);

        GameObject RandomSub = (GameObject)Instantiate(Resources.Load("Submarine"));
        RandomSub.transform.position = new Vector3(xRand, yRand, 0);
    }
}