using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class NarratorTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public PlayerMovement playerMovement;
    private float speed;
    private float jump;
    public GameObject thisObject;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        speed = playerMovement.speed;
        jump = playerMovement.jumpheight;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioSource.Play();
            StartCoroutine(PlayerSpeed());
        }
    }

    IEnumerator PlayerSpeed()
    {
        playerMovement.speed = 0;
        playerMovement.jumpheight = 0;
        yield return new WaitForSeconds(audioClip.length);
        playerMovement.speed = speed;
        playerMovement.jumpheight = jump;
        Destroy(thisObject);
    }
}