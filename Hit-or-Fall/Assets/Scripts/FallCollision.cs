using UnityEngine;

public class FallCollision : MonoBehaviour
{   // This script detects whether or not the main camera and the falling object have collided.
    public GameObject game;
    public GameObject mainMenu;
    public GameObject fallingObject;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Main Camera")
        {
            game.SetActive(false);
            mainMenu.SetActive(true);
            fallingObject.transform.position = new Vector3(-1f, 100f, 0f);
        }
    }

}
