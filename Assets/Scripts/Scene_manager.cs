using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_manager : MonoBehaviour
{
    //public Animator animator;
    private void Update()
    {
        //animator.Play("fade_out");
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

    public void transicionar(string name)
    {
        //animator.Play("fade_in");
        
    }
    
}
