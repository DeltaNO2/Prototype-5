using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody rb;

    private float minSpeed = 112;
    private float maxSpeed = 116;
    private float maxTorque = 110;
    private float xRange = 14;
    private float ySpawnPos = -12;

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(0, maxSpeed);
    }

    float RandomTorque()
    {
        return Random.Range(0, maxTorque);
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, 1), ySpawnPos);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(RandomTorque(), ForceMode.Impulse);
        rb.AddTorque(RandomTorque(), 0, RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos()
    }

    // Update is called once per frame
    void Update()

    private void OnMouseDown ()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
