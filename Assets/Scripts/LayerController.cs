using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : MonoBehaviour
{

    float scrollingSpeed = 0.15f;
    Vector2 pos = new Vector2();
    MeshRenderer renderer;
    float speed;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        speed = scrollingSpeed * (20 / gameObject.transform.position.z);
        pos.x = pos.x + speed * Time.deltaTime;
        renderer.material.mainTextureOffset = pos;
    }
}
