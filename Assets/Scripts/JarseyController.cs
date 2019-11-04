using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JarseyController : MonoBehaviour
{
    //Jersey Dude Controller
    public SpriteRenderer jerseyDudeRenderer;
    public GameObject player;
    public Transform checkpoint;
    public GameController gameController;
    private void OnCollisionEnter2D(Collision2D otherthree)
    {
        if (otherthree.gameObject.tag == "Player")
        {
            Debug.Log("Player just got fuckin slapped");
            gameController.score--;
            otherthree.gameObject.transform.position = checkpoint.position;
        }
    }
}
