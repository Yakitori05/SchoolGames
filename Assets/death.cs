using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        var player = other.collider.GetComponent<PlayerControler>();
        var Sscreen = GetComponent<Startscreen>();
        if (player != null)
        {
            player.Die();
            Sscreen.died();
        }
    }
}
