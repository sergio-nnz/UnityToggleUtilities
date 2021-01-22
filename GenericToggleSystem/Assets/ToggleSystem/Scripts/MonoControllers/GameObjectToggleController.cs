using ToggleSystem.Scripts.Core;
using ToggleSystem.Scripts.Interfaces;
using UnityEngine;

namespace ToggleSystem.Scripts.MonoControllers
{
    public class GameObjectToggleController : BaseToggleable
    {
        [SerializeField] private GameObject _gameObject;
        private readonly IToggle<GameObject> _toggle = new GameObjectToggle();

        public override void Toggle(bool isEnabled)
        {
            _toggle.Toggle(_gameObject, isEnabled);
        }
    }
}