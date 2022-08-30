using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Salon4 : MonoBehaviour
{
    public bool Check;
    public string escena;

    public GameObject libro;
    public GameObject Maleta;
    public int correcto = 0;
    public int incorrecto = 0;
    public string nivel;
    public float t = 0.0f;

    Collider2D m_Collider;
    // Start is called before the first frame update
    void Start()
    {
        m_Collider = Maleta.GetComponent<Collider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

    }
    public void MaletaClick()
    {
        m_Collider.enabled = false;
        libro.gameObject.active = true;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Libro")
        {
            Check = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Libro")
        {
            Check = false;
        }
    }

    public void Siguiente()
    {
        if (Check)
        {
            
            ManagerDB.insertarprueba(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteApeliido, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, nivel, 1, 0, (int)t);
            Debug.Log("cambio de esena puntuacion 1");
            SceneManager.LoadScene(escena);
        }
        else
        {
          
            ManagerDB.insertarprueba(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteApeliido, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, nivel, 0, 1, (int)t);
            Debug.Log("cambio de esena puntuacion 0");
            SceneManager.LoadScene(escena);
        }
    }
}
