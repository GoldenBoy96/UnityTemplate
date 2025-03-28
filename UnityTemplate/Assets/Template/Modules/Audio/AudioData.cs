using OurUtils;
using System;
using System.Collections;
using UnityEngine;

namespace Template
{
    [Serializable]
    public class AudioData : ICloneable<AudioData>
    {
        [SerializeField] private AudioClip _clip;
        [Range(0.0f, 1.0f)]
        [SerializeField] private float _volume;
        string audioName;
        public AudioClip Clip { get => _clip; set => _clip = value; }
        public float Volume { get => _volume; set => _volume = value; }
        public string AudioName { get => audioName; set => audioName = value; }

    }

}