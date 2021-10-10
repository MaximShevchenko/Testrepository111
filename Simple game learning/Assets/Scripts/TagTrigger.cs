using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

    public class TagTrigger : MonoBehaviour
{
    [SerializeField] private PlayerMovement movement;
    public GameManager cubeTrigger;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tags.PLAYER))
        {
            cubeTrigger.CompliteLevel();
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(Tags.OBSTACLE))
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
    
