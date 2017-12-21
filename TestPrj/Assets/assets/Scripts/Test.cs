using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		if(transform.position==Vector3.zero)
        {
            ErrorAbout error = new ErrorAbout();
            error.ErrorHanding();
        }
	}
}

public class Handle1
{
    public void ErrorHanding()
    {
        Debug.Log("出现错误，向邮件管理员发送信息！");
    }
}


public class Handle2
{
    public void ErrorHanding()
    {
        Debug.Log("出现错误，哔哔哔~~");
    }
}

public class Handle3
{
    public void ErrorHanding()
    {
        Debug.Log("出现错误，哒哒哒~~~~~~~");
    }
}

public class ErrorAbout
{
    public void ErrorHanding()
    {
        Handle1 handle1=new Handle1();
        Handle2 handle2 = new Handle2();
        Handle3 handle3 = new Handle3();
        handle1.ErrorHanding();
        handle2.ErrorHanding();
        handle3.ErrorHanding();
    }
}