using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEnabler : MonoBehaviour
{
    public GameObject objectToEnable;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            objectToEnable.SetActive(true);
        }  
    }
}
