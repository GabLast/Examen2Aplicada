using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.lives--;
            print("Ha perdido una vida");

            if(GameManager.lives < 0)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
