using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    Text ScoreText;
    public GameObject[] Hearts;
    
    public GameObject GameOverPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
        UpdateLife();
        if (PlayerController.Instance.referenceHealth < 1)
        {
            GameOverPanel.SetActive(true);
            Time.timeScale = 0;         
        }
    }

    public void RelaodScene()
    {
        SceneManager.LoadScene(0);        
    }

    void UpdateScore()
    {
        ScoreText.text = "Score: " + GameManager.instance.TotalScore;
    }

    void UpdateLife()
    {
        if(PlayerController.Instance.referenceHealth>=1)
            Hearts[(int)PlayerController.Instance.referenceHealth-1].SetActive(true);
    }
}
