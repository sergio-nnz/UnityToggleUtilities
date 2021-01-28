using ToggleSystem.Scripts.Interfaces;
using UnityEngine;

namespace ToggleSystem.Scripts.Core
{
    public class GameObjectToggle : IToggle<GameObject>
    {
        public void Toggle(GameObject gameObject, bool isEnabled)
        {
            gameObject.SetActive(isEnabled);
        }
    }
}

