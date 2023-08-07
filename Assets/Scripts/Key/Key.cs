using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject key;
    public GameObject padlock;
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
            padlock.gameObject.SetActive(true);
            key.gameObject.SetActive(false);

        }
    }
}
