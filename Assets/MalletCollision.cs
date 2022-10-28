using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CMN
{
    public class MalletCollision : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Enemy"))
            {
                Debug.Log("HIT enemy!!!");
            }
        }
    }
}
