using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : ClicAgentController
{
    private float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
        if (Input.GetButtonDown("Jump"))
            speed = 5f;
        else
            speed = 2.5f;

        GetComponent<NavMeshAgent>().speed = speed;
    }
}