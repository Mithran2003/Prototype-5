using UnityEngine;
using UnityEngine.UI;

public class DifficultiButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulti);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetDifficulti()
    {
        Debug.Log(button.name + " was clicked");
        gameManager.StartGame();
    }
}
