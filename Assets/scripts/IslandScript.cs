using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandScript : EnemyScript {

	// Use this for initialization
    protected override void Start()
    {
        speed = 1.5f;
        base.Start();
    }

    protected override void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * 0.9f);
    }

    // Update is called once per frame
	
        
    
}
