using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Subtegral.DialogueSystem.Editor
{
    public class DialogueNode : Node
    {
        public string GUID;
        public string DialogueId;
        public string DialogueText;
        public bool EntyPoint = false;
    }
}