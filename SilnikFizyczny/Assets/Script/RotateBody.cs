using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBody : MonoBehaviour
{
    [SerializeField] Transform orientation;
    private void Update()
    {
        transform.position = orientation.position;
    }
}
