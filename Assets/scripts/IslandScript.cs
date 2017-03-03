using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandScript : EnemyScript {

	// Use this for initialization
	void Start () {
		SetSoundEngine(GameObject.FindGameObjectWithTag("SoundEngine").GetComponent<SoundEngine>());
	    speed = 1.5f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }
}
