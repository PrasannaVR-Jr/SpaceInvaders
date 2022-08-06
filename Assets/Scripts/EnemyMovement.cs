using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    bool canMove;
    float multiplier;

    private void Start()
    {
        multiplier = 1;
        canMove = false;
    }
        
    void Update()
    {
        int Timer = Mathf.FloorToInt(Time.time);
        moveDownEnemy(Timer);
        moveSideWardEnemy(Timer);        
    }

    //Movement methods below
    void moveDownEnemy(int Timer)
    {
        if (Timer % 2 == 0)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.4f * Time.deltaTime);
            canMove = true;
        }
    }

    void moveSideWardEnemy(int Timer)
    {
        if (Timer % 2 != 0 && canMove == true)
        {
            transform.position = new Vector2(transform.position.x + multiplier * 20 * Time.deltaTime, transform.position.y);
            if (multiplier == 1)
                multiplier = -1;
            else
                multiplier = 1;
            canMove = false;
        }
    }
}
