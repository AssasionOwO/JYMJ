using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBoard : MonoBehaviour 
{
    public float m_speed;//旋转速度

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f), m_speed * Time.deltaTime);
	}
}
