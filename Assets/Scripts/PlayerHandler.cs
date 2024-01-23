using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public GameObject playerObject;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.tag == "Death")
        {
            Destroy(playerObject);
        }
    }
}
