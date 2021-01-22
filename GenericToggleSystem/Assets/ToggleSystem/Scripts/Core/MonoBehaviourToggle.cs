using ToggleSystem.Scripts.Interfaces;
using UnityEngine;

namespace ToggleSystem.Scripts.Core
{
    public class MonoBehaviourToggle<T> : IToggle<T> where T : MonoBehaviour
    {
        public void Toggle(T component, bool isEnabled)
        {
            component.enabled = isEnabled;
        }
    }
}