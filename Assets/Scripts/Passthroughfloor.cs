using SupanthaPaul;
using UnityEngine;
//using UnityEngine.InputSystem;

public class Passthroughfloor : MonoBehaviour
{
    public PlayerController controller;

    // This script controlers the player's ablity to fall through certain platforms
    // Using tags certain game assest can be given the "Drop" tag allowing a fall through action
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Drop"))
        {
            Debug.Log("Touched");
        }
    }

    public void Start() 
    {
        controller = this.GetComponent<PlayerController>();
    }

    // When the player is touching the collider of a gameobject with the "Drop" tag
    // and then presses the down/S key they fall through the game object by turnming off it collider
    /*private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Drop")) 
        {
            Debug.Log("Still Touching");
        }
        //other.gameObject.CompareTag("Drop") &&
        if ( InputSystem.Drop())
        {
            Debug.Log("Down Pressed while touching");
        }
    } */

    private void LateUpdate ()
    {
        if (controller.isGrounded && InputSystem.Drop()) 
        {
            Debug.Log("Down Pressed while touching");
        }


    }
}
