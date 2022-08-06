using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet2 : MonoBehaviour
{
    [SerializeField]
    GameObject ShootObject;
    float shotTime;
    int bullets;
    // Start is called before the first frame update
    void Start()
    {
        bullets = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
        CheckTime();
    }

    //Fire Only 2 bullets per second
    void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space) && bullets<2 )
        {
            if(bullets==0)
                shotTime = Time.time;
            Instantiate(ShootObject, transform.position, Quaternion.identity);
            bullets++;
        }

    }
    //Checks time frame from first bullet shot time
    void CheckTime()
    {
        if (Time.time >= shotTime + 1)
            bullets = 0;
    }

    

}
