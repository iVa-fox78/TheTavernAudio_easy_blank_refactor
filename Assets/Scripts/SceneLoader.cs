using UnityEngine;
using UnityEngine.SceneManagement; //Doing smth with scene


public class SceneLoader : MonoBehaviour
{
    [Header("Scene")] //Choose an object
    [SerializeField] private Object Scene; //Provide to the Obj

    public void LoadScene()
    {
        if (Scene != null)
        {
            SceneManager.LoadScene(Scene.name);
        }
        else
        {
            Debug.LogError("Scene are not sighned");
        }
    }

}
