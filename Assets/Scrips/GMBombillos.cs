using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GMBombillos : MonoBehaviour
{
    public Button[] Swiches;
    public Animator[] bombillos;
    public int correcto = 0;
    public int incorrecto = 0;
    public float t;

    public int[] secuencia;
    public int pos;
    public bool[] prender;
    public int[] click;
    public string nivel;

    // Start is called before the first frame update
    void Start()
    {
        EncenderBombillo(bombillos[secuencia[pos]]);
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (pos >= secuencia.Length)         { 
            
                        Debug.Log("Gano Nivel");
            ManagerDB.insertarprueba(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteApeliido, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, nivel, correcto, incorrecto, (int)t);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);      
        
        }     
    }

    public void EncenderBombillo(Animator bombilloOn)
    {
        click[secuencia[pos]] = Random.Range(2,10);
        bombilloOn.SetBool("Prendido", true);
    }

    public void ApagarBombillo(Animator bombilloOn)
    {
        bombilloOn.SetBool("Prendido", false);
    }

    public void B0()
    {
        if (click[0] > 0) { 
            click[0]--;
            if(click[secuencia[pos]] <= 0)
            {
                correcto++;

                ApagarBombillo(bombillos[secuencia[pos]]);
                pos++;
                EncenderBombillo(bombillos[secuencia[pos]]);

            }

        }
        else
        {
            Debug.Log("Falla");
            incorrecto++;
        }
    }

    public void B1()
    {
        if (click[1] > 0)
        {
            click[1]--;
            if (click[secuencia[pos]] <= 0)
            {
                correcto++;
                ApagarBombillo(bombillos[secuencia[pos]]);
                pos++;
                EncenderBombillo(bombillos[secuencia[pos]]);
            }

        }
        else
        {
            Debug.Log("Falla");
            incorrecto++;
        }
    }

    public void B2()
    {
        if (click[2] > 0)
        {
            click[2]--;
            if (click[secuencia[pos]] <= 0)
            {
                correcto++;
                ApagarBombillo(bombillos[secuencia[pos]]);
                pos++;
                EncenderBombillo(bombillos[secuencia[pos]]);
            }

        }
        else
        {
            Debug.Log("Falla");
            incorrecto++;
        }
    }

}
