using System.Collections.Generic;
using Lean.Common;
using Lean.Touch;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButtonController : MonoBehaviour
{
    [SerializeField]
    List<GameObject> bodyParts;

    public void OnClick()
    {
        foreach (var bodyPart in bodyParts)
        {
            var controller = bodyPart.GetComponent<BodyPartController>();
            controller.Reset();
        }
    }
}
