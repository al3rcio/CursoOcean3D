using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonBallPrefab;

    public float delayInit = 1f;
    public float delayBetweenSpawns = 1f;
    public float force = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCannonBall", delayInit, delayBetweenSpawns);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCannonBall()
    {
        var cannonBall = Instantiate(cannonBallPrefab, transform.position, transform.rotation);
        var rb = cannonBall.GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.up * force);
    }
}
