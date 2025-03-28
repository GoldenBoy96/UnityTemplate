using OurUtils;
using TMPro;
using UnityEngine;

namespace Template
{
    public class TemplateControllerUI : SingletonMono<TemplateControllerUI>, IReset
    {
        [SerializeField] TemplateController _controller;

        [Header("Child UI GameObject/Component")]
        [SerializeField] Transform _templateTransform;
        [SerializeField] TMP_Text _templateText;

        [Header("Prefab")]
        [SerializeField] GameObject _templatePrefab;

        public void Reset()
        {
            _controller.Reset();
            _templateTransform.gameObject.SetActive(true);
            //Destroy on child that instaniate in run time
            _templateText.text = "Default text";
        }

        private void Update()
        {
            _controller.CurrentState.OnStateUpdate();
        }

        public void ReceiveInput()
        {

        }

        public void ShowOutput()
        {

        }

    }
}