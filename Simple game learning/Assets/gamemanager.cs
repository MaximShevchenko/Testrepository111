
using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour
{
     bool GameHasEnd = false;
    public void EndGame()
    {
        if (GameHasEnd == false)
        {
            GameHasEnd = true;
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}