using NUnit.Framework;
using ToggleSystem.Scripts.Core;
using ToggleSystem.Scripts.Helpers;
using UnityEngine.UI;

namespace ToggleSystem.Tests.Editor
{
    public class ButtonArrayInteractionToggleEditModeTest
    {
        private Button _testButton;
        private Button[] _buttons;
        private readonly ButtonArrayInteractionToggle _toggle = new ButtonArrayInteractionToggle();


        [SetUp]
        public void InitializeScene()
        {
             _testButton = MockUtility.ForComponent<Button>();
            _buttons = new[] {_testButton};
        }

        [Test]
        public void ToggleEnablesInteractablePropertyFromButtons()
        {
            _toggle.Toggle(_buttons, true);

            Assert.True(_testButton.interactable);
        }

        [Test]
        public void ToggleDisablesInteractablePropertyFromButtons()
        {
            _toggle.Toggle(_buttons, false);

            Assert.False(_testButton.interactable);
        }
    }
}