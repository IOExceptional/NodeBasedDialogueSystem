using System;
using UnityEngine;

namespace Subtegral.DialogueSystem.DataContainers
{
    [Serializable]
    public class DialogueNodeData
    {
        public string NodeGUID;
        public string DialogueId;
        public string DialogueText;
        public Vector2 Position;
    }
}