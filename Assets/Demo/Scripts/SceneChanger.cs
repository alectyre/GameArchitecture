using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private KeyCode sceneChangeKey;
    [SerializeField] private string destinationSceneName;



    private void Update()
    {
        if (Input.GetKeyDown(sceneChangeKey))
        {
            SceneManager.LoadScene(destinationSceneName);
        }
    }
}
