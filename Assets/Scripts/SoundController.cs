using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racketSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketLeft" || collision.gameObject.name == "RacketRight")
            this.racketSound.Play();
        else
            this.wallSound.Play();
    }
}
