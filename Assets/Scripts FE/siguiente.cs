using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class siguiente : MonoBehaviour
{
    // Start is called before the first frame update
public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void playATRAS()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void playACTUALIZAR()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void categorias()
    {
        SceneManager.LoadScene("Menu_CATEGORIAS");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void URL()
    {
        Application.OpenURL("https://drive.google.com/uc?id=1bpl21YhAfYHksQ-k7w63FDZsnzmHQbOS&export=download");
    }

}

