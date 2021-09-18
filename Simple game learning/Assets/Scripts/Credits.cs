using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Debug;

public class Credits : MonoBehaviour
{
    public void Quit()
    {   Debug.Log("QUIT");
        Application.Quit();
    }
}
