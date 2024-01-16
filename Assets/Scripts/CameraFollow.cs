using UnityEngine;

public class CameraFollow : MonoBehaviour {
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset = new Vector3(0f, 5f, -10f);
    [SerializeField] private float smoothSpeed = 5f;

    void LateUpdate() {
        if (target == null) {
            Debug.LogWarning("CameraFollow: No target set!");
            return;
        }

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        transform.LookAt(target.position);
    }
}
