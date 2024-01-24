using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatCreate : MonoBehaviour
{
    public bool enableCheck = false;
    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        enableCheck = true;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        enableCheck = false;
    }
}
