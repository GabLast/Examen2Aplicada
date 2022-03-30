using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToLeft : MonoBehaviour
{
    Vector3 speed = new Vector3(4,4);
    Vector3 pos = new Vector3();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos.x = speed.x * Time.deltaTime * -1;
        gameObject.transform.Translate(pos);
        speed += Physics.gravity * Time.deltaTime;
    }
}
