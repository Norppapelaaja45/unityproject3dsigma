using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{ 

   public float moveSpeed = 5.5f;
   public CharacterController Controller; 

   public float mouseSpeed = 3f;

   public CursorLockMode cursorLock;

   private float mouseMovementX = 0f;
   private float mouseMovementY = 0f;
    Vector3 moveDir;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = cursorLock;
        Cursor.visible =(CursorLockMode.Locked != cursorLock);
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        mouseMovementX += Input.GetAxis("Mouse X") * mouseSpeed;
        mouseMovementY += Input.GetAxis("Mouse Y") * mouseSpeed;

        Camera.main.transform.localRotation = Quaternion.Euler(mouseMovementY, 0, 0);

        transform.localRotation = Quaternion.Euler(0,mouseMovementX,0);

        moveDir = new Vector3(Horizontal,0,Vertical);
        moveDir = transform.rotation * moveDir;

        Controller.SimpleMove(moveDir * moveSpeed);
    }
}
