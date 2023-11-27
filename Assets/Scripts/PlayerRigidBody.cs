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
    
}
