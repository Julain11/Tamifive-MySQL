using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextTriqui : MonoBehaviour
{
    public Dentro[] ubicacion;
    public int correcto = 0;
    public int incorrecto = 0;
    public int contar = 0;
    public float t = 0.0f;
    public string nivel = "triqui1";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

    }
    public void Sigiente()
    {
        for(int i=0 ; i <= ubicacion.Length-1; i++)
        {
            if(ubicacion[i].Check == true)
            {
                correcto++;
                Debug.Log(correcto);
            }
            else
            {
                incorrecto++;
                Debug.Log(incorrecto);
            }
        }

        ManagerDB.insertarprueba(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteApeliido, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, nivel, correcto, incorrecto, (int)t);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
