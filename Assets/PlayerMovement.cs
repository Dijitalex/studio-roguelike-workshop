using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{//All the magic happens here rahhhhhh!
    [SerializeField] Rigidbody2D rb;
    // Start is called before the first frame update
    void Start(){
        //Debug.Log("A");=System.output.print("A");
    }
    void OnMove(InputValue value){
        Vector2 direction = value.Get<Vector2>();
        rb.velocity = direction*10;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
