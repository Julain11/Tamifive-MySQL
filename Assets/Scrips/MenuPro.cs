using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPro : MonoBehaviour
{
    // Start is called before the first frame update
    public Text NomPro;
    public Text CorreoPro;
    public Text ApePro;
    public Text IdentificacionPro;

    public void Boton()
    {
        EstadoJuego.estadoJuego.ProNombre = NomPro.text;
        EstadoJuego.estadoJuego.ProCorreo = CorreoPro.text;
        EstadoJuego.estadoJuego.ProApellido = ApePro.text;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
