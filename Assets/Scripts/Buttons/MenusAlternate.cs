using UnityEngine;

public class MenusAlternate : MonoBehaviour
{
    public GameObject menuToShow;
    public GameObject menuHide;


    public void PressToShow()
    {
        menuToShow.SetActive(true);

        Invoke("PressToHide", 0.1f);
    }

    public void PressToHide()
    {
        menuHide.SetActive(false);
    }
}
