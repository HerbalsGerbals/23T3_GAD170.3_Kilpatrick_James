using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRigidBody : MonoBehaviour
{
    [SerializeField] private int sceneIndexToLoad;

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
            Debug.Log(gameObject.name + " hit " + collision.gameObject.name + "Hit hazard restarting level");
            SceneManager.LoadScene(sceneIndexToLoad);
        }

    }    
}
