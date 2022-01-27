using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    public float jumpforce = 10f;

    public bool tocaSuelo;

    float dirx;

    public SpriteRenderer renderer;

    public Animator animatronix;

    Rigidbody2D rBody;

    void Awake()
    {

        animatronix = GetComponent<Animator>();
        rBody = GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    void Update()
    {
        dirx = Input.GetAxisRaw("Horizontal");
        
        Debug.Log(dirx);

        transform.position += new Vector3(dirx, 0, 0) * speed * Time.deltaTime;

         if(dirx == -1)
        {
            renderer.flipX = true;
            animatronix.SetBool("Running", true);
        }
        else if(dirx == 1)
        {
            renderer.flipX = false;
            animatronix.SetBool("Running", true);
        }
        else
        {
            animatronix.SetBool("Running", false);
        }
        
        if(Input.GetButtonDown("Jump") && tocaSuelo) 
        {

            rBody.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse); 
            animatronix.SetBool("Salto", true);

        }

    }
}
