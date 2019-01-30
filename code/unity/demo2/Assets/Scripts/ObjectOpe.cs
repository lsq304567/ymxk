using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 游戏对象操作
/// </summary>
public class ObjectOpe : MonoBehaviour {
    /// <summary>
    /// 地球预制对象
    /// </summary>
	public GameObject Earth;
    /// <summary>
    /// 球游戏对象
    /// </summary>
	GameObject s1;
    GameObject earth;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.C))
        {
            //动态创建游戏对象，只能创建内置提供的类型
            s1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            s1.name = "qiu";
            s1.GetComponent<MeshRenderer>().material.color = Color.yellow;
            s1.transform.position = Vector3.zero;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            //延迟n秒后再销毁指定的游戏对象
            Destroy(s1, 3);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            //根据预设对象进行复制
            earth = Instantiate(Earth) as GameObject;
            earth.transform.position = Vector3.zero;
        }

        //动态添加组件
        if (Input.GetKeyDown(KeyCode.E))
        {
            earth.AddComponent<CubeTranslate>();
        }
        //动态删除组件
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Destroy(earth.GetComponent<CubeTranslate>());
        }
    }
}
