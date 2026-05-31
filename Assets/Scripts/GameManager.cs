using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> targets ;
    [SerializeField]
    private float spwanDelay ;
    [SerializeField]
    private TextMeshProUGUI scoreText;
    [SerializeField]
    private TextMeshProUGUI GameOverText;
    [SerializeField]
    private TextMeshProUGUI ScoreText;
    private int score ;  
    private bool gameOver ;  
    [SerializeField]
    private Button RestartButton;
    [SerializeField]
    private GameObject titleScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spwanObjects()
    {
        while(gameOver==false)
        {
            yield return new WaitForSeconds(spwanDelay);
            int index = Random.Range(0,targets.Count);
            Instantiate(targets[index]);
        }
    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text ="Score:"+ score;
    }
    public void GameOver()
    {
        RestartButton.gameObject.SetActive(true);
        GameOverText.gameObject.SetActive(true);
        gameOver = true;
    }
    public bool isGameRuning()
    {
        if (gameOver==true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public void RestartScene() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);         
    }
    public void StartGame()
    {
        gameOver = false;
        score = 0;
        StartCoroutine(spwanObjects());
        UpdateScore(0);
        ScoreText.gameObject.SetActive(true);
        titleScreen.gameObject.SetActive(false);
    }   
    
}
