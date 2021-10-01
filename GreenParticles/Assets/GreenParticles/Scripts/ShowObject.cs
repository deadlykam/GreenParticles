using UnityEngine;

namespace GreenParticles
{
    public class ShowObject : MonoBehaviour
    {
        [SerializeField] private GameObject _target;

        private void Update() { if (Input.GetKeyDown(KeyCode.P)) _target.SetActive(!_target.activeSelf); }
    }
}