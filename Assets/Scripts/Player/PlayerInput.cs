using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f;
    [SerializeField]
    private float lookSensitivity = 5f;
    [SerializeField]
    private PlayerController controller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float xMov = Input.GetAxisRaw("Horizontal");
        float yMov = Input.GetAxisRaw("Vertical");

        Vector3 velocity = (transform.right * xMov + transform.forward * yMov).normalized * speed;
        controller.Move(velocity);

        float xMouse = Input.GetAxisRaw("Mouse X");
        float yMouse = Input.GetAxisRaw("Mouse Y");

        Vector3 yRotation = new Vector3(0f, xMouse, 0f) * lookSensitivity;
        Vector3 xRotation = new Vector3(-yMouse, 0f, 0f) * lookSensitivity;
        controller.Rotate(yRotation, xRotation);
    }
}
