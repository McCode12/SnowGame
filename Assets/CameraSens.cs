using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class CameraSens : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 public float mouseSensitivity = 100000f;
        public Transform playerBody; // Assign your player's transform here

        float xRotation = 0f;

        public void OnLook(InputAction.CallbackContext context)
        {
            Vector2 lookInput = context.ReadValue<Vector2>();

            // Calculate rotation based on input and sensitivity
            float mouseX = lookInput.x * mouseSensitivity * Time.deltaTime;
            float mouseY = lookInput.y * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Clamp vertical rotation

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
}
