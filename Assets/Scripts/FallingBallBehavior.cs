using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBallBehavior : MonoBehaviour
{
    Vector3 pos = new Vector3();
    Vector3 speed = new Vector3();
    GameObject target;
    float fallRange = 5;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {
        if(target.transform.position.x - gameObject.transform.position.x >= fallRange)
        {
            pos.y = speed.y * Time.deltaTime + Physics.gravity.y * Mathf.Pow(Time.deltaTime, 2) / 2;
            gameObject.transform.Translate(pos);
            speed += Physics.gravity * Time.deltaTime;
        }        
    }
}
