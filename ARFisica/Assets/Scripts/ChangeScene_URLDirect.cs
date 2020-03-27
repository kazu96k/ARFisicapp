using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene_URLDirect : MonoBehaviour
{
    public string URL;




    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if(URL.Length>0)
             Application.OpenURL(URL);
    }
    public void DirectURL() {
        if (URL.Length > 0)
            Application.OpenURL(URL);

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
