using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotate : MonoBehaviour {
    public GameObject Sun;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //y轴正方向转动
        transform.RotateAround(Sun.transform.position,
                               Vector3.up,
                               1);
    }
}
