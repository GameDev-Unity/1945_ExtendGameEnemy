using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public GameObject[] waypoints = new GameObject[4];
    public GameObject PathFollower;
    public float speed = 0.1f;
    private GameObject nxtWayPoint;
 
    private int wayPointNumber = 0;

    // Use this for initialization
    void Start ()
    {
        PathFollower.transform.position = waypoints[wayPointNumber].transform.position;
        wayPointNumber++;
	    nxtWayPoint = waypoints[wayPointNumber];
    }

    // Update is called once per frame
	void Update ()
	{
	    
        // fly towards waypoint until waypoint is reached

        // switch to next waypoint when reached
       
	}

    
}
