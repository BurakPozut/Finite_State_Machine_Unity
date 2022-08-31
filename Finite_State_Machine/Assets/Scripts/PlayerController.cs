using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public Material playerMat;
    Vector3 moveDirection;
   // Start is called before the first frame update
    

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float moveZ = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");

        moveDirection = new Vector3(moveX, 0, moveZ);
        moveDirection *= 2;

        controller.Move(moveDirection * Time.deltaTime);
    }

    
}
