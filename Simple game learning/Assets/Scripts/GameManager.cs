
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
     bool GameHasEnd = false;
     public GameObject compliteLevelUI;
     
     public void  CompliteLevel()
     {
         compliteLevelUI.SetActive(true);
         Debug.Log("level won");
     }

     public float restartDelay = 1f;
     public void EndGame()
    {
        if (GameHasEnd == false)
        {
            GameHasEnd = true;
            Restart();
            Invoke("Restart",restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}