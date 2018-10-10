using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skepp : MonoBehaviour
{
    public SpriteRenderer rend;
    public Color color;
    public float rotationspeed = 360;
    public float movespeed = 1f;
   
	// Use this for initialization
	void Start ()
        // randomiserar farten 
    {
        movespeed = Random.Range(1, 11);
        //spawnar vid ett random location
        transform.Translate(Random.Range(-18, 19), Random.Range(-10, 11), 0);
	}
	
	// Update is called once per frame
	void Update ()
    {
        // svänger åt höger om man trycker på D
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Rotate(0, 0, -rotationspeed * Time.deltaTime);
            rend.color = Color.blue;
        }
        // svänger åt vänster Om man trycker på A
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Rotate(0, 0, rotationspeed / 2 * Time.deltaTime);
            rend.color = Color.green; 
        }
        // gör att båten hela tiden åker framåt
        transform.Translate(0, -movespeed * Time.deltaTime, 0, Space.Self);
        // sänker farten till hälften
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, movespeed/2 * Time.deltaTime, 0, Space.Self);
        }
        //gör att båten får en random färg när man trycker på space eller håller in i den
        if (Input.GetKey(KeyCode.Space))
        {
            rend.color = new Color(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
        }
        //om den åker utanför -18 x så hamnar den vid 18y
        if (transform.position.x < -18)
        {
            transform.position = new Vector3(18, transform.position.y);
        }
        //om den är mer än 18x så hamnar den på -18y
        if (transform.position.x > 18)
        {
            transform.position = new Vector3(-18, transform.position.y);
        }
        //om den är mindre än -10y så hamnar den på 10x
        if (transform.position.y < -10)
        {
            transform.position = new Vector3(transform.position.x, 10);
        }
        //om den är mer än 10 så hamnar den på -10x
        if (transform.position.y > 10)
        {
            transform.position = new Vector3(transform.position.x,- 10);
        }
    }
}
