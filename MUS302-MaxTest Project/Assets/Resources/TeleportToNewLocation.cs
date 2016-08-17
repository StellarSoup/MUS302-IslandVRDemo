using UnityEngine;
using System.Collections;

public class TeleportToNewLocation : Interact {

    public Vector3 newPos;
    protected override void SubmitAction()
    {
        base.SubmitAction();
        Teleport();
    }

    private void Teleport()
    {
        Camera.main.transform.position = newPos;
    }
}
