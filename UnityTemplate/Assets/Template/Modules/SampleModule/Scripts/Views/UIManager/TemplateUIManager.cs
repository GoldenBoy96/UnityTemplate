using NUnit.Framework;
using UnityEngine;

namespace Template
{
    public class TemplateUIManager : MonoBehaviour
    {
        [Header("Parent of UI")]
        [SerializeField] Transform _baseLayerParent;
        [SerializeField] Transform _tabLayerParent;
        [SerializeField] Transform _popUpLayerParent;

        [Header("Prefab")]
        [SerializeField] TemplateControllerUI _UIControllerAAAPrefab;
        [SerializeField] TemplateControllerUI _UIControllerBBBPrefab;

        private TemplateControllerUI _UIControllerAAA;
        private TemplateControllerUI _UIControllerBBB;


        void Start ()
        {
            _UIControllerAAA = Instantiate(_UIControllerAAAPrefab, _baseLayerParent);
            _UIControllerBBB = Instantiate(_UIControllerBBBPrefab, _baseLayerParent);
        }

    }
}