using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class EastEgg : MonoBehaviour
{
    public Image imageToShow;
    public float alpha = 0;
    public float speed = 1f;
    public AudioSource eastEggSFX;

    public void OnEnable()
    {
        // define o alpha em 0, chama o updatealpha e toca o SFX
        alpha = 0;
        UpdateAlpa();
        eastEggSFX.Play();
    }

    public void Update()
    {
        //Se o alpha for menor que 1
        if(alpha < 1)
        {
            //alpha será igual a ele mesmo mais a velocidade vezes o tempo, sendo limitado pelo mathf clamp01 entre 0 e 1, onde o objeto limitado será o meu alpha
            alpha += speed * Time.deltaTime;
            alpha = Mathf.Clamp01(alpha);
            UpdateAlpa();
        }
        else
        {
            enabled = false;
           
        }
    }
    

    public void UpdateAlpa()
    {
        // cria uma variavel chamada c que será igual a cor do meu objeto, assim sendo possivel alterar apenas o alpha do objeto
        var c = imageToShow.color;
        c.a = alpha;
        imageToShow.color = c;
    }
}
