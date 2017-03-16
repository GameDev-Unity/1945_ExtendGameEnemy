using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;
    public Direction direction = Direction.Right;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (direction == Direction.Left)
	    {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        
        else
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        // destroy bullets outside screen
	    if (transform.position.x > 12)
	    {
            Destroy(gameObject);
        }        
    }

    // remove bullet when it hits something
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Colliosion on bullet detected");
        Destroy(gameObject);
    }

    public enum Direction { Left, Right};

}
