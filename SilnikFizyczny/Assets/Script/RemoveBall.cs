using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBall : MonoBehaviour
{
    private float myTime = 0.0F;
    public float destroyTime = 8.0F;

    private void FixedUpdate()
    {
        myTime = myTime + Time.deltaTime;
        if (myTime > destroyTime)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
