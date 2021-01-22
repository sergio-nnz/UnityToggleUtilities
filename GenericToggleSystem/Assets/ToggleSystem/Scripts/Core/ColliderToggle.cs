using ToggleSystem.Scripts.Interfaces;
using UnityEngine;

namespace ToggleSystem.Scripts.Core
{
    public class ColliderToggle<T> : IToggle<T> where T : Collider
    {
        public void Toggle(T component, bool isEnabled)
        {
            component.enabled = isEnabled;
        }
    }
}