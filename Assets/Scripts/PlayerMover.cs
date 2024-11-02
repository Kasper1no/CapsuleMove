using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidBody;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float mouseSensitivity;
    private void Update()
    {
        Move();

        Rotate();
    }

    private void Rotate()
    {
        var mouseY = Input.GetAxis("Mouse X");

        transform.Rotate(0f, mouseY * mouseSensitivity, 0f);
    }

    private void Move()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        
        var movement = new Vector3(horizontal,0f, vertical) * (moveSpeed * Time.deltaTime);
        
        rigidBody.velocity = transform.TransformDirection(movement);
    }
}
