using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class LookAroundCamera : MonoBehaviour
    {
        // Transformation handle for the player body
        public Transform playerBody;

        // Use this for initialization
        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        // Update is called once per frame
        void Update()
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            playerBody.Rotate(new Vector3(0, 0, mouseX));
        }
    }
}