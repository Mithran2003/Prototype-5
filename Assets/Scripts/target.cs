using UnityEngine;

public class target : MonoBehaviour
{
    private Rigidbody targetRb;
    private Vector3 spawnPoint ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(Vector3.up * Random.Range(10,16),ForceMode.Impulse);
        targetRb.AddTorque(Random.Range(-10,10),Random.Range(-10,10),Random.Range(-10,10),ForceMode.Impulse);
        spawnPoint.x = Random.Range(-4.75f,4.75f);
        spawnPoint.y = -1.75f;
        transform.position = spawnPoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
