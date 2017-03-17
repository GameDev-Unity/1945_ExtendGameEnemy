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

    private float distanceToWaypoint;
    private Vector3 startingPosition;
    private int wayPointNumber = 0;

    // Use this for initialization
    void Start()
    {
        PathFollower.transform.position = waypoints[wayPointNumber].transform.position;
        wayPointNumber++;
        nxtWayPoint = waypoints[wayPointNumber];
        startingPosition = PathFollower.transform.position;
        distanceToWaypoint = Vector3.Distance(PathFollower.transform.position, nxtWayPoint.transform.position);
        //Vector3 direction = nxtWayPoint.transform.position - PathFollower.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (PathFollower != null)
        {
            // move toward nxtWayPoint
            if (Vector3.Distance(PathFollower.transform.position, startingPosition) < distanceToWaypoint)
            {
                float distanceToMove = Time.deltaTime * speed;
                PathFollower.transform.position = Vector3.MoveTowards(PathFollower.transform.position, nxtWayPoint.transform.position, distanceToMove);
            }
            //change waypoint
            else
            {
                wayPointNumber++;
                nxtWayPoint = waypoints[wayPointNumber];
                startingPosition = PathFollower.transform.position;
                distanceToWaypoint = Vector3.Distance(PathFollower.transform.position, nxtWayPoint.transform.position);
            }
        }




    }


}