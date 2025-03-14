using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    void Update()
    {
        float moveX = 0f;
        float moveZ = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveX = 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveZ = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveZ = 1f;
        }

        Vector3 moveDirection = new Vector3(moveX, 0f, moveZ).normalized;

        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
