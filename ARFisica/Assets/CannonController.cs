using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonController : MonoBehaviour
{
    CannonBall ball;
    public Rigidbody projectile;
    public Transform shootPoint;
    public Slider Sv, SA;
    public Text Texttime;
    float rads, angulo,vel,vx,vy, ang, ttotal, tiempo, g;
    LaunchARcrenderer la;
    Vector3 Vo;
    
    // Start is called before the first frame update
    void Start()
    {
       // Vo.x = 15.5f;
        //Vo.y = 26;
        //Vo.z = 0;
    }

    // Update is called once per frame
   

    public void Disparar()
    {
        vel = Sv.value;
        ang = SA.value;
        rads = Mathf.Deg2Rad *ang;
        vx =vel* Mathf.Cos(rads);
        vy =vel* Mathf.Sin(rads);
        Vo.x= vx;
        Vo.y = vy;
        Vo.z = 0;
        shootPoint.localPosition= new Vector3(shootPoint.localPosition.x, shootPoint.localPosition.y, 0);
        Rigidbody obj= Instantiate(projectile, shootPoint.position, Quaternion.Euler(0,0,0));
        
        obj.velocity = Vo;
        obj.angularDrag = ang;
        g = Mathf.Abs(Physics.gravity.y);

        ttotal = (2 * vel * Mathf.Sin(rads)) / 9.8f;

        Destroy(obj, ttotal*2);
        //ball.Update();
        //ball.tiempo(ttotal);
      


    }

   




}
