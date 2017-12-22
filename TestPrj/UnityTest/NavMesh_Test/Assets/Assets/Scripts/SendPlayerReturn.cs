using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendPlayerReturn : MonoBehaviour 
{
    private Transform ReturnPoint;//返回点
	// Use this for initialization

    void Awake()
    {
        ReturnPoint = GameObject.Find("ReturnPoint").transform;
    }
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            other.transform.position = ReturnPoint.position;
        }
    }


}
