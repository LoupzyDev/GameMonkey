using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuaternion : MonoBehaviour 
{
    public float sA=0;
    public float sB= 0.7f;

    public Vector3 qVector = new Vector3 (2,0,0);
    public Vector3 pVector = new Vector3(0, 0, 0.7f);

    Quaternion qA;
    Quaternion qB;
    

    private void Update()
    {

        qA = new Quaternion(qVector.x, qVector.y, qVector.z, sA);
        qB = new Quaternion(pVector.x, pVector.y, pVector.z, sB);

        print("Update" + (qA * qB));
        multQuaternion();
        print("Loupzy" + multQuaternion());
    }

    private Quaternion multQuaternion()
    {
        float ctnW = (qA.w * qB.w) - (qA.x * qB.x) - (qA.y * qB.y) - (qA.z * qB.z);
        float ctnX = +(qA.w * qB.x) + (qB.w * qA.x) + (qA.y * qB.z) - (qB.y * qA.z);
        float ctnY = +(qA.w * qB.y) + (qB.w * qA.y) + (qA.z * qB.x) - (qB.z * qA.x);
        float ctnZ = +(qA.w * qB.z) + (qB.w * qA.z) + (qA.x * qB.y) - (qB.x * qA.y);

        return new Quaternion(ctnW, ctnX, ctnY, ctnZ);

    }


}
