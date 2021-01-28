using ToggleSystem.Scripts.Core;
using ToggleSystem.Scripts.Interfaces;
using UnityEngine;

namespace ToggleSystem.Scripts.MonoControllers
{
    public class GameObjectToggleController : BaseToggleable
    {
        [SerializeField] private GameObject toggleableGameObject;
        private readonly IToggle<GameObject> _toggle = new GameObjectToggle();


        [ContextMenu("EnableColliders")]
        public void EnableColliders()
        {
            Toggle(true);
        }
        
        [ContextMenu("DisableColliders")]
        public void DisableColliders()
        {
            Toggle(true);
        }

        public override void Toggle(bool isEnabled)
        {
            _toggle.Toggle(toggleableGameObject, isEnabled);
        }
    }
}