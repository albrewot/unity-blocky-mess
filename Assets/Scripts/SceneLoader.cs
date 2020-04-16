using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene() {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        GoToScene(currentSceneIndex + 1);
    }

    public void LoadStartScreen() {
        GoToScene(0);
    }

    public void LoadGameOver() {
        SceneManager.LoadScene("Game Over");
    }

    public void QuitGame() {
        Application.Quit();
    }

    private void GoToScene(int index) {
        SceneManager.LoadScene(index);
    }
}
