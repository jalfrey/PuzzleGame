/*
 * Created by: Jason Alfrey
 * Created date: 3/1/2022
 * Edited date: 3/7/2022
 * 
 * Description: Counts the number of actions for the user
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionCounter : MonoBehaviour
{
    public Text actionCountTag;
    // Update is called once per frame
    void Update()
    {
        actionCountTag.text = "Number of Moves: " + InputHanlder.actionCount;
    }
}
