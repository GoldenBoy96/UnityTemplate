using System;
using System.Collections;
using UnityEngine;

namespace Template
{
    [CreateAssetMenu(fileName = "AudioData", menuName = "ScriptableObjects/AudioData", order = 0)]
    [Serializable]
    public class AudioDataSO : ScriptableObject
    {
        [SerializeField] AudioData _audioData;

        public AudioData AudioData { get => _audioData; set => _audioData = value; }
    }
}