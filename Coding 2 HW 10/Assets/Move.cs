
using UnityEngine;

public class Move : MonoBehaviour
{
   public float speed = 0.1f;

 
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(xDirection, 0f, zDirection);
        transform.position += moveDirection * speed;

    }
}