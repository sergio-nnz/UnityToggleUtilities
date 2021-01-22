using NUnit.Framework;
using ToggleSystem.Scripts.Core;
using ToggleSystem.Scripts.Helpers;
using UnityEngine;

namespace ToggleSystem.Tests.Editor
{
    public class ColliderToggleEditModeTest
    {
        private readonly ColliderToggle<Collider> _toggle = new ColliderToggle<Collider>();
        
        [Test]
        public void ToggleEnablesTheColliderComponent()
        {
            var collider = MockUtility.ForComponent<BoxCollider>();
            
            _toggle.Toggle(collider, true);

            Assert.True(collider.enabled);
        }

        [Test]
        public void ToggleDisablesTheColliderComponent()
        {
            var collider = MockUtility.ForComponent<BoxCollider>();
            
            _toggle.Toggle(collider, false);

            Assert.False(collider.enabled);
        }
    }
    

}
