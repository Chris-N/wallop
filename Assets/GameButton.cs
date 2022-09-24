using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace CMN
{
    public class GameButton : MonoBehaviour
    {
        public float deadTime = 1.0f;
        private bool _deadTimeActive = false;

        public UnityEvent onPressed;
        public UnityEvent onReleased;

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Button" && !_deadTimeActive)
            {
                onPressed?.Invoke();
                Debug.Log("I have been pressed");
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.tag == "Button" && !_deadTimeActive)
            {
                onReleased?.Invoke();
                Debug.Log("I have been released");
                StartCoroutine(WaitForDeadTime());
            }
        }

        IEnumerator WaitForDeadTime()
        {
            _deadTimeActive = true;
            yield return new WaitForSeconds(deadTime);
            _deadTimeActive = false;
        }
    }
}
