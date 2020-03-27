using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SubmenuOnly : MonoBehaviour
{
    

    public RectTransform subMenu;
    float posFinal;
    bool abrirMenu = true;
    public float tiempo = 0.5f;
    public Transform image1, image2;

    void Start()
    {
      


        posFinal = Screen.width / 2;
        subMenu.position = new Vector3(-posFinal, subMenu.position.y , 0);



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Mover(float time, Vector3 posInit, Vector3 posFin)
    {
        float elapsedTime = 0;
        while (elapsedTime < time)
        {
            subMenu.position = Vector3.Lerp(posInit, posFin, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        subMenu.position = posFin;

    }
    void MoverMenu(float time, Vector3 posInit, Vector3 posFin)
    {

        StartCoroutine(Mover(time, posInit, posFin));

    }


    public void buttonSubMenu()
    {
        int signo = 1;
        if (!abrirMenu)
            signo = -1;

        MoverMenu(tiempo, subMenu.position, new Vector3(signo * posFinal, subMenu.position.y, 0));
        abrirMenu = !abrirMenu;

        if (signo == 1)
        {
            image1.gameObject.SetActive(false);
            image2.gameObject.SetActive(true);
        }
        else
        {
            image1.gameObject.SetActive(true);
            image2.gameObject.SetActive(false);

        }

    }
    public void CambiarScene()
    {
        SceneManager.LoadScene("ARImgTFG");
    }
    public void CambiarSceneHome()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
    public void CambiarSceneGP()
    {
        SceneManager.LoadScene("GroupPlaneScene");
    }
}
