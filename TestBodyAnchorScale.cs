using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

namespace UnityEngine.XR.ARFoundation.Samples
{
    public class TestBodyAnchorScale : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("The ARHumanBodyManager which will produce frame events.")]
        ARHumanBodyManager m_HumanBodyManager;

        /// <summary>
        /// Get or set the <c>ARHumanBodyManager</c>.
        /// </summary>
        public ARHumanBodyManager humanBodyManager
        {
            get { return m_HumanBodyManager; }
            set { m_HumanBodyManager = value; }
        }
    }
}