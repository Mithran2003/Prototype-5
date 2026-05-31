using UnityEngine;
using TMPro;
public class target : MonoBehaviour
{
    private Rigidbody targetRb;
    [SerializeField] 
    private float minForce;
    [SerializeField] 
    private float maxforce;
    [SerializeField]
    private float xSpwanRange;
    [SerializeField]
    private float ySpwanPoint;
    [SerializeField]
    private float torqueRange;
    private GameManager gameManager;
    [SerializeField]
    private int ScoreToAdd; //added to the score each time an object is destroyed 
    [SerializeField]
    private ParticleSystem explosionParticals;    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        targetRb = GetComponent<Rigidbody>();
        transform.position = randomSpwanPosition();
        targetRb.AddForce(randomForce(),ForceMode.Impulse);
        targetRb.AddTorque(randomTorque(),randomTorque(),randomTorque(),ForceMode.Impulse);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 randomForce()
    {
        return Vector3.up * Random.Range(minForce,maxforce);
    }
    private Vector3 randomSpwanPosition()
    {
        return new Vector3 (Random.Range(-xSpwanRange,xSpwanRange),ySpwanPoint);
    }
    private float randomTorque()
    {
        return Random.Range(-torqueRange,torqueRange);
    }
    private void OnMouseDown() 
    {
        Destroy(gameObject);
        gameManager.UpdateScore(ScoreToAdd);
        Instantiate(explosionParticals,transform.position,explosionParticals.transform.rotation);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!other.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }
    }

}
