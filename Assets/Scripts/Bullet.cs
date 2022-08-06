using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    //Checks collision between objects in Scene
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag== "alien")
        {
            GameManager.instance.UpdateScore(100);
            
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    
    



}
