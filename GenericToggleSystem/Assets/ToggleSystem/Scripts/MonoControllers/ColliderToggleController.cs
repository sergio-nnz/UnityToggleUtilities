using ToggleSystem.Scripts.Core;
using ToggleSystem.Scripts.Interfaces;
using UnityEngine;

namespace ToggleSystem.Scripts.MonoControllers
{
    public class ColliderToggleController : BaseToggleable
    {
        [SerializeField] private Collider colliderComponent;
        private readonly IToggle<Collider> _toggle = new ColliderToggle<Collider>();

        public Collider ColliderComponent
        {
            get => colliderComponent;
            set => colliderComponent = value;
        }

        public override void Toggle(bool isEnabled)
        {
            _toggle.Toggle(colliderComponent, isEnabled);
        }
    }
}