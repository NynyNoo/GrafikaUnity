using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject wall;
    int checker = 0;
    private void Start()
    {
        animator = wall.GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(checker==0)
            {
                animator.ResetTrigger("Open");
                animator.SetTrigger("Close");
                AudioSource sound = other.GetComponent<AudioSource>();
                sound.Play();
                checker = 1;
            }
            
        }
    }
}
