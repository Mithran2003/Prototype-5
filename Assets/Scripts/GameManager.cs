using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> targets ;
    [SerializeField]
    private float spwanDelay ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spwanObjects());
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
        }
    }
}
