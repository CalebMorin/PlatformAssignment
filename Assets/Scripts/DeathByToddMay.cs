using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathByToddMay : MonoBehaviour
{
    public GameObject player;
    public Transform checkpoint;
    public void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Player is in the drink");
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = checkpoint.position;
        }
    }
}
