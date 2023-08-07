using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HotWater : MonoBehaviour
{
    [SerializeField] private float knockbackStrength;
    public Rigidbody rb;
    public float time = 0;

    private void Update()
    {
        time -= Time.deltaTime;
        if(time<= 0)
        {
            rb.GetComponent<PlayerMovementAdvanced>().enabled = true;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        

        if (rb != null)
        {
            time = 5; 
            Vector3 direction = other.transform.position - transform.position;
            //direction.y = 0;
            //direction.x = 0;
            rb.GetComponent<PlayerMovementAdvanced>().enabled = false;

            rb.AddForce(direction.normalized * knockbackStrength, ForceMode.Impulse);

        }
    }
}
