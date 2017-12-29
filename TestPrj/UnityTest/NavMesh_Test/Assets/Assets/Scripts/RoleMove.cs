using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class RoleMove : MonoBehaviour 
{
    //private Transform target;//存储需要移动到的目标点
    //private NavMeshAgent m_angence;//自身的导航寻路组件
    //void Start () 
    //{
    //    target = GameObject.FindGameObjectWithTag("Target").transform;
    //    m_angence = GetComponent<NavMeshAgent>();
    //}
	

    //void Update()
    //{
    //    if(Input.GetMouseButtonDown(0))
    //    {
    //        Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
    //        RaycastHit hit;
    //        Physics.Raycast(ray,out hit,Mathf.Infinity);
    //        if(hit.collider.tag=="Plane")
    //        {
    //            target.position = hit.point;
    //            Debug.Log(target.position);
    //            m_angence.SetDestination(target.position);
    //        }
    //        else
    //        {
    //            return;
    //        }
    //    }
    //}
    private NavMeshAgent navMeshAgent;  
    private bool is_jumping;  
  
    void Start()  
    {  
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();//初始化navMeshAgent   
        is_jumping = false;//是否正在跳跃的flag  
    }  
  
    void Update()  
    {  
        if (Input.GetMouseButtonDown(0) && !is_jumping)  
        {//如果不是在跳跃、不是到达自动寻路边缘，按下鼠标左键       
            //自动寻路    
            Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);  
            RaycastHit mHit;  
            if (Physics.Raycast(mRay, out mHit))  
            {  
                if (mHit.collider.tag == "Plane")//如果点的是Plane上的一点    
                {  
                    navMeshAgent.SetDestination(mHit.point);
                    Debug.Log(mHit.point);
                }  
            }  
        }  
       //if (navMeshAgent.isOnOffMeshLink)//如果小球到达跳跃边缘  
       //{  
       //    OffMeshLinkData offMeshLinkData = navMeshAgent.currentOffMeshLinkData;  
       //    transform.LookAt(offMeshLinkData.endPos);//面朝跳跃的结束点  
       //    navMeshAgent.enabled = false;//关闭自动寻路    
       //    is_jumping = true;  
       //    this.GetComponent<Rigidbody>().velocity= new Vector3(offMeshLinkData.endPos.x * 3, 5, offMeshLinkData.endPos.z);  
       //}  
       //if (this.transform.position.y < -3)  
       //{//如果小球跳跃的时候没跳到Plane上面  
       //    SceneManager.LoadScene("Navmesh_diferent_plane_jump");  
       //}  
    }  
  
    //如果跳跃之中的小球和Plane开始碰撞    
   //void OnCollisionEnter(Collision collision)  
   //{  
   //    if (collision.collider.gameObject.name == "Plane" && is_jumping)  
   //    {  
   //        is_jumping = false;  
   //        navMeshAgent.enabled = true;//重新打开自动寻路    
   //    }  
   //}  
}
