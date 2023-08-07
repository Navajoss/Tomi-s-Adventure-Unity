using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KnockbackOnCollision : MonoBehaviour
{
    [SerializeField] private float knockbackStrength;
    public Rigidbody rb;


    private void OnTriggerEnter(Collider other)
    {


        if (rb != null)
        {
            Vector3 direction = other.transform.position - transform.position;

            //stunned
            rb.GetComponent<PlayerMovementAdvanced>().enabled = false;

            //Knockback
            rb.AddForce(direction.normalized * knockbackStrength, ForceMode.Impulse);
        }
    }
}
