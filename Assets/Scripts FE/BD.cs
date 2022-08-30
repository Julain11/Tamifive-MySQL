using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BD : MonoBehaviour
{
    static BD instance;
    public string filename = "";    
    void Start()
      { 
     filename = Application.dataPath + "/text.csv"; 
     }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Tabla(bool completado)
{
    string path = Application.dataPath + "/" + "Tabla" + ".txt";
        if (!File.Exists(path))
        {
            //File.WriteAllText(path, "login log \n\n ");
            File.WriteAllText(path, "Datos de " + "Tabla" + "\n");
        }
        string content = completado +  "\n";
        File.AppendAllText(path, content);

}
}
