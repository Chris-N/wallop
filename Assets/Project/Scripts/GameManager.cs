using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CMN
{
    public class GameManager : MonoBehaviour
    {
        private bool _isStarting = false;
        private Rigidbody _rbEnemy;

        public GameObject enemy;
        public float verticalForce = 5.0f;

        // Start is called before the first frame update
        void Start()
        {
            _rbEnemy = enemy.GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            if (_isStarting )
            {
                Debug.Log("Launch off!");
                _rbEnemy.AddForce(0, verticalForce, 0, ForceMode.Impulse);
                _isStarting = false;
            }
        
        }
        public void StartGame()
        {
            _isStarting = !_isStarting;
            Debug.Log("Game has begun!");
        }

    }

    // Game Manager
    // -scoreNum
    // -List<Enemies>
    // 


    // Button
    // -onPressed/TriggerEnter, Invoke!
    // -onReleased/TriggerExit, Invoke!



}
