using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class EastEgg : MonoBehaviour
{
    public Image imageToShow; 
    public float alpha = 0;
    public AudioSource audioSource;
    public void Update()
    {
        Color c = imageToShow.color; 
        c.a = alpha; 
        imageToShow.color = c; 
        
        if (imageToShow != null) 
        { 
            alpha += 1.1f * 1.1f * Time.deltaTime;
            audioSource.Play();
        }
    }
}
