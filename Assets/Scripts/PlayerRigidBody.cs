using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRigidBody : MonoBehaviour
{
    public Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody body = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(gameObject.name + " hit " + collision.gameObject.name);
        }

    }    
}
