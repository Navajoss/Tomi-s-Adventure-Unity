using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Vitrobutton : MonoBehaviour
{
    public GameObject Vitro;
    public float time = 5;
    public bool activate = false;

    private void OnTriggerEnter(Collider other)
    {
        PlayerMovementAdvanced player = other.GetComponent<PlayerMovementAdvanced>();
        if (player != null)
        {
            
            activate = true;
            //Vitro.gameObject.SetActive(true);

        }
        
    }
    public void Update()
    {
        if (activate == true)
        {
            vitro();
        }
    }
    public void vitro()
    {


        Debug.Log("p");

        time -= Time.deltaTime;

        if (time <= 0)
        {
            Vitro.gameObject.SetActive(true);
        }

    }
}
