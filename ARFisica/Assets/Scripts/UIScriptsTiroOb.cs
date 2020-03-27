using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIScriptsTiroOb : MonoBehaviour
{
    public Material colorB, colorN, colorG, colorV;
    public LineRenderer lineRender;
    public GameObject obj0, obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13;
    int i;
    // Start is called before the first frame update
    public RectTransform subMenu;
    float posFinal;
    bool abrirMenu = true;
    public float tiempo = 0.5f;
    public Transform image1, image2;
    void Start()
    {
        i = 1;
        posFinal = Screen.width / 2;
        subMenu.position = new Vector3(-posFinal, subMenu.position.y, 0);
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

    public void CambioColorBlanco()
    {
        if (i == 1)
        {
            lineRender.GetComponent<LineRenderer>().material = colorB;
            obj0.GetComponent<Renderer>().material = colorB;
            obj1.GetComponent<Renderer>().material = colorB;
            obj2.GetComponent<Renderer>().material = colorB;
            obj3.GetComponent<Renderer>().material = colorB;
            obj4.GetComponent<Renderer>().material = colorB;
            obj9.GetComponent<Renderer>().material = colorB;
            obj5.GetComponent<Renderer>().material = colorB;
            obj6.GetComponent<Renderer>().material = colorB;
            obj7.GetComponent<Renderer>().material = colorB;
            obj8.GetComponent<Renderer>().material = colorB;
            obj10.GetComponent<Renderer>().material = colorB;
            obj11.GetComponent<Renderer>().material = colorB;
            obj12.GetComponent<Renderer>().material = colorB;
            obj13.GetComponent<Renderer>().material = colorB;
            i = 2;
        }

        else if (i == 2)
        {

            lineRender.GetComponent<LineRenderer>().material = colorN;
            i = 3;
            obj0.GetComponent<Renderer>().material = colorN;
            obj1.GetComponent<Renderer>().material = colorN;
            obj2.GetComponent<Renderer>().material = colorN;
            obj3.GetComponent<Renderer>().material = colorN;
            obj4.GetComponent<Renderer>().material = colorN;
            obj5.GetComponent<Renderer>().material = colorN;
            obj6.GetComponent<Renderer>().material = colorN;
            obj7.GetComponent<Renderer>().material = colorN;
            obj8.GetComponent<Renderer>().material = colorN;
            obj9.GetComponent<Renderer>().material = colorN;
            obj10.GetComponent<Renderer>().material = colorN;
            obj11.GetComponent<Renderer>().material = colorN;
            obj12.GetComponent<Renderer>().material = colorN;
            obj13.GetComponent<Renderer>().material = colorN;
        }
        else if(i==3){
            lineRender.GetComponent<LineRenderer>().material = colorV;
            obj0.GetComponent<Renderer>().material = colorV;
            obj1.GetComponent<Renderer>().material = colorV;
            obj2.GetComponent<Renderer>().material = colorV;
            obj3.GetComponent<Renderer>().material = colorV;
            obj4.GetComponent<Renderer>().material = colorV;
            obj5.GetComponent<Renderer>().material = colorV;
            obj6.GetComponent<Renderer>().material = colorV;
            obj7.GetComponent<Renderer>().material = colorV;
            obj8.GetComponent<Renderer>().material = colorV;
            obj9.GetComponent<Renderer>().material = colorV;
            obj10.GetComponent<Renderer>().material = colorV;
            obj11.GetComponent<Renderer>().material = colorV;
            obj12.GetComponent<Renderer>().material = colorV;
            obj13.GetComponent<Renderer>().material = colorV;
            i = 4;
        }
        else
        {

            lineRender.GetComponent<LineRenderer>().material = colorG;
            obj0.GetComponent<Renderer>().material = colorG;
            obj1.GetComponent<Renderer>().material = colorG;
            obj2.GetComponent<Renderer>().material = colorG;
            obj3.GetComponent<Renderer>().material = colorG;
            obj4.GetComponent<Renderer>().material = colorG;
            obj5.GetComponent<Renderer>().material = colorG;
            obj6.GetComponent<Renderer>().material = colorG;
            obj7.GetComponent<Renderer>().material = colorG;
            obj8.GetComponent<Renderer>().material = colorG;
            obj9.GetComponent<Renderer>().material = colorG;
            obj10.GetComponent<Renderer>().material = colorG;
            obj11.GetComponent<Renderer>().material = colorG;
            obj12.GetComponent<Renderer>().material = colorG;
            obj13.GetComponent<Renderer>().material = colorG;
            i = 1;
        }

    }
}
