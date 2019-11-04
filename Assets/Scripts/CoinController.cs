using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public GameController gameController;
    private void OnCollisionEnter2D(Collision2D othertwo)
    {
        if (othertwo.gameObject.tag == "Player")
        {
            Debug.Log("Player is gettin that coin");
            gameController.score++;
            Destroy(this.gameObject);
        }
    }
}
