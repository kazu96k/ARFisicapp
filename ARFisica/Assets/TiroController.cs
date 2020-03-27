using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiroController : MonoBehaviour
{
    private LineRenderer lr;
    public Transform shootPoint;
    public Rigidbody projectile;
    public Slider sliderV, sliderAng;
    public Text Alcance, AltMax, Tiempo, V, Ang, TextXYZ;
    float vo, vxo, vyo, thmax, ttotal, alcance, hmax, angulo, g, rads;
    Vector3 Vo;
    public Transform transf;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void CalcularTrayectoria() {
        vo = sliderV.value;//30
        V.text = vo.ToString("f");

        angulo = sliderAng.value;//60
        Ang.text = angulo.ToString("f");
        rads = Mathf.Deg2Rad * angulo;

        g = 9.8f;

        ttotal = (2 * vo * Mathf.Sin(rads)) / g; // 5.3

        Tiempo.text = "Tiempo Total: " + ttotal.ToString("f");

        alcance = vo * Mathf.Cos(rads) * ttotal;

        Alcance.text = "Alcance =" + alcance.ToString("f");

        thmax = ttotal / 2;

        hmax = (vo * Mathf.Sin(rads) * thmax + (-g * thmax * thmax / 2));

        AltMax.text = "Altura MAX= " + hmax.ToString("f") + " en T= " + thmax.ToString("f");
        transf.localPosition = new Vector3(alcance,0, 0);
        TextXYZ.text = " X " + transf.localPosition.x + " Y " + transf.localPosition.y + " z " + transf.localPosition.z;

    }
    public void Disparar()
    {
        vo = sliderV.value;
        angulo = sliderAng.value;
        rads = Mathf.Deg2Rad * angulo;
        vxo = vo * Mathf.Cos(rads);
        vyo = vo * Mathf.Sin(rads);
        Vo.x = vxo;
        Vo.y = vyo;
        Vo.z = 0;

        Rigidbody obj = Instantiate(projectile, shootPoint.position, Quaternion.identity);
        obj.velocity = Vo;
        obj.angularDrag = angulo;
        
        ttotal = (2 * vo * Mathf.Sin(rads)) / 9.8f;


        Destroy(obj, ttotal);
        


    }



}
