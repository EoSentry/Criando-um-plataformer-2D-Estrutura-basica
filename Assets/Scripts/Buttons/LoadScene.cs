using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadSceneGame(int i)
    {
        SceneManager.LoadScene(i);
    }

    public void LoadSceneGame(string s)
    {
        SceneManager.LoadScene(s);
    }

}
