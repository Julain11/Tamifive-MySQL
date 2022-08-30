using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class CambiodeScena : MonoBehaviour
{
     public string escena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }
    public void cambiodeescena()
    {

    SceneManager.LoadScene (escena);


    }
}
