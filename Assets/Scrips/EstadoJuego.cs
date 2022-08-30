using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoJuego : MonoBehaviour
{
    public string PacienteNombre="nombre del paciente";
    public string PacienteApeliido = "Apellido del paciente";
    public string PacienteEdad="0";
    public string PacienteGrado = "Grado del paciente" ;
    public string ProNombre ="nombre del profesional";
    public string ProCorreo="correo del profesional";
    public string ProApellido = "Apellido  del profesional";
    public static EstadoJuego estadoJuego;

    void Awake()//funcion antes de inciar el juego
    {
        if (estadoJuego == null)//si no existe
        {
            estadoJuego = this;
            DontDestroyOnLoad(gameObject);//se vuelve indestructible
        }
        else if (estadoJuego != this)// si existe
        {
            Destroy(gameObject);//se destruye
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
