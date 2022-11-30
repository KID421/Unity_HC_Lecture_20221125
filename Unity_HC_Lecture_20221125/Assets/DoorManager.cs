using UnityEngine;

public class DoorManager : MonoBehaviour
{
    private bool hasKey;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name.Contains("Æ_°Í"))
        {
            hasKey = true;
            Destroy(hit.gameObject);
        }

        if (hit.gameObject.name.Contains("ªù"))
        {
            if (hasKey)
            {
                hit.gameObject.transform.parent.GetComponent<Animator>().enabled = true;
            }
        }
    }
}
