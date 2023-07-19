using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crashdetection : MonoBehaviour
{
    [SerializeField] float ReloadTime=1f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed=false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed=true;
            FindObjectOfType<Player_control>().DisableControls();
            GetComponent<AudioSource>().PlayOneShot(crashSFX,0.5f);
            crashEffect.Play();
            Invoke("ReloadScene",ReloadTime);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
