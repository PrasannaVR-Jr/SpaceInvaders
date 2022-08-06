using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This class is just for moving the bullet upward
public class MoveBullet : MonoBehaviour
{
    public float BulletVelocity=2f;
    private void Update()
     {
            transform.Translate(BulletVelocity * Vector2.up * Time.deltaTime);
     }
    
}
