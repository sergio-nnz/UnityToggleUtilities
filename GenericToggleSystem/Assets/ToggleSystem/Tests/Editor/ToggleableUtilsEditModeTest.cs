using NUnit.Framework;
using ToggleSystem.Scripts.Helpers;
using ToggleSystem.Scripts.Interfaces;
using ToggleSystem.Scripts.MonoControllers;
using UnityEngine;

namespace ToggleSystem.Tests.Editor
{
    public class ToggleableUtilsEditModeTest
    {
        private BoxCollider _actualCollider;
        private ColliderToggleController _controller;
        
        [SetUp]
        public void InitializeScene()
        {
            _actualCollider = MockUtility.ForComponent<BoxCollider>();
            _controller = MockUtility.ForClass<ColliderToggleController>();
        }
        
        [Test]
        public void CollectiveToggleSetsObjectsToTrue()
        {
            _controller.ObjCollider = _actualCollider;

            BaseToggleable[] toggleObjects = {_controller};
            
            ToggleUtils.MultiToggle(toggleObjects, true);
            
            Assert.True(_actualCollider);
        }
        
        [Test]
        public void CollectiveToggleSetsObjectsToFalse()
        {
            _controller.ObjCollider = _actualCollider;

            BaseToggleable[] toggleObjects = {_controller};
            
            ToggleUtils.MultiToggle(toggleObjects, true);
            
            Assert.True(_actualCollider);
        }
    }
}

