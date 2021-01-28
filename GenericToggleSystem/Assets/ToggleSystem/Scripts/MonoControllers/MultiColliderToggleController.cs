using ToggleSystem.Scripts.Core;
using ToggleSystem.Scripts.Interfaces;
using UnityEngine;

namespace ToggleSystem.Scripts.MonoControllers
{
    public class MultiColliderToggleController : BaseToggleable
    {
        [SerializeField] private Collider[] colliderComponent;
        private readonly IToggle<Collider> _toggle = new ColliderToggle<Collider>();

        public Collider[] ColliderComponent
        {
            get => colliderComponent;
            set => colliderComponent = value;
        }

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
            for (var i = 0; i < colliderComponent.Length; i++)
            {
                var collier = colliderComponent[i];
                _toggle.Toggle(collier, isEnabled);
            }
        }
    }
}