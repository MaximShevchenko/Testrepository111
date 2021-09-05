
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameManager cubeTrigger;

    public void OnTriggerEnter()
    {
        cubeTrigger.CompliteLevel();
    }


}
