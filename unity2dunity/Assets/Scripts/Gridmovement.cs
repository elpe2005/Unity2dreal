using UnityEngine;

public class GridMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f; // Adjust the speed as needed.
    private Vector3 targetPosition;
    private bool isMoving = false;

    private void Update()
    {
        if (!isMoving)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
                Move(Vector3.up);
            else if (Input.GetKey(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
                Move(Vector3.down);
            else if (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
                Move(Vector3.left);
            else if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
                Move(Vector3.right);
        }
    }

    private void Move(Vector3 direction)
    {
        if (CanMove(direction))
        {
            targetPosition = transform.position + direction;
            isMoving = true;
        }
    }

    private bool CanMove(Vector3 direction)
    {
        // You should implement collision detection or other checks here to ensure valid movement.
        // For simplicity, this script assumes that movement is always allowed.
        return true;
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            if (transform.position == targetPosition)
                isMoving = false;
        }
    }
}