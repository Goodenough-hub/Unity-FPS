using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private Camera cam;

    private Vector3 velocity = Vector3.zero; // 速度=每秒移动的距离
    private Vector3 yRotation = Vector3.zero; // 旋转视角
    private Vector3 xRotation = Vector3.zero;

    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }
    public void Rotate(Vector3 _yRotation, Vector3 _xRotation)
    {
        yRotation = _yRotation;
        xRotation = _xRotation;
    }
    private void PerformMovement()
    {
        if (velocity != Vector3.zero)
        {
            // 最后的位置＝上次的位置 + 速度 * 时间
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }

    private void PerformRotation()
    {
        if (yRotation != Vector3.zero)
        {
            rb.transform.Rotate(yRotation);
        }

        if (xRotation != Vector3.zero)
        {
            cam.transform.Rotate(xRotation);
        }
    }
    private void FixedUpdate()
    {
        PerformMovement();
        PerformRotation();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
