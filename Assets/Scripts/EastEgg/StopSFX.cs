using UnityEngine;

public class StopSFX : MonoBehaviour
{
    public GameObject easterEGG;
    public AudioSource AudioSource;

    // Update is called once per frame
    void Update()
    {
        //verifica se o objeto est� ativo, necess�rio pesquisar mais sobre o activeself
        if(!easterEGG.activeSelf)
        {
            AudioSource.Stop();
        }
    }
}
