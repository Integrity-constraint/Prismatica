
using System.Runtime;
using UnityEditor;

[CustomEditor(typeof(Interactble), true)]
public class InteractbleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Interactble interactble = (Interactble)target;
        base.OnInspectorGUI();
        if(interactble.useEvents)
        {
            if(interactble.GetComponent<InteractionEvent>() == null)
            {
                interactble.gameObject.AddComponent<InteractionEvent>();
            }
              
        }
        else
        {
            if (interactble.GetComponent<InteractionEvent>() != null)
            {
                DestroyImmediate(interactble.GetComponent<InteractionEvent>());
            }
               
        }
    }
}
