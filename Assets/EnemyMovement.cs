﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<Waypoint> path;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PrintAllWaypoints());
    }

    IEnumerator PrintAllWaypoints()
    {
        print(" Starting Patrol");
        foreach(Waypoint waypoint in path)
        {
            transform.position = waypoint.transform.position;
            print("visiting: " + waypoint.name);
            yield return new WaitForSeconds(1f);
        }
        print(" Ending Patrol");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
