using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class JUEGO : MonoBehaviour
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
    public string nivel;
    public int correcto = 0;
    public int incorrecto = 0;
    public float t = 0.0f;


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
        t += Time.deltaTime;

    }
    IEnumerator Nohacerndada()
    {
        yield return new WaitForSeconds(time);
        
        correcto = 1;
        Debug.Log("nivel pasado");
        ManagerDB.insertarprueba(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteApeliido, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, nivel, correcto, incorrecto, (int)t);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    IEnumerator haceralgo()
    {
        yield return new WaitForSeconds(time);
        
        incorrecto = 1;
        Debug.Log("nivel no pasado");
        ManagerDB.insertarprueba(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteApeliido, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, nivel, correcto, incorrecto, (int)t);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void derecha()
    {
        if (der) { correcto = 1; Debug.Log("nivel pasado"); ManagerDB.insertarprueba(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteApeliido, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, nivel, correcto, incorrecto, (int)t); }
        else { incorrecto = 1; Debug.Log("nivel Nopasado"); ManagerDB.insertarprueba(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteApeliido, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, nivel, correcto, incorrecto, (int)t); }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void izquierda()
    {
        if (izq) { correcto = 1; Debug.Log("nivel pasado"); ManagerDB.insertarprueba(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteApeliido, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, nivel, correcto, incorrecto, (int)t); }
        else { incorrecto = 1; Debug.Log("nivel Nopasado"); ManagerDB.insertarprueba(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteApeliido, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, nivel, correcto, incorrecto, (int)t); }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
