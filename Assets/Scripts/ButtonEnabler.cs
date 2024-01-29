using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEnabler : MonoBehaviour
{
    public float time = 0f;
    public GameObject button;

    void Start()
    {
        StartCoroutine(Enable());
    }

    IEnumerator Enable()
    {
        yield return new WaitForSeconds(time);
        button.SetActive(true);

    }
}
