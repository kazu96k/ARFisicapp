using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScripts5 : MonoBehaviour
{
    //pausa y cambiar
    public GameObject pausa, resume;
    public Transform model1, model2;
    public Animator animator1, animator2;
    public Transform txtCambio;

    //color
    public Material colorB, colorN, colorG, colorV;
    public GameObject obj0, obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8,obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16, obj17, obj18, obj19, obj20, obj21, obj22;
    public GameObject obje0, obje1, obje2, obje3, obje4, obje5, obje6, obje7, obje8,obje9, obje10, obje11, obje12, obje13, obje14, obje15, obje16, obje17, obje18, obje19, obje20, obje21, obje22, obj23;
    int i;
    // Start is called before the first frame update

    public RectTransform subMenu;
    float posFinal;
    bool abrirMenu = true;
    public float tiempo = 0.5f;
    public Transform image1, image2;

    void Start()
    {
        model1.gameObject.SetActive(true);
        model2.gameObject.SetActive(false);
        animator1 = model1.GetComponent<Animator>();
        animator2 = model2.GetComponent<Animator>();
        animator2.speed = 0;
        
        resume.SetActive(false);
        i = 1;


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
    public void CambiarColor() {
        if (model1.gameObject.activeSelf)
        {
            if (i == 1)
            {
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
                obj14.GetComponent<Renderer>().material = colorB;
                obj19.GetComponent<Renderer>().material = colorB;
                obj15.GetComponent<Renderer>().material = colorB;
                obj16.GetComponent<Renderer>().material = colorB;
                obj17.GetComponent<Renderer>().material = colorB;
                obj18.GetComponent<Renderer>().material = colorB;
                obj19.GetComponent<Renderer>().material = colorB;
                obj20.GetComponent<Renderer>().material = colorB;
                obj21.GetComponent<Renderer>().material = colorB;
                obj22.GetComponent<Renderer>().material = colorB;
                i = 2;
            }

            else if (i == 2)
            {
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
                obj14.GetComponent<Renderer>().material = colorN;
                obj19.GetComponent<Renderer>().material = colorN;
                obj15.GetComponent<Renderer>().material = colorN;
                obj16.GetComponent<Renderer>().material = colorN;
                obj17.GetComponent<Renderer>().material = colorN;
                obj18.GetComponent<Renderer>().material = colorN;
                obj19.GetComponent<Renderer>().material = colorN;
                obj20.GetComponent<Renderer>().material = colorN;
                obj21.GetComponent<Renderer>().material = colorN;
                obj22.GetComponent<Renderer>().material = colorN;
                i = 3;
            }
            else if (i == 3) {
                i = 4;
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
                obj14.GetComponent<Renderer>().material = colorV;
                obj15.GetComponent<Renderer>().material = colorV;
                obj16.GetComponent<Renderer>().material = colorV;
                obj17.GetComponent<Renderer>().material = colorV;
                obj18.GetComponent<Renderer>().material = colorV;
                obj19.GetComponent<Renderer>().material = colorV;
                obj21.GetComponent<Renderer>().material = colorV;
                obj22.GetComponent<Renderer>().material = colorV;




            }
            else
            {
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
                obj14.GetComponent<Renderer>().material = colorG;
                obj15.GetComponent<Renderer>().material = colorG;
                obj16.GetComponent<Renderer>().material = colorG;
                obj17.GetComponent<Renderer>().material = colorG;
                obj18.GetComponent<Renderer>().material = colorG;
                obj19.GetComponent<Renderer>().material = colorG;
                obj20.GetComponent<Renderer>().material = colorG;
                obj21.GetComponent<Renderer>().material = colorG;
                obj22.GetComponent<Renderer>().material = colorG;
                i = 1;
            }

        }
        else {
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
                obje20.GetComponent<Renderer>().material = colorB;
                obje21.GetComponent<Renderer>().material = colorB;
                obje22.GetComponent<Renderer>().material = colorB;
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
                obje21.GetComponent<Renderer>().material = colorN;
                obje22.GetComponent<Renderer>().material = colorN;
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
                obje21.GetComponent<Renderer>().material = colorV;
                obje22.GetComponent<Renderer>().material = colorV;
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
                obje21.GetComponent<Renderer>().material = colorG;
                obje22.GetComponent<Renderer>().material = colorG;
                i = 1;
            }





        }



    }
     public void CambiarColorCuatro() {
        if (model1.gameObject.activeSelf)
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
            else if (i == 3) {
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
        else {
            if (i == 1)
            {
               
                obj5.GetComponent<Renderer>().material = colorB;
                obj6.GetComponent<Renderer>().material = colorB;
               
                i = 2;
            }

            else if (i == 2)
            {
                obj5.GetComponent<Renderer>().material = colorN;
                obj6.GetComponent<Renderer>().material = colorN;
                i = 3;
            }
            else if (i == 3)
            {
                i = 4;
                obj5.GetComponent<Renderer>().material = colorV;
                obj6.GetComponent<Renderer>().material = colorV;
              
            }
            else
            {
                obj5.GetComponent<Renderer>().material = colorG;
                obj6.GetComponent<Renderer>().material = colorG;
               
               
                i = 1;
            }





        }



    }


    public void PauseAnim()
    {

        if (model1.gameObject.activeSelf & animator1.speed == 1)
        {
            animator1.speed = 0;
            resume.SetActive(true);
            pausa.SetActive(false);

        }
        else if (model1.gameObject.activeSelf & animator1.speed == 0)
        {
            animator1.speed = 1;
            resume.SetActive(false);
            pausa.SetActive(true);
        }


        if (model2.gameObject.activeSelf & animator2.speed == 1)
        {
            animator2.speed = 0;
            resume.SetActive(true);
            pausa.SetActive(false);

        }
        else if (model2.gameObject.activeSelf & animator2.speed == 0)
        {

            animator2.speed = 1;
            resume.SetActive(false);
            pausa.SetActive(true);
        }
    }

    public void CambiarCinem() {
        if (model1.gameObject.activeSelf)
        {
           

            model1.gameObject.SetActive(false);
            model2.gameObject.SetActive(true);
            animator2.speed = 1;
            animator1.speed = 0;
            txtCambio.GetComponentInChildren<Text>().text = "MRUV";
         

        }
        else
        {
          
            animator1.speed = 1;
            animator2.speed = 0;
            model1.gameObject.SetActive(true);
            model2.gameObject.SetActive(false);
            txtCambio.GetComponentInChildren<Text>().text = "MRU";
      
       
        }

    }

    public void CambiarCaida()
    {
        if (model1.gameObject.activeSelf)
        {


            model1.gameObject.SetActive(false);
            model2.gameObject.SetActive(true);
            animator2.speed = 1;
            animator1.speed = 0;
            txtCambio.GetComponentInChildren<Text>().text = "Luna";


        }
        else
        {

            animator1.speed = 1;
            animator2.speed = 0;
            model1.gameObject.SetActive(true);
            model2.gameObject.SetActive(false);
            txtCambio.GetComponentInChildren<Text>().text = "Tierra";


        }

    }
    public void CambiarOne()
    {
        if (model1.gameObject.activeSelf)
        {


            model1.gameObject.SetActive(false);
            model2.gameObject.SetActive(true);
            animator2.speed = 1;
            animator1.speed = 0;
            txtCambio.GetComponentInChildren<Text>().text = "2";


        }
        else
        {

            animator1.speed = 1;
            animator2.speed = 0;
            model1.gameObject.SetActive(true);
            model2.gameObject.SetActive(false);
            txtCambio.GetComponentInChildren<Text>().text = "1";


        }

    }

}
