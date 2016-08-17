using UnityEngine;
using System.Collections;

public class DestroyOnSite : Interact {

    protected override void SubmitAction()
    {
        base.SubmitAction();
        Destroy(gameObject);
    }
}
