using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Winning Place")
        {
            SceneManager.LoadScene("You Win");
            Debug.Log("You Win!");
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene("You Win");
            Debug.Log("You Win!");
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
