
using System.Reflection.Emit;
using System.Security.AccessControl;
using UnityEngine;

public class playertype2 : MonoBehaviour
{
    public Player1Movement movement;
    
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "GameObject") 
        {
        movement.enabled = false; 
        FindObjectOfType<gamemanager>().EndGame();}
        
    }
}
