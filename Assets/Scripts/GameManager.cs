using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
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
    private int score ;  
    private bool gameOver = false;  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        StartCoroutine(spwanObjects());
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
        GameOverText.gameObject.SetActive(true);
        gameOver = true;
    }
        
    
}
