using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject target;
    public float speed;

    private SpriteRenderer sr;

    void Start()
    {
        sr = target.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        
    }

    


}
