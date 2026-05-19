using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangementScene : MonoBehaviour
{
    public void ChargerSceneUn()
    {
        SceneManager.LoadScene("Niveau1");
    }
}