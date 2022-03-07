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
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    BoxCollider bc;
    List<Collider> overlaySquares = new List<Collider>();
    int numCollisions;
    int numCells;

    private Scene scene;
    public static bool levelOneCompleted;
    public static bool levelTwoCompleted;

    // Start is called before the first frame update
    void Start()
    {
        bc = this.GetComponent<BoxCollider>();
        numCells = GameObject.FindGameObjectsWithTag("Cell").Length;
        numCollisions = 0;
        scene = SceneManager.GetActiveScene();
        levelTwoCompleted = levelOneCompleted = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Cell")
        {
            numCollisions++;
        }

        if (numCollisions == numCells)
        {
            if(scene.Equals("LevelOne"))
            {
                levelOneCompleted = true;
            }
            if (scene.Equals("LevelTwo"))
            {
                levelTwoCompleted = true;
            }

            //levelCompleteTag.text = "Level Complete!";
            SceneManager.LoadScene("SceneUI");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Cell")
        {
            numCollisions--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("SceneUI");
        }
    }

    private void FixedUpdate()
    {
        overlaySquares.Clear();
    }
}
