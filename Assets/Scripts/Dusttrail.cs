using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusttrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustEffect;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            dustEffect.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        dustEffect.Stop();
    }
}
