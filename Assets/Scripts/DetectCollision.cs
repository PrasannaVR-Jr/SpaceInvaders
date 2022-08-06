using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    
    public UIManager uiManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerController.Instance.TakeDamage(1f);
            if(PlayerController.Instance.referenceHealth>1)
                Restart();
        }
    }

    void Restart()
    {
        uiManager.RelaodScene();
    }
}
