using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            AudioSource sound = other.GetComponent<AudioSource>();
            sound.Play();
        }
    }
}

