using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCamera : MonoBehaviour
{
    [SerializeField]Transform camera;
    private void Update()
    {
        transform.eulerAngles = new Vector3(0,camera.eulerAngles.x + 180,0);
    }
}
