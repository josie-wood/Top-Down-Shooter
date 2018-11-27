﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsObject : MonoBehaviour {

    public GameObject player;
    public float speed = 5.0f;
    Transform transform;
    Transform currentPos;
    float distance;
    public float range;
    public bool staysAtRange = false;
    public float rangedDistance = 2f;
    public Transform moveTo;


	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
        transform = player.transform;
        currentPos = GetComponent<Transform>();
        

    }
	
	// Update is called once per frame
	void Update () {

        
        if (player != null)
        {
            distance = Vector3.Distance(currentPos.position, transform.position);

            if (distance <= range)
            {
                if (staysAtRange == false)
                {
                    currentPos.position = Vector3.MoveTowards(currentPos.position, transform.position, speed * 0.1f);
                }
                else if (staysAtRange == true)
                {
                    if (distance > rangedDistance)
                    {
                        currentPos.position = Vector3.MoveTowards(currentPos.position, transform.position, speed * 0.1f);
                    }
                    else //if (distance <= rangedDistance)
                    {
                        currentPos.position = Vector3.MoveTowards(currentPos.position, moveTo.position, speed * 0.1f);
                    }
                }
            }
            
        }
	}

    //public void SetTarget(Transform newTarget)
    //{
    //    target = newTarget;
    //}

}
