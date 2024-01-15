using Lean.Common;
using Lean.Touch;
using UnityEngine;


public class BodyPartController : LeanSelectableByFingerBehaviour
{
    [SerializeField]
    HumanOrgans _humanOrgan;

    OrganInfoOverlayController _overlayController;

    private GameObjectState _state = null;

    protected override void Start()
    {
        base.Start();

        _overlayController = OrganInfoOverlayController.Instance;
    }

    protected override void OnSelected(LeanSelect select)
    {
        this.BackupState();

        _overlayController.UpdateOverlayContentByOrgan(_humanOrgan);
        _overlayController.ShowOverlay();
    }

    protected override void OnDeselected(LeanSelect select)
    {
        _overlayController.HideOverlay();
    }

    public void Reset()
    {
        if (_state == null)
        {
            return;
        }

        _state.Restore(transform);
    }

    private void BackupState()
    {
        if (_state != null)
        {
            return;
        }

        _state = new GameObjectState();
        _state.Save(transform);
    }
}
