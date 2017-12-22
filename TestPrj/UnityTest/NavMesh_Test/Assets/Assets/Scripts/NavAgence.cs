using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavAgence : MonoBehaviour 
{

    private GameObject target;
	// Use this for initialization
	void Start () 
    {
        target = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () 
    {
        this.GetComponent<NavMeshAgent>().SetDestination(target.transform.position);
	}
}
