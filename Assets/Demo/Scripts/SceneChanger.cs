using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private KeyCode sceneChangeKey = KeyCode.A;
    [SerializeField] private string destinationSceneName = "";

    private void Update()
    {
        if (Input.GetKeyDown(sceneChangeKey))
        {
            SceneManager.LoadScene(destinationSceneName);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
