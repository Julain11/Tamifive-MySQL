using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Memoria : MonoBehaviour
{
    // Start is called before the first frame update
    public int correcto = 0;
    public int incorrecto = 0;
    public float t= 0.0f;
    public Button[] bts;

    public string nivel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

    }

    public void Correcto()
    {


        /* Debug.Log("Correcto");

         ManagerDB.insertar(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteInstitucion, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProInstitucion, nivel, puntaje);*/

        correcto++;

    }
    public void Incorrecto()
    {
        /*ManagerDB.insertar(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteInstitucion, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProInstitucion, nivel, puntaje);

        Debug.Log("Incorrecto");*/
        incorrecto++;



    }
    public void EnviarDatos()
    {
        Debug.Log(correcto.ToString()+" & " + incorrecto.ToString());
        ManagerDB.insertarprueba(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteApeliido, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, nivel, correcto, incorrecto, (int)t);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  


    }
    public void bloquearboton(int i)
    {
       /* Debug.Log(i.ToString());*/
        bts[i].interactable = false;
        
    }
}
