using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    [SerializeField]
    GameObject Bullet;
    int BulletsPerSec;
    float timeSinceFire;
    bool isDelayed;

    private void Awake()
    {
        timeSinceFire = 0f;
        BulletsPerSec = 0;
        isDelayed = false;
    }

    void Update()
    {
        FireContinuous();
        FireRapid();            
    }

    //Hold Space to shoot two bullets per second with 0.2 seconds delay between first and second bullet
    void FireContinuous()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            timeSinceFire += Time.deltaTime;
            if (timeSinceFire > 1f)
            {
                timeSinceFire = 0;
                BulletsPerSec = 0;
                isDelayed = false;
            }

            if (timeSinceFire > 0.2f && isDelayed == false)
            {
                Instantiate(Bullet, transform.position, Quaternion.identity);
                isDelayed = true;
                Debug.Log("Shot At 0.5");
            }

            if (timeSinceFire < 1f && BulletsPerSec < 1)
            {
                Debug.Log("Shot At 0.0");
                Instantiate(Bullet, transform.position, Quaternion.identity);
                BulletsPerSec++;
            }
        }
    }

    //Fire Whenever spacebar is lifted
    void FireRapid()
    {
        if (Input.GetButtonUp("Jump"))
        {
            timeSinceFire = 0;
            BulletsPerSec = 0;
            isDelayed = false;
            Debug.Log("Time: " + timeSinceFire);
        }
    }


}
