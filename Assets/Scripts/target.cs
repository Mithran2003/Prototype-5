using UnityEngine;

public class target : MonoBehaviour
{
    private Rigidbody targetRb;
    private Vector3 spawnPoint ;
    [SerializeField] 
    private float minForce;
    [SerializeField] 
    private float maxforce;
    [SerializeField]
    private float xSpwanRange;
    [SerializeField]
    private float torqueRange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(randomForce(),ForceMode.Impulse);
        targetRb.AddTorque(randomTorque(),randomTorque(),randomTorque(),ForceMode.Impulse);
        spawnPoint = randomSpwanPosition();
        transform.position = spawnPoint;
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
        return new Vector3 (Random.Range(-xSpwanRange,xSpwanRange),-1.75f);
    }
    private float randomTorque()
    {
        return Random.Range(-torqueRange,torqueRange);
    }

}
