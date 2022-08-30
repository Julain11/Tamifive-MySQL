using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JUEGO2 : MonoBehaviour
{
    public string regla;
    //si el oso a seleccionar esta en la parte izquierda use izq
    //si el oso a seleccionar esta en la parte derecha use der
    //si no hay oso que selecionar use na
    public float time = 5.0f;
    //tiempo de espera 
    public string scenename;
    //siguiente scena
    public int puntaje = 0;
    

    bool izq;
    bool der;    
    bool na;

    public void Awake()
    {
        switch (regla)
        {
            case "izq":
                izq = true;
                der = false;
                na = false;
                break;
            case "der":
                izq = false;
                der = true;
                na = false;
                break;
            case "na":
                izq = false;
                der = false;
                na = true;
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if(na == true)
        {
            StartCoroutine(Nohacerndada());
        }
        else
        {
            StartCoroutine(haceralgo());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Nohacerndada()
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(scenename);
        puntaje = 1;
        Debug.Log("nivel pasado");
    }
    IEnumerator haceralgo()
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(scenename);
        puntaje = 0;
        Debug.Log("nivel no pasado");
    }
    public void derecha()
    {
        if (der) { puntaje = 1; Debug.Log("nivel pasado"); }
        else { Debug.Log("nivel Nopasado"); }        
        SceneManager.LoadScene(scenename);       
    }
    public void izquierda()
    {
        if (izq) { puntaje = 1; Debug.Log("nivel pasado"); }
        else { Debug.Log("nivel Nopasado"); }
        SceneManager.LoadScene(scenename);
    }
        public void nada()
    {
        if (izq) { puntaje = 1; Debug.Log("nivel pasado"); }
        else { Debug.Log("nivel Nopasado"); }
        SceneManager.LoadScene(scenename);
    }

}
