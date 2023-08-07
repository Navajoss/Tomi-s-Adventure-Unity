using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera_L_1 : MonoBehaviour
{

    public GameObject Camera_360;
    public GameObject Camera_L;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerMovementAdvanced player = other.GetComponent<PlayerMovementAdvanced>();
        if (player != null)
        {
            Camera_360.gameObject.SetActive(false);
            Camera_L.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit (Collider other)
    {
        PlayerMovementAdvanced player = other.GetComponent<PlayerMovementAdvanced>();
        if (player != null)
        {
           
            Camera_360.gameObject.SetActive(true);
            Camera_L.gameObject.SetActive(false);
        }
    }

}
