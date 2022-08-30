using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GMTopos : MonoBehaviour
{
    public bool agamen;

    public Button[] botones;
    public List<int> Secuencia = new List<int>();
    public List<int> Secuenciainvertida = new List<int>();
    

    public List<Button> keys = new List<Button>();

    public int pos=0;

    public bool winLose = false;
    public string nivel;
    public int correcto = 0;
    public int incorrecto = 0;
    public float t = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Secuencia.Count; i++)
        {
            Secuenciainvertida.Add(Secuencia[Secuencia.Count-i-1]);
        }
        for (int i = 0; i < Secuenciainvertida.Count; i++)
        {
            keys.Add(botones[Secuenciainvertida[i] ]);
        } 
        // Secuenciainvertida = Secuencia.;
        agamen = false;
        StartCoroutine(Animaciones(botones, Secuencia));
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (pos >= Secuencia.Count && winLose == false)
        {
            Debug.Log("Gano Nivel");
            ManagerDB.insertarprueba(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteApeliido, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, nivel, correcto, incorrecto, (int)t);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
            winLose = true;
        }
    }

    public IEnumerator Animaciones(Button[] buttons, List<int> Secuen)
    {
        for (int i = 0; i < Secuen.Count; i++)
        {
            buttons[Secuen[i]].animator.SetBool("Click", true);
            yield return new WaitForSeconds(1);
            buttons[Secuen[i]].animator.SetBool("Click", false);
        }
        yield return new WaitForSeconds(0);
        agamen = true;

    }

    public IEnumerator AnimacionesClick(Button buttons)    
     {                 
         buttons.animator.SetBool("Click", true);        
        yield return new WaitForSeconds(1);        
        buttons.animator.SetBool("Click", false);       
        yield return new WaitForSeconds(0);        
        agamen = true;     
        }

    /// ////////////////////////////////////////////////////////////////////////////////
    public void TC1()
    {
        if (agamen)
        {
            if(botones[1-1] == botones[Secuenciainvertida[pos]])
            {
                StartCoroutine(AnimacionesClick(botones[0]));
                botones[0].animator.SetBool("Click", true);
                correcto++;
                Debug.Log("win");
                pos++;
            }
            else
            {
                Debug.Log("Lose");
                incorrecto++;
            }
        }
    }

    public void TC2()
    {
        if (agamen)
        {
            if (botones[2 - 1] == botones[Secuenciainvertida[pos]])
            {
                StartCoroutine(AnimacionesClick(botones[1]));
                botones[1].animator.SetBool("Click", true);
                correcto++;
                Debug.Log("win");
                pos++;
            }
            else
            {
                Debug.Log("Lose");
                incorrecto++;
            }
        }
    }

    public void TC3()
    {
        if (agamen)
        {
            if (botones[3 - 1] == botones[Secuenciainvertida[pos]])
            {
                StartCoroutine(AnimacionesClick(botones[2]));
                botones[2].animator.SetBool("Click", true);
                correcto++;
                Debug.Log("win");
                pos++;
            }
            else
            {
                Debug.Log("Lose");
                incorrecto++;
            }
        }
    }

    public void TC4()
    {
        if (agamen)
        {
            if (botones[4 - 1] == botones[Secuenciainvertida[pos]])
            {
                StartCoroutine(AnimacionesClick(botones[3]));
                botones[3].animator.SetBool("Click", true);
                correcto++;
                Debug.Log("win");
                pos++;
            }
            else
            {
                Debug.Log("Lose");
                incorrecto++;
            }
        }
    }

    public void TC5()
    {
        if (agamen)
        {
            if (botones[5 - 1] == botones[Secuenciainvertida[pos]])
            {
                StartCoroutine(AnimacionesClick(botones[4]));
                botones[4].animator.SetBool("Click", true);
                correcto++;
                Debug.Log("win");
                pos++;
            }
            else
            {
                Debug.Log("Lose");
                incorrecto++;
            }
        }
    }

    public void TC6()
    {
        if (agamen)
        {
            if (botones[6 - 1] == botones[Secuenciainvertida[pos]])
            {
                StartCoroutine(AnimacionesClick(botones[5]));
                botones[5].animator.SetBool("Click", true);
                correcto++;
                Debug.Log("win");
                pos++;
            }
            else
            {
                Debug.Log("Lose");
                incorrecto++;
            }
        }
    }

    public void TC7()
    {
        if (agamen)
        {
            if (botones[7 - 1] == botones[Secuenciainvertida[pos]])
            {
                StartCoroutine(AnimacionesClick(botones[6]));
                botones[6].animator.SetBool("Click", true);
                correcto++;
                Debug.Log("win");
                pos++;
            }
            else
            {
                Debug.Log("Lose");
                incorrecto++;
            }
        }
    }
}
