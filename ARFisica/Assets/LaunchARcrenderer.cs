using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(LineRenderer))]
public class LaunchARcrenderer : MonoBehaviour
{
    public Transform origin;
    private LineRenderer lr;
    public Transform tr, tr2;
    public Slider sliderV, sliderAng;
    public Text Alcance, AltMax, Tiempo, V, Ang;
    float vo, vxo, vyo, thmax, ttotal, alcance, hmax, angulo, g, rads;
    
    public int res=30;

     private void OnValidate()
    {
        if (lr != null && Application.isPlaying)
        {
            RenderArc();
        }
    }
    [System.Obsolete]
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        RenderArc();
    }

   public void RenderArc()
    {
        lr.SetVertexCount(res + 1);
        lr.SetPositions(CalculateArcArray());
        tr.localRotation = Quaternion.Euler(-sliderAng.value, 0, 0);
        tr2.localRotation = Quaternion.Euler(-sliderAng.value, 0, 0);
    }

   public  Vector3[] CalculateArcArray()
    {
        
        Vector3[] arcArray = new Vector3[res + 1];
        vo = sliderV.value;//30
        V.text = vo.ToString("f");

        angulo = sliderAng.value;//60
        Ang.text = angulo.ToString("f");
       
        rads = Mathf.Deg2Rad * angulo;

        g =Mathf.Abs(  Physics.gravity.y);

        ttotal = (2 * vo * Mathf.Sin(rads)) / g; // 5.3

        Tiempo.text = "Tiempo Total: " + ttotal.ToString("f");

        alcance = vo * Mathf.Cos(rads) * ttotal;

        Alcance.text = "Alcance =" + alcance.ToString("f");

        thmax = ttotal / 2;
        

        hmax = (vo * Mathf.Sin(rads) * thmax + (-g * thmax * thmax / 2));

        AltMax.text = "Altura MAX= " + hmax.ToString("f") + " en T= " + thmax.ToString("f");



        for (int i = 0; i <= res; i++)
        {
            float t = (float)i / (float)res;
            arcArray[i] = CalculateArcPoint(t, alcance);

        }


        return arcArray;
    }

  public  Vector3 CalculateArcPoint(float t, float maxDistance)
    {
        float x = t * maxDistance;
        float y = x * Mathf.Tan(rads) - ((g * x * x) / (2* vo * vo * Mathf.Cos(rads) * Mathf.Cos(rads)));
        return new Vector3(x, y);
    }


   







}
