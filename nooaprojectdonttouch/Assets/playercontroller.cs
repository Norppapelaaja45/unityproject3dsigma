using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{ 

   public float moveSpeed = 5.5f;
   public CharacterController Controller; 

    Vector3 moveDir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        moveDir = new Vector3(Horizontal,0,Vertical);

        Controller.SimpleMove(moveDir * moveSpeed);
    }
}
