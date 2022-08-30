using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DragDropLAB : MonoBehaviour
{
    private bool selected;
    public bool move;
    public int intentos;
    public int vida = 1;
    public Vector3 posinicio;
    public Vector3 posFinal;
    public Animator animator;
    public int correcto = 0;
    public int incorrecto = 0;
    public float t = 0.0f;
    public string nivel;


    // Start is called before the first frame update
    void Start()
    {
        posinicio = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    t += Time.deltaTime;
    if (selected == true && move == false)
        {
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(cursorPos.x, cursorPos.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            selected = false;
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            selected = true;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("GameOver");
            incorrecto++;
      /*  ManagerDB.insertarprueba(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteInstitucion, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProInstitucion, nivel, correcto, 1, (int)t);*/
        move = true;
            if(vida <= 0)
            {
                vida--;
                //transform.position = posinicio;
                selected = false;
                StartCoroutine(explotion2());
            }
            else
            {
                vida--;
                
                selected = false;
                StartCoroutine(explotion1());
            }
        }

        if (collision.gameObject.tag == "Salida")
        {
            move = true;
            correcto++;
        Debug.Log("Winner");
       /* ManagerDB.insertarprueba(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteInstitucion, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProInstitucion, nivel, 1, incorrecto, (int)t);*/
        //move = true;
    }
    }
    

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("GameOver");
           // ManagerDB.insertar(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteInstitucion, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProInstitucion, nivel, 0);
            move = true;
            if (vida <= 0)
            {
                vida--;
                //transform.position = posinicio;
                selected = false;
                StartCoroutine(explotion2());
            }
            else
            {
                vida--;

                selected = false;
                StartCoroutine(explotion1());
            }
        }

        if (other.gameObject.tag == "Salida")
        {
            transform.position = posFinal;
            move = true;
            
            Debug.Log("Winner");
            //ManagerDB.insertar(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteInstitucion, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProInstitucion, nivel, 1);
            //move = true;
        }

    }
    public void EnviarBoton()
    {
        ManagerDB.insertarprueba(EstadoJuego.estadoJuego.PacienteNombre, EstadoJuego.estadoJuego.PacienteApeliido, EstadoJuego.estadoJuego.PacienteEdad, EstadoJuego.estadoJuego.PacienteGrado, EstadoJuego.estadoJuego.ProNombre, EstadoJuego.estadoJuego.ProCorreo, EstadoJuego.estadoJuego.ProApellido, nivel, correcto, incorrecto, (int)t);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


}

    public IEnumerator explotion1()
    {
        animator.SetBool("Explotion", true);
       yield return new WaitForSeconds(1.5f);
        animator.SetBool("Explotion", false);
        move = false;
        transform.position = posinicio;
    }
    public IEnumerator explotion2()
    {
        animator.SetBool("Explotion", true);
        yield return new WaitForSeconds(1.5f);
        /* Destroy(gameObject);*/
        gameObject.active = false;
    }
}
