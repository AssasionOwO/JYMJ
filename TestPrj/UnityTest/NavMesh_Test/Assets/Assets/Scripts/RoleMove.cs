using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleMove : MonoBehaviour 
{
    private float h;
    private float v;
    private Vector3 m_CameraForward;//相机的正前方

    private float m_speed;
    private float minSpeed=0.0f;//目标的最小移动速度
    private float maxSpeed=3.0f;//目标的最大移动速度

    public float MaxSpeed
    {
        get { return maxSpeed; }
        set { maxSpeed = value; }
    }

    public float MinSpeed
    {
        get { return minSpeed; }
        set { minSpeed = value; }
    }

	// Use this for initialization
	void Start () 
    {
        m_speed = minSpeed;
	}
	
	// Update is called once per frame
	void Update () 
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        m_CameraForward = Camera.main.transform.forward;
        FetchCameraForward();
        if(h!=0||v!=0)
        {
            m_speed = maxSpeed;
        }
        else if(h==0&&v==0)
        {
            m_speed = minSpeed;
        }
        transform.GetComponent<CharacterController>().SimpleMove(new Vector3(h+transform.forward.x, 0, v+transform.forward.z).normalized * m_speed);
	}

    void FetchCameraForward()
    {
        transform.forward = new Vector3(m_CameraForward.x, 0, m_CameraForward.z);
    }
}
