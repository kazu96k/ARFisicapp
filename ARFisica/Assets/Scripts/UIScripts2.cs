using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIScripts2 : MonoBehaviour
{
    // Start is called before the first frame update

    //pausa y cambiar
    public GameObject pausa, resume;
    public Transform model1;
    public Animator animator1;

    //color
    public Material colorB, colorN, colorG, colorV;
    public GameObject obj1, obj2;
    int i;

    //slider
    public Slider slider;
    public Text TextSpeedValue;
    float value;
    //submenu
    public RectTransform subMenu;
    float posFinal;
    bool abrirMenu = true;
    public float tiempo = 0.5f;
    public Transform image1, image2;

    void Start()
    {
        animator1 = model1.GetComponent<Animator>();
        posFinal = Screen.width / 2;
        resume.SetActive(false);
        i = 1;
        subMenu.position = new Vector3(-posFinal, subMenu.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Speed()
    {
        animator1.speed = slider.value;
        value = 3- slider.value;
        TextSpeedValue.text = "Fr: "+ value.ToString("F");

    }

    public void PauseAnim() {

        if (animator1.speed == 1)
        {
            animator1.speed = 0;
            resume.SetActive(true);
            pausa.SetActive(false);

        }
        else 
        {
            animator1.speed = 1;
            resume.SetActive(false);
            pausa.SetActive(true);
        }



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

    public void CambiarColor()
    {
      
            if (i == 1)
            {
                obj1.GetComponent<Renderer>().material = colorB;
            obj2.GetComponent<Renderer>().material = colorB;
            i = 2;
            }

            else if (i == 2)
            {
                obj1.GetComponent<Renderer>().material = colorN;
            obj2.GetComponent<Renderer>().material = colorN;
            i = 3;
            }
            else if (i == 3)
            {
                i = 4;
                obj1.GetComponent<Renderer>().material = colorV;
            obj2.GetComponent<Renderer>().material = colorV;
        }
            else
            {
                obj1.GetComponent<Renderer>().material = colorG;
            obj2.GetComponent<Renderer>().material = colorG;
            i = 1;
            }
        
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











}



