/*
 * Created by: Jason Alfrey
 * Created date: 3/1/2022
 * Edited date: 3/6/2022
 * 
 * Description: Handles clicks for each object 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InputHanlder : MonoBehaviour
{
    public string direction;
    Rigidbody rb;
    public static float speed = 400;
    Vector3 verticalTransform = new Vector3(0, speed, 0);
    Vector3 horizontalTransform = new Vector3(speed, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("BoundingBox") 
            || collision.gameObject.CompareTag("Cell"))
        {
            this.rb.velocity = Vector3.zero;
        }
        Debug.Log("collision");
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (direction.Equals("vertical"))
            {
                this.rb.AddForce(verticalTransform);
                verticalTransform = -verticalTransform;
            }
            else if (direction.Equals("horizontal"))
            {
                this.rb.AddForce(horizontalTransform);
                horizontalTransform = -horizontalTransform;
            }
        }
    }
}

