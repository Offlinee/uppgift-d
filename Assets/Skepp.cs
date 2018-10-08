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
    {
		
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

    }
}
