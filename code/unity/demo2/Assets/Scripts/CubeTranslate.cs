using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// cube移动
/// </summary>
public class CubeTranslate : MonoBehaviour {

    /// <summary>
    /// 移动速度
    /// </summary>
    private float speed;
    private KeyCode keyCode;
    // Use this for initialization
    void Start()
    {
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //keyCode=Input.
        //switch (keyCode)
        //{
        //    case KeyCode.W:
        //        transform.Translate(Vector3.forward * Time.deltaTime * speed);//平衡设备差异
        //        break;
        //    case KeyCode.S:
        //        transform.Translate(Vector3.back * Time.deltaTime * speed);
        //        break;
        //    case KeyCode.A:
        //        transform.Translate(Vector3.left * speed * Time.deltaTime);
        //        break;
        //    case KeyCode.D:
        //        transform.Translate(Vector3.right * speed * Time.deltaTime);
        //        break;
        //    default:
        //        break;
        //}

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);//平衡设备差异
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
