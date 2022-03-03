using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] Vector2 jumpforce = new Vector2( 0,1000 );
  
    Rigidbody2D rb;

    void Start()
    {
     rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        //transform.Translate(0, moveAmount, 0);

        float horizAmount = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        
        transform.Translate(horizAmount, 0, 0);
        //transform.Translate(horizAmount, moveAmount, 0);

        if(Input.GetButtonDown("Jump"))
        {
          print("Jump");

          rb.AddForce(jumpforce);
        }
    }
}
