using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed=5f;
    float Health;
    public static PlayerController Instance;
    public float referenceHealth;
    private void Awake()
    {
        if (Instance == null )
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        Health = 3;        
    }

    //Player Movement Controls
    void Update()
    {
        MovePlayer();
        CheckPlayerHealth();
        referenceHealth = Health;
        Debug.Log("Health " + Health);
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.position = new Vector2(MovementSpeed * Time.deltaTime + transform.position.x, transform.position.y);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.position = new Vector2(-1 * MovementSpeed * Time.deltaTime + transform.position.x, transform.position.y);

        }
    }

    public void TakeDamage(float HitPoints)
    {
       Health -= HitPoints;
    }

    void CheckPlayerHealth()
    {
        if (Health<= 0)
        {
            gameObject.SetActive(false);
            
        }
    }

}
