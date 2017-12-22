using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour 
{
    private Transform target;
    public float preDistance=10.0f;//设置相机与目标之间的距离
    public float m_CameraSpeed = 10.0f;//相机移动的速度
    private float eulerAngles_x;//相机的X欧拉角
    private float eulerAngles_y;//相机的Y欧拉角
	void Start () 
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        CameraFindTarget();
	}
	
	
	void LateUpdate () 
    {
        CameraFindTarget();
        RollCamera();
	}

    void RollCamera()
    {
        //调整相机的角度
        if(Input.GetMouseButton(1))
        {
            float h = Input.GetAxis("Mouse X");
            float v = Input.GetAxis("Mouse Y");
            eulerAngles_x -= (v * m_CameraSpeed) * Time.deltaTime;
            eulerAngles_y += (h * m_CameraSpeed) * Time.deltaTime;
            this.transform.eulerAngles = new Vector3(eulerAngles_x, eulerAngles_y, 0);
            CameraFindTarget();

        }

    }

    void CameraFindTarget()
    {
        transform.position = target.position - transform.forward * preDistance;
    }
}
