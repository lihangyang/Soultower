using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycode : MonoBehaviour
{
    //定义移动速度
    public float su = 3f;
    //定义Transform
    private Transform s;
    // Use this for initialization
    void Start()
    {
        s = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    public void Update()
    {
        //键盘移动代码
        if (Input.GetKey(KeyCode.W))
        {
            s.Translate(Vector3.forward * su * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            s.Translate(Vector3.back * su * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            s.Translate(Vector3.left * su * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            s.Translate(Vector3.right * su * Time.deltaTime, Space.World);
        }
    }

}
