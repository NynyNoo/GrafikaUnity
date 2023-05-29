using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]GameObject bulletPrefab;
    [SerializeField]Transform bulletPoint;
    public float shootPower=100f;
    private float nextFire = 0.5F;
    private float myTime = 0.0F;
    

    void Update()
    {
        myTime = myTime + Time.deltaTime;
        if (Input.GetButton("Fire1") && myTime > nextFire)
        {
            Vector3 b = transform.TransformDirection(new Vector3(0, 0, shootPower));
            GameObject ball=Instantiate(bulletPrefab, bulletPoint.position, transform.rotation);
            ConstantForce forc = ball.GetComponent<ConstantForce>();
            forc.force = b;
            myTime = 0.0F;
        }
    }
}
