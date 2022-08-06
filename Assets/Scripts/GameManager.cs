using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    
    public int TotalScore;
    public static GameManager instance;
    

    void Start()
    {
        TotalScore = 0;        
        instance = this;
    }

    private void Update()
    {
        
    }

    //Updates Score from Bullet class using Instance
    public void UpdateScore(int localScore)
    {
        TotalScore += localScore;        
    }

    
}
