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
    private int score ;
    [SerializeField]
    private int spwanScore; //added to the score each time an object is spawned 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spwanObjects());
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spwanObjects()
    {
        while(true)
        {
            yield return new WaitForSeconds(spwanDelay);
            int index = Random.Range(0,targets.Count);
            Instantiate(targets[index]);
            UpdateScore(spwanScore);
        }
    }
    private void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text ="Score:"+ score;
    }
        
    
}
