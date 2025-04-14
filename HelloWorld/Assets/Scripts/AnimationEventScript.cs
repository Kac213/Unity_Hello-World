using UnityEngine;

public class AnimationEventScript : MonoBehaviour
{
    public void AnimationEvent(string message)
    {
        Debug.Log("Animation Event Triggered: " + message);
    }
}
