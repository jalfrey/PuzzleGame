/*
 * Created by: Jason Alfrey
 * Created date: 3/1/2022
 * Edited date: 3/6/2022
 * 
 * Description: Manages the buttons on the home screen
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class UI : MonoBehaviour
{
    public string sceneID;
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneID);
    }
}
