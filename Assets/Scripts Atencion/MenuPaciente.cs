using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPaciente : MonoBehaviour

{
    public Text NomPaciente;
    public Text ApePaciente;

    public Text EdadPaciente;
    public Text GradoPaciente;
    public Text IdentificacionPaciente;

    public void Boton()
    {
        EstadoJuego.estadoJuego.PacienteNombre = NomPaciente.text;
        EstadoJuego.estadoJuego.PacienteApeliido = ApePaciente.text;

        EstadoJuego.estadoJuego.PacienteEdad = EdadPaciente.text;
        EstadoJuego.estadoJuego.PacienteGrado = GradoPaciente.text;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
