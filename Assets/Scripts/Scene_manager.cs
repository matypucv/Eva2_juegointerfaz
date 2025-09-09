using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_manager : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            restartscene();
        }
    }
    public void restartscene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void changescene(string name_scene)
    {
        SceneManager.LoadScene(name_scene);
    }
}
