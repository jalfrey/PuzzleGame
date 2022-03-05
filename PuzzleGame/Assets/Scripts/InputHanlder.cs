using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHanlder : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 200;
    Vector3 cellTransform = new Vector3(0, 200, 0);


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rb.AddForce(cellTransform);
            cellTransform = -cellTransform;
        }
}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("BoundingBox"))
        {
            this.rb.velocity = Vector3.zero;
        }
        Debug.Log("collision");
    }
}
