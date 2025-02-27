using UnityEngine;

public class ForFunReloadSceneMono : MonoBehaviour
{

    [ContextMenu("Reload current scene")]
    public void ReloadCurrentScene() {

        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
