
using System.Reflection.Emit;
using System.Security.AccessControl;
using UnityEngine;

public class OnColisionPlayer : MonoBehaviour
{
    public PlayerMovement movement;
    
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "GameObject") 
        {
        movement.enabled = false; 
        FindObjectOfType<GameManager>().EndGame();}
        
    }
}
