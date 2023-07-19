using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float ReloadTime = 2f;
    [SerializeField] ParticleSystem finishEffects;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            finishEffects.Play();
            Invoke("ReloadScene",ReloadTime);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
