using UnityEngine;

public class CharMove : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // A / D
        float moveZ = Input.GetAxis("Vertical");   // W / S

        Vector3 move = new Vector3(moveX, 0f, moveZ);

        transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);
    }
}
