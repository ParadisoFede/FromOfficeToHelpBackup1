﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//TPFINAL: CERIANI, ZEDDE

public class ConstantFollowing : MonoBehaviour
{ 
    public float runSpeed;
    public GameObject target;
    public NavMeshAgent myAgent;
    public CharacterHealth vidaPlayer;

    void Start()
    {
        myAgent.speed = runSpeed;
        target = GameObject.Find("Character");
        vidaPlayer = target.GetComponent<CharacterHealth>();
    }

    void Update()
    {
        myAgent.SetDestination(target.transform.position);
    }

    private void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.layer == 9)
        {
          vidaPlayer.TakeDamage(100);  
        }        
    }
}
