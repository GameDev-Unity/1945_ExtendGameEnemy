using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandScript : EnemyScript {

	// Use this for initialization
    public override void Start()
    {
        speed = 1.5f;
        base.Start();
    }

    public override void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * 0.9f);
    }

    // Update is called once per frame
	
        
    
}
