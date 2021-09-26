using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    private const string PLAYER = "Player";
    public GameManager cubeTrigger;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(PLAYER))
        {
            cubeTrigger.CompliteLevel();
        }
    }
}