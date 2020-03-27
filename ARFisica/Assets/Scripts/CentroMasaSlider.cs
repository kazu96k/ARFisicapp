using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CentroMasaSlider : MonoBehaviour
{
    //CM
    public Slider sliderx1, slidery1, sliderx2, slidery2, sliderx3, slidery3, sliderm1, sliderm2, sliderm3;
    public Transform modelo1, modelo2, modelo3, cm;
    public Text m1, tx1, ty1, m2, tx2, ty2, m3, tx3, ty3,t4;
    public TextMesh masa1, masa2, masa3, masacm;
    //SUBMENUCM
    public RectTransform subMenu,subMenu2;
    public GameObject obj,obj2;
    float posFinal;
    bool abrirMenu = true;
    public float tiempo = 0.5f;
    public Transform image1, image2, img1,img2;
    // Start is called before the first frame update
    public Material colorB, colorN, colorG, colorV;
    public GameObject obje0, obje1, obje2, obje3, obje4, obje5, obje6, obje7, obje8, obje9, obje10, obje11, obje12, obje13, obje14, obje15, obje16, obje17, obje18, obje19, obje20;
    int i;

    void Start()
    {
        m1.text = "Masa1: "+sliderm1.value.ToString("F");
        tx1.text ="X1: " + sliderx1.value.ToString("F");
        ty1.text = "Y1: "+slidery1.value.ToString("F");
        m2.text = "Masa2: "+sliderm2.value.ToString("F");
        tx2.text = "X2: " + sliderx2.value.ToString("F");
        ty2.text = "Y2: " + slidery2.value.ToString("F");
        m3.text = "Masa3: "+sliderm3.value.ToString("F");
        tx3.text = "X3: " + sliderx3.value.ToString("F");
        ty3.text = "Y3: " + slidery3.value.ToString("F");
        i = 1;
        t4.text = "(CMX: 0 , CMY: 0)";
      
        posFinal = Screen.width/2;
        subMenu.position = new Vector3(-posFinal, subMenu.position.y, 0);
        subMenu2.position = new Vector3(-posFinal, subMenu.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CambiarColor()
    {
       if (i == 1)
            {
                obje0.GetComponent<Renderer>().material = colorB;
                obje1.GetComponent<Renderer>().material = colorB;
                obje2.GetComponent<Renderer>().material = colorB;
                obje3.GetComponent<Renderer>().material = colorB;
                obje4.GetComponent<Renderer>().material = colorB;
                obje9.GetComponent<Renderer>().material = colorB;
                obje5.GetComponent<Renderer>().material = colorB;
                obje6.GetComponent<Renderer>().material = colorB;
                obje7.GetComponent<Renderer>().material = colorB;
                obje8.GetComponent<Renderer>().material = colorB;
                obje10.GetComponent<Renderer>().material = colorB;
                obje11.GetComponent<Renderer>().material = colorB;
                obje12.GetComponent<Renderer>().material = colorB;
                obje13.GetComponent<Renderer>().material = colorB;
                obje14.GetComponent<Renderer>().material = colorB;
                obje19.GetComponent<Renderer>().material = colorB;
                obje15.GetComponent<Renderer>().material = colorB;
                obje16.GetComponent<Renderer>().material = colorB;
                obje17.GetComponent<Renderer>().material = colorB;
                obje18.GetComponent<Renderer>().material = colorB;
                
                i = 2;
            }

            else if (i == 2)
            {
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
                obje18.GetComponent<Renderer>().material = colorN;
                obje19.GetComponent<Renderer>().material = colorN;
                obje20.GetComponent<Renderer>().material = colorN;
               
                i = 3;
            }
            else if (i == 3)
            {
                i = 4;
                obje0.GetComponent<Renderer>().material = colorV;
                obje1.GetComponent<Renderer>().material = colorV;
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
                obje18.GetComponent<Renderer>().material = colorV;
                obje19.GetComponent<Renderer>().material = colorV;
                obje20.GetComponent<Renderer>().material = colorV;
                            
            }
            else
            {
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
                obje18.GetComponent<Renderer>().material = colorG;
                obje19.GetComponent<Renderer>().material = colorG;
                obje20.GetComponent<Renderer>().material = colorG;
                
                i = 1;
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



    public void buttonSubMenu()
    {
        int signo = 1;
        if (!abrirMenu)
            signo = -1;

        MoverMenu(tiempo, subMenu.position, new Vector3(signo * posFinal, subMenu.position.y, 0));
        abrirMenu = !abrirMenu;

        if (signo == 1)
        {
            obj.SetActive(false);
            image1.gameObject.SetActive(false);
            image2.gameObject.SetActive(true);
        }
        else
        {
            obj.SetActive(true);
            image1.gameObject.SetActive(true);
            image2.gameObject.SetActive(false);

        }

    }
    public void buttonSubMenuF()
    {
        
        int signo = 1;
        if (!abrirMenu)
            signo = -1;

        MoverMenu2(tiempo, subMenu2.position, new Vector3(signo * posFinal, subMenu2.position.y, 0));
        abrirMenu = !abrirMenu;

        if (signo == 1)
        {
            obj2.SetActive(false);
            t4.gameObject.SetActive(false);
            img1.gameObject.SetActive(false);
            img2.gameObject.SetActive(true);
        }
        else
        {
            obj2.SetActive(true);
            t4.gameObject.SetActive(true);
            img1.gameObject.SetActive(true);
            img2.gameObject.SetActive(false);

        }

    }

    IEnumerator Mover2(float time, Vector3 posInit, Vector3 posFin)
    {
        float elapsedTime = 0;
        while (elapsedTime < time)
        {
            subMenu2.position = Vector3.Lerp(posInit, posFin, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        subMenu2.position = posFin;

    }
    void MoverMenu2(float time, Vector3 posInit, Vector3 posFin)
    {

        StartCoroutine(Mover2(time, posInit, posFin));

    }

    public void moverm()//escalar masa
    {
        if (sliderm1.value > 0 || sliderm2.value > 0 || sliderm3.value>0) {
            float cmsx = (modelo1.localPosition.x * sliderm1.value + modelo2.localPosition.x * sliderm2.value + modelo3.localPosition.x * sliderm3.value) / (sliderm1.value + sliderm2.value + sliderm3.value);
            float cmsy = (modelo1.localPosition.z * sliderm1.value + modelo2.localPosition.z * sliderm2.value + modelo3.localPosition.z * sliderm3.value) / (sliderm1.value + sliderm2.value + sliderm3.value);
            cm.localPosition = new Vector3(cmsx, 0, cmsy);
            modelo1.localScale = new Vector3(sliderm1.value, sliderm1.value, sliderm1.value);
            modelo2.localScale = new Vector3(sliderm2.value, sliderm2.value, sliderm2.value);
            modelo3.localScale = new Vector3(sliderm3.value, sliderm3.value, sliderm3.value);
            TextEsc(cmsx, cmsy);
        }
       
    }


    public void moverX1()
    {
        if (sliderm1.value > 0 || sliderm2.value > 0 || sliderm3.value > 0)
        {
            modelo1.localPosition = new Vector3(sliderx1.value, 0, modelo1.localPosition.z);
            float cms = (sliderx1.value * sliderm1.value + modelo2.localPosition.x * sliderm2.value + modelo3.localPosition.x * sliderm3.value) / (sliderm1.value + sliderm2.value + sliderm3.value);// falta la masa
            cm.localPosition = new Vector3(cms, 0, cm.localPosition.z);
            TextEsc(cms, cm.localPosition.z);
        }
            
    }

    public void moverY1()
    {

        if (sliderm1.value > 0 || sliderm2.value > 0 || sliderm3.value > 0)
        {
            modelo1.localPosition = new Vector3(modelo1.localPosition.x, 0, slidery1.value);

            float cms = (slidery1.value * sliderm1.value + modelo2.localPosition.z * sliderm2.value + modelo3.localPosition.z * sliderm3.value) / (sliderm1.value + sliderm2.value + sliderm3.value);
            cm.localPosition = new Vector3(cm.localPosition.x, 0, cms);
            TextEsc(cm.localPosition.x, cms);
        }
    }

    public void moverX2()
    {

        if (sliderm1.value > 0 || sliderm2.value > 0 || sliderm3.value > 0)
        {
            modelo2.localPosition = new Vector3(sliderx2.value, 0, modelo2.localPosition.z);
            float cms = (sliderx2.value * sliderm2.value + modelo1.localPosition.x * sliderm1.value + modelo3.localPosition.x * sliderm3.value) / (sliderm1.value + sliderm2.value + sliderm3.value);
            cm.localPosition = new Vector3(cms, 0, cm.localPosition.z);
            TextEsc(cms, cm.localPosition.z);
        }

    }
    public void moverY2()
    {

        if (sliderm1.value > 0 || sliderm2.value > 0 || sliderm3.value > 0)
        {
            modelo2.localPosition = new Vector3(modelo2.localPosition.x, 0, slidery2.value);
            float cms = (slidery2.value * sliderm2.value + modelo1.localPosition.z * sliderm1.value + modelo3.localPosition.z * sliderm3.value) / (sliderm1.value + sliderm2.value + sliderm3.value);
            cm.localPosition = new Vector3(cm.localPosition.x, 0, cms);
            TextEsc(cm.localPosition.x, cms);
        }
    }

    public void moverX3()
    {

        if (sliderm1.value > 0 || sliderm2.value > 0 || sliderm3.value > 0)
        {
            modelo3.localPosition = new Vector3(sliderx3.value, 0, modelo3.localPosition.z);
            float cms = (sliderx3.value * sliderm3.value + modelo2.localPosition.x * sliderm2.value + modelo1.localPosition.x * sliderm1.value) / (sliderm1.value + sliderm2.value + sliderm3.value);
            cm.localPosition = new Vector3(cms, 0, cm.localPosition.z);
            TextEsc(cms, cm.localPosition.z);
        }
    }
    public void moverY3()
    {
        if (sliderm1.value > 0 || sliderm2.value > 0 || sliderm3.value > 0)
        {
            modelo3.localPosition = new Vector3(modelo3.localPosition.x, 0, slidery3.value);
            float cms = (slidery3.value * sliderm3.value + modelo2.localPosition.z * sliderm2.value + modelo1.localPosition.z * sliderm1.value) / (sliderm1.value + sliderm2.value + sliderm3.value);
            cm.localPosition = new Vector3(cm.localPosition.x, 0, cms);
            TextEsc(cm.localPosition.x, cms);
        }
    }

    public void TextEsc(float a, float b) {
        m1.text = "Masa1: "+sliderm1.value.ToString("F");
       
        tx1.text = "X1: " + sliderx1.value.ToString("F");
        ty1.text = "Y1: " + slidery1.value.ToString("F");
        m2.text = "Masa2:" + sliderm2.value.ToString("F");
        tx2.text = "X2: "+ sliderx2.value.ToString("F");
        ty2.text = "Y2: " + slidery2.value.ToString("F");
        m3.text =  "Masa3: "+sliderm3.value.ToString("F");
        tx3.text = "X3: " + sliderx3.value.ToString("F");
        ty3.text = "Y3: "  + slidery3.value.ToString("F");

        t4.text = "(CMX = " + a.ToString("F") + ", CMY = "+ b.ToString("F") +")";


        masa1.text = "M1:" + sliderm1.value.ToString("F") + " (" + sliderx1.value.ToString("F") + "," + slidery1.value.ToString("F") + ")";
        masa2.text = "M2:" + sliderm2.value.ToString("F") + " (" + sliderx2.value.ToString("F") + "," + slidery2.value.ToString("F") + ")";
        masa3.text = "M3:" + sliderm3.value.ToString("F") + " (" + sliderx3.value.ToString("F") + "," + slidery3.value.ToString("F") + ")";
        masacm.text = "(CMX = " + a.ToString("F") + ", CMY = " + b.ToString("F") + ")";




    }


}
