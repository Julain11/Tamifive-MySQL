using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dentro : MonoBehaviour
{

    public bool Check;
    public string Name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == Name)
        {
            Check = true;
        }        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == Name)
        {
            Check = false;
        }
    }

    public void Entra()
    {
        //Check   = true;
    }
    public void Sale()
    {
        //Check = false;
    }
}
