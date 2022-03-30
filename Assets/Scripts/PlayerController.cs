using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 speed;
    float forceValue = 10;
    Rigidbody rg;
    public bool playBackground;
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        if (playBackground)
        {
            AudioController.instance.PlayBackgroundMusic(AudioController.SoundEffect.BackgroundMusic);
        }
    }

    // Update is called once per frame
    void Update()
    {

        Fly();
    }

    private void Fly()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rg.AddForce(Vector3.up * forceValue, ForceMode.Impulse);
            AudioController.instance.PlaySFX(AudioController.SoundEffect.Jump);
        }
    }
}
