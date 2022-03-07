/*
 * Created by: Jason Alfrey
 * Created date: 3/1/2022
 * Edited date: 3/6/2022
 * 
 * Description: This file contains the code logic to detect 
 * whether all of the blocks are inside the requisite bounds.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    BoxCollider bc;
    List<Collider> overlaySquares = new List<Collider>();
    // Start is called before the first frame update
    void Start()
    {
        bc = this.GetComponent<BoxCollider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        overlaySquares.Clear();
    }
}
