using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JUEGO1 : MonoBehaviour
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
    public GameObject texto;


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
        ManagerDB.insertar(EstadoJuego.estadoJuego.PacienteNombre,EstadoJuego.estadoJuego.PacienteEdad,EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre,EstadoJuego.estadoJuego.ProCorreo,EstadoJuego.estadoJuego.ProApellido, "Osos", puntaje);
        Debug.Log("nivel pasado");
    }
    IEnumerator haceralgo()
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(scenename);
        puntaje = 0;
        ManagerDB.insertar(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, "Osos", puntaje);
        Debug.Log("nivel no pasado");
    }
    public void derecha()
    {
        if (der) 
        { 
            puntaje = 1;
            ManagerDB.insertar(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, "Osos", puntaje);
            Debug.Log("nivel pasado"); 
        }
     
        SceneManager.LoadScene("Intro Funciones E 1");       
    }
    public void izquierda()
    {
        ManagerDB.insertar(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, "Osos", puntaje);
        SceneManager.LoadScene("1 FE");
    }
    public void textoClick()
    {
        
        texto.gameObject.active = true;
    }

}
