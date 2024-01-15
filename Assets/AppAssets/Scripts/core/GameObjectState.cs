using UnityEngine;

public class GameObjectState
{
    private Vector3 position;
    private Quaternion rotation;
    private Vector3 localScale;

    public void Save(Transform objTransform)
    {
        position = objTransform.position;
        rotation = objTransform.rotation;
        localScale = objTransform.localScale;
    }

    public void Restore(Transform objTransform)
    {
        objTransform.position = position;
        objTransform.rotation = rotation;
        objTransform.localScale = localScale;
    }
}
