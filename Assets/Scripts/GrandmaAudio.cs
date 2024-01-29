using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GrandmaAudio : MonoBehaviour
{
    public AudioSource audioSourceBAD;
    public AudioSource audioSourceGOOD;
    public Enemy2 enemy2;
    public GameObject thisObject;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player" && enemy2.killedFriendly == true)
        {
            audioSourceBAD.Play();
            Destroy(thisObject);
        }
        
        if(col.tag == "Player" && enemy2.killedFriendly == false)
        {
            audioSourceGOOD.Play();
            Destroy(thisObject);
        }
    }
}
