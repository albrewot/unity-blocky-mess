using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{

    public SceneLoader sceneLoader;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Ball")) {
            sceneLoader.LoadGameOver();
        }
    }
}
