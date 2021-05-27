using UnityEngine;

public class QuitOnEscape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Debug.Log("qUTI!");
            Application.Quit();
        }
    }
}
