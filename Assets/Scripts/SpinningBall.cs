using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningBall : MonoBehaviour
{
    Vector3 speed = new Vector3(10,10);
    Vector3 pos = new Vector3();
    Vector3 angle = new Vector3();
    float radio = 4, acceleration = 0;
    GameObject center;

    private void Awake()
    {
        center = GameObject.FindGameObjectWithTag("Center");
    }

    void Update()
    {
        angle = speed * Time.time / radio;

        pos.x = center.transform.position.x + radio * Mathf.Cos(angle.x);
        pos.y = center.transform.position.y + radio * Mathf.Sin(angle.y);
        
        
        gameObject.transform.position = pos;

        speed.x += acceleration * Time.deltaTime;
        speed.y += acceleration * Time.deltaTime;
    }
}
