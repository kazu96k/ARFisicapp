using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIScripts4 : MonoBehaviour
{
    // Start is called before the first frame update

   

    //color
    public Material colorB, colorN, colorG, colorV;
    public GameObject obj1, obj2, obj3, obj4, obje0,obje1, obje2, obje3, obje4, obje5, obje6, obje7, obje8, obje9, obje10, obje11, obje12, obje13, obje14, obje15, obje16, obje17;
    public GameObject f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12;
    int i;

    
    //submenu
    public RectTransform subMenu;
    float posFinal;
    bool abrirMenu = true;
    public float tiempo = 0.5f;
    public Transform image1, image2;

    void Start()
    {
     
        posFinal = Screen.width / 2;
      
        i = 1;
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

    public void CambiarColor()
    {
      
            if (i == 1)
            {
            obj1.GetComponent<Renderer>().material = colorB;
            obj2.GetComponent<Renderer>().material = colorB;
            obj3.GetComponent<Renderer>().material = colorB;
            obj4.GetComponent<Renderer>().material = colorB;
            obje0.GetComponent<Renderer>().material = colorB;
            obje1.GetComponent<Renderer>().material = colorB;
            obje2.GetComponent<Renderer>().material = colorB;
            obje3.GetComponent<Renderer>().material = colorB;
            obje4.GetComponent<Renderer>().material = colorB;
            obje5.GetComponent<Renderer>().material = colorB;
            obje6.GetComponent<Renderer>().material = colorB;
            obje7.GetComponent<Renderer>().material = colorB;
            obje8.GetComponent<Renderer>().material = colorB;
            obje9.GetComponent<Renderer>().material = colorB;
            obje10.GetComponent<Renderer>().material = colorB;
            obje11.GetComponent<Renderer>().material = colorB;
            obje12.GetComponent<Renderer>().material = colorB;
            obje13.GetComponent<Renderer>().material = colorB;
            obje14.GetComponent<Renderer>().material = colorB;
            obje15.GetComponent<Renderer>().material = colorB;
            obje16.GetComponent<Renderer>().material = colorB;
            obje17.GetComponent<Renderer>().material = colorB;
            f1.GetComponent<Renderer>().material = colorB;
            f2.GetComponent<Renderer>().material = colorB;
            f3.GetComponent<Renderer>().material = colorB;
            f4.GetComponent<Renderer>().material = colorB;
            f5.GetComponent<Renderer>().material = colorB;
            f6.GetComponent<Renderer>().material = colorB;
            f7.GetComponent<Renderer>().material = colorB;
            f8.GetComponent<Renderer>().material = colorB;
            f9.GetComponent<Renderer>().material = colorB;
            f10.GetComponent<Renderer>().material = colorB;
            f11.GetComponent<Renderer>().material = colorB;
            f12.GetComponent<Renderer>().material = colorB;
            i = 2;
            }

            else if (i == 2)
            {
                obj1.GetComponent<Renderer>().material = colorN;
            obj2.GetComponent<Renderer>().material = colorN;
            obj3.GetComponent<Renderer>().material = colorN;
            obj4.GetComponent<Renderer>().material = colorN;
            obje0.GetComponent<Renderer>().material = colorN;
            obje1.GetComponent<Renderer>().material = colorN;
            obje2.GetComponent<Renderer>().material = colorN;
            obje3.GetComponent<Renderer>().material = colorN;
            obje4.GetComponent<Renderer>().material = colorN;
            obje5.GetComponent<Renderer>().material = colorN;
            obje6.GetComponent<Renderer>().material = colorN;
            obje7.GetComponent<Renderer>().material = colorN;
            obje8.GetComponent<Renderer>().material = colorN;
            obje9.GetComponent<Renderer>().material = colorN;
            obje10.GetComponent<Renderer>().material = colorN;
            obje11.GetComponent<Renderer>().material = colorN;
            obje12.GetComponent<Renderer>().material = colorN;
            obje13.GetComponent<Renderer>().material = colorN;
            obje14.GetComponent<Renderer>().material = colorN;
            obje15.GetComponent<Renderer>().material = colorN;
            obje16.GetComponent<Renderer>().material = colorN;
            obje17.GetComponent<Renderer>().material = colorN;
            f1.GetComponent<Renderer>().material = colorN;
            f2.GetComponent<Renderer>().material = colorN;
            f3.GetComponent<Renderer>().material = colorN;
            f4.GetComponent<Renderer>().material = colorN;
            f5.GetComponent<Renderer>().material = colorN;
            f6.GetComponent<Renderer>().material = colorN;
            f7.GetComponent<Renderer>().material = colorN;
            f8.GetComponent<Renderer>().material = colorN;
            f9.GetComponent<Renderer>().material = colorN;
            f10.GetComponent<Renderer>().material = colorN;
            f11.GetComponent<Renderer>().material = colorN;
            f12.GetComponent<Renderer>().material = colorN;
            i = 3;
            }
            else if (i == 3)
            {
                i = 4;
                obj1.GetComponent<Renderer>().material = colorV;
            obj2.GetComponent<Renderer>().material = colorV;
            obj3.GetComponent<Renderer>().material = colorV;
            obj4.GetComponent<Renderer>().material = colorV;
            obje0.GetComponent<Renderer>().material = colorV;
            obje1.GetComponent<Renderer>().material= colorV;
            obje2.GetComponent<Renderer>().material = colorV;
            obje3.GetComponent<Renderer>().material = colorV;
            obje4.GetComponent<Renderer>().material = colorV;
            obje5.GetComponent<Renderer>().material = colorV;
            obje6.GetComponent<Renderer>().material = colorV;
            obje7.GetComponent<Renderer>().material = colorV;
            obje8.GetComponent<Renderer>().material = colorV;
            obje9.GetComponent<Renderer>().material = colorV;
            obje10.GetComponent<Renderer>().material = colorV;
            obje11.GetComponent<Renderer>().material = colorV;
            obje12.GetComponent<Renderer>().material = colorV;
            obje13.GetComponent<Renderer>().material = colorV;
            obje14.GetComponent<Renderer>().material = colorV;
            obje15.GetComponent<Renderer>().material = colorV;
            obje16.GetComponent<Renderer>().material = colorV;
            obje17.GetComponent<Renderer>().material = colorV;

            f1.GetComponent<Renderer>().material = colorV;
            f2.GetComponent<Renderer>().material = colorV;
            f3.GetComponent<Renderer>().material = colorV;
            f4.GetComponent<Renderer>().material = colorV;
            f5.GetComponent<Renderer>().material = colorV;
            f6.GetComponent<Renderer>().material = colorV;
            f7.GetComponent<Renderer>().material = colorV;
            f8.GetComponent<Renderer>().material = colorV;
            f9.GetComponent<Renderer>().material = colorV;
            f10.GetComponent<Renderer>().material = colorV;
            f11.GetComponent<Renderer>().material = colorV;

            f12.GetComponent<Renderer>().material = colorV;
        }
            else
            {
                obj1.GetComponent<Renderer>().material = colorG;
            obj2.GetComponent<Renderer>().material = colorG;
            obj3.GetComponent<Renderer>().material = colorG;
            obj4.GetComponent<Renderer>().material = colorG;
            obje0.GetComponent<Renderer>().material = colorG;
            obje1.GetComponent<Renderer>().material = colorG;
            obje2.GetComponent<Renderer>().material = colorG;
            obje3.GetComponent<Renderer>().material = colorG;
            obje4.GetComponent<Renderer>().material = colorG;
            obje5.GetComponent<Renderer>().material = colorG;
            obje6.GetComponent<Renderer>().material = colorG;
            obje7.GetComponent<Renderer>().material = colorG;
            obje8.GetComponent<Renderer>().material = colorG;
            obje9.GetComponent<Renderer>().material = colorG;
            obje10.GetComponent<Renderer>().material = colorG;
            obje11.GetComponent<Renderer>().material = colorG;
            obje12.GetComponent<Renderer>().material = colorG;
            obje13.GetComponent<Renderer>().material = colorG;
            obje14.GetComponent<Renderer>().material = colorG;
            obje15.GetComponent<Renderer>().material = colorG;
            obje16.GetComponent<Renderer>().material = colorG;
            obje17.GetComponent<Renderer>().material = colorG;
            i = 1;
            f1.GetComponent<Renderer>().material = colorG;
            f2.GetComponent<Renderer>().material = colorG;
            f3.GetComponent<Renderer>().material = colorG;
            f4.GetComponent<Renderer>().material = colorG;
            f5.GetComponent<Renderer>().material = colorG;
            f6.GetComponent<Renderer>().material = colorG;
            f7.GetComponent<Renderer>().material = colorG;
            f8.GetComponent<Renderer>().material = colorG;
            f9.GetComponent<Renderer>().material = colorG;
            f10.GetComponent<Renderer>().material = colorG;
            f11.GetComponent<Renderer>().material = colorG;
            f12.GetComponent<Renderer>().material = colorG;

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



