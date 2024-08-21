using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DummyTrigger : MonoBehaviour
{
    [SerializeField] private GameObject[] targetDummies;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach(GameObject dummies in targetDummies)
            {
                dummies.GetComponent<TargetDummy>().ActivateDummy();
            }
        }
    }
}
