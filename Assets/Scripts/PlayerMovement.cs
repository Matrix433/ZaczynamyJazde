using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public float speed;
    private float iks;
    private float igrek;

    private SpriteRenderer sr;



    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        iks = Input.GetAxis("Horizontal");
        igrek = Input.GetAxis("Vertical");

        transform.position = transform.position + (new Vector3(iks, igrek)).normalized * speed * Time.deltaTime;


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        sr.color = Color.red;
        
    }





}
