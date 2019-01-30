using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// c1控制
/// </summary>
public class ZhuobiaoxiText : MonoBehaviour {

    //public GameObject gameObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha0))//数字键:0
        {
            Debug.Log(name + ":" + Vector3.forward + " " + transform.forward);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //按照本地坐标系进行移动
            transform.Translate(Vector3.forward);
            //以世界坐标系进行移动
            //transform.position+=transform.forward;
        }
    }
}
