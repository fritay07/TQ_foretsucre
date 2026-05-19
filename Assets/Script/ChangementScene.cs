using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangementScene : MonoBehaviour
{
    public void ChargerSceneUn()
    {
        SceneManager.LoadScene("Niveau1");
    }
    public void ChargerProchain()
    {
        SceneManager.LoadScene("Niveau2");
    }
    public void ChargerAcceuil()
    {
        SceneManager.LoadScene("Acceuil");
    }

}